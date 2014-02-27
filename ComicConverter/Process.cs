using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ionic.Zip;
using System.Drawing;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ComicConverter
{
    class Process
    {
        private static Main form;
        private String targetPath;

        setProgressBar2_Delegate spb2 = new setProgressBar2_Delegate(setProgressBar2);
        setProgressBar3_Delegate spb3 = new setProgressBar3_Delegate(setProgressBar3);
        setProgressBar4_Delegate spb4 = new setProgressBar4_Delegate(setProgressBar4);
        setProgressBar5_Delegate spb5 = new setProgressBar5_Delegate(setProgressBar5);


        private String extractPath;

        public Process(Main _form, String _targetpath)
        {
            form = _form;
            targetPath = _targetpath;
        }

        public void DoProcessEpub(string zipPath, string title, string writer)
        {
            
            String guid = Guid.NewGuid().ToString();
            extractPath = Path.Combine(targetPath, "[" + writer + "] " + title);

            String titleinXml = System.Net.WebUtility.HtmlEncode(title);

            if (!System.IO.Directory.Exists(extractPath))
                System.IO.Directory.CreateDirectory(extractPath);

            DirectoryInfo di = new DirectoryInfo(extractPath + @"\META-INF");
            di.Create();
            di = new DirectoryInfo(extractPath + @"\OEBPS");
            di.Create();

            int Num_totalImage = 0, Num_totalWork = 0, Num_currentImage = 0, Num_currentWork = 0;


            extractImages(zipPath);
            processImages();
            GC.Collect();

            makeXHTML(titleinXml, ref Num_currentWork, ref Num_totalWork);
            GC.Collect();

            makeMimetype();
            form.Invoke(spb4, (Num_currentWork++), Num_totalWork);

            makeOption();
            form.Invoke(spb4, (Num_currentWork++), Num_totalWork);

            makeContainer();
            form.Invoke(spb4, (Num_currentWork++), Num_totalWork);

            makeOPF(writer, guid, titleinXml);
            form.Invoke(spb4, (Num_currentWork++), Num_totalWork);

            makeTOC(guid, titleinXml);
            form.Invoke(spb4, (Num_currentWork++), Num_totalWork);

            String outPathname;
            if (System.IO.File.Exists(Path.Combine(targetPath, title + ".epub")))
            {
                int i = 1;
                while (System.IO.File.Exists(Path.Combine(targetPath, title + i + ".epub")))
                {
                    i++;
                }
                outPathname = Path.Combine(targetPath, title + i + ".epub");
            }
            else
            {
                outPathname = Path.Combine(targetPath, title + ".epub");
            }

            using (Ionic.Zip.ZipFile zipzip = new Ionic.Zip.ZipFile(outPathname, Encoding.UTF8))
            {
                try
                {
                    zipzip.CompressionLevel = Ionic.Zlib.CompressionLevel.Level0;
                    zipzip.AddFile(extractPath + @"\mimetype", "");
                    zipzip.Save();
                    form.Invoke(spb5, 0, Num_totalImage + Num_totalWork);

                    zipzip.CompressionLevel = Ionic.Zlib.CompressionLevel.Level9;
                    zipzip.SaveProgress += SaveProgress;
                    zipzip.AddDirectory(extractPath + @"\META-INF\", "META-INF");
                    zipzip.AddDirectory(extractPath + @"\OEBPS\", "OEBPS");
                    zipzip.Save();
                }
                catch (UnauthorizedAccessException e)
                {
                    System.Console.Write(e.ToString());
                    form.canAccess = false;
                    form.Invoke(new showErrorMessageBox_Delegate(showErrorMessageBox));
                    System.IO.Directory.Delete(extractPath, true);
                }
            }
        }

        private void extractImages(string zipPath)
        {
            int Num_currentImage = 0, Num_totalImage = 0;
            ZipFile archive = new ZipFile(zipPath, Encoding.Default);
            Func<ZipEntry, bool> predicate = delegate(ZipEntry files) { return isImageFile(files.FileName); };
            Num_totalImage = archive.Count(predicate);
            foreach (ZipEntry entry in archive.EntriesSorted)
            {
                if (isImageFile(entry.FileName))
                {
                    try
                    {
                        entry.FileName = String.Format("{0:D8}" + entry.FileName.Substring(entry.FileName.LastIndexOf(".")), Num_currentImage);
                        entry.Extract((Path.Combine(extractPath, "TEMP")), ExtractExistingFileAction.OverwriteSilently);
                        form.Invoke(spb2, (Num_currentImage++), Num_totalImage);
                    }
                    catch (System.Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                    }
                }
            }
            archive.Dispose();
        }

        private void processImages()
        {
            int Num_currentImage = 0, Num_totalImage = 0;

            //JPEG or PNG // and Quality
            ImageCodecInfo imageCodec;
            EncoderParameters encoderParams = new EncoderParameters(1);

            Properties.Settings setting = new Properties.Settings();
            if (setting.imagetype.Equals("jpg"))
            {
                imageCodec = getEncoderInfo("image/jpeg");
                encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)setting.quality);
            }
            else if (setting.imagetype.Equals("png"))
            {
                imageCodec = getEncoderInfo("image/png");
                encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, 100L);
            }
            else
            {
                imageCodec = getEncoderInfo("image/gif");
                encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, 100L);
            }

            // 2쪽 분할
            bool doSplitLandscape = setting.dosplitLandscape;

            // 표지 분할
            bool doSplitCover = setting.dosplitCover;

            // 리사이즈 유형
            int resizeType = 0;
            form.BeginInvoke((MethodInvoker)delegate
            {
                resizeType = setting.resizeType;
            });
            // 0. 가운데 맞춤(기본)
            // 1. 가로 맞춤
            // 2. 세로 맞춤
            // 3. 종횡비 무시
            // 4. 리사이징 하지 않음

            // 유저 지정 사이즈
            int userWidth = (int)setting.userWidth;
            int userHeight = (int)setting.userHeight;

            int currentImageNum = 0;

            string[] filenames = Directory.GetFiles(Path.Combine(extractPath + @"\TEMP"));
            Num_totalImage = filenames.Count();

            foreach (string filename in filenames)
            {
                Bitmap image = new Bitmap(filename);
                Bitmap resized = null, cloneTempImage = null;
                Graphics g = null;
                int sourceWidth = image.Width;
                int sourceHeight = image.Height;
                int destWidth = 0, destHeight = 0;

                bool isLandScape = sourceWidth > sourceHeight;
                float nPercent = 0, nPercentW = 0, nPercentH = 0;

                switch (resizeType)
                {
                    case 0: // 0. 가운데 맞춤(기본)
                        if (isLandScape)
                            nPercentW = ((float)userWidth / (float)sourceWidth) * 2;
                        else
                            nPercentW = ((float)userWidth / (float)sourceWidth);

                        nPercentH = ((float)userHeight / (float)sourceHeight);

                        nPercent = (nPercentH < nPercentW) ? nPercentH : nPercentW;
                        destWidth = (int)(sourceWidth * nPercent);
                        destHeight = (int)(sourceHeight * nPercent);

                        resized = new Bitmap(userWidth, userHeight);

                        g = Graphics.FromImage(resized);
                        g.CompositingQuality = CompositingQuality.HighQuality;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.FillRectangle(new SolidBrush(Color.White), 0, 0, userWidth, userHeight);
                        break;


                    case 1:// 1. 가로 맞춤
                        if (isLandScape)
                            nPercentW = ((float)userWidth / (float)sourceWidth) * 2;
                        else
                            nPercentW = ((float)userWidth / (float)sourceWidth);

                        destWidth = (int)(sourceWidth * nPercentW);
                        userHeight = destHeight = (int)(sourceHeight * nPercentW);


                        resized = new Bitmap(userWidth, destHeight);

                        g = Graphics.FromImage(resized);
                        g.CompositingQuality = CompositingQuality.HighQuality;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.FillRectangle(new SolidBrush(Color.White), 0, 0, destWidth, destHeight);
                        break;


                    case 2: // 2. 세로 맞춤
                        nPercentH = ((float)userHeight / (float)sourceHeight);

                        destWidth = (int)(sourceWidth * nPercentH);
                        userWidth = isLandScape ? destWidth / 2 : destWidth;
                        destHeight = (int)(sourceHeight * nPercentH);

                        resized = new Bitmap(isLandScape ? destWidth / 2 : destWidth, userHeight);

                        g = Graphics.FromImage(resized);
                        g.CompositingQuality = CompositingQuality.HighQuality;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.FillRectangle(new SolidBrush(Color.White), 0, 0, isLandScape ? destWidth / 2 : destWidth, destHeight);
                        break;

                    case 3:// 3. 종횡비 무시

                        destWidth = isLandScape ? userWidth * 2 : userWidth;
                        destHeight = userHeight;

                        resized = new Bitmap(isLandScape ? destWidth / 2 : destWidth, userHeight);

                        g = Graphics.FromImage(resized);
                        g.CompositingQuality = CompositingQuality.HighQuality;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.FillRectangle(new SolidBrush(Color.White), 0, 0, isLandScape ? destWidth / 2 : destWidth, destHeight);
                        break;

                    case 4: // 4. 리사이징 하지 않음

                        destWidth = sourceWidth;
                        userWidth = isLandScape ? sourceWidth / 2 : sourceWidth;
                        destHeight = userHeight = sourceHeight;
                        
                        resized = new Bitmap(isLandScape ? destWidth / 2 : destWidth, userHeight);

                        g = Graphics.FromImage(resized);
                        g.CompositingQuality = CompositingQuality.HighQuality;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.FillRectangle(new SolidBrush(Color.White), 0, 0, isLandScape ? destWidth / 2 : destWidth, destHeight);
                        break;
                }


                if (isLandScape)
                {
                    bool isLTR = setting.direction.Equals("ltr");
                    Rectangle rect1, rect2;

                    if (filename.EndsWith("00000000.jpg", StringComparison.OrdinalIgnoreCase)
                        || filename.EndsWith("00000000.png", StringComparison.OrdinalIgnoreCase)
                        || filename.EndsWith("00000000.gif", StringComparison.OrdinalIgnoreCase))
                    {
                        if (doSplitCover)
                        {
                            rect1 = new Rectangle(isLTR ? sourceWidth / 2 : 0, 0, sourceWidth / 2, sourceHeight);
                            rect2 = new Rectangle(isLTR ? 0 : sourceWidth / 2, 0, sourceWidth / 2, sourceHeight);
                        }
                        else
                        {
                            rect1 = new Rectangle(isLTR ? 0 : sourceWidth / 2, 0, sourceWidth / 2, sourceHeight);
                            rect2 = new Rectangle(isLTR ? sourceWidth / 2 : 0, 0, sourceWidth / 2, sourceHeight);
                        }
                    }
                    else
                    {
                        rect1 = new Rectangle(isLTR ? 0 : sourceWidth / 2, 0, sourceWidth / 2, sourceHeight);
                        rect2 = new Rectangle(isLTR ? sourceWidth / 2 : 0, 0, sourceWidth / 2, sourceHeight);
                    }

                    g.DrawImage(cloneTempImage = image.Clone(rect1, image.PixelFormat), (userWidth - destWidth / 2) / 2, (userHeight - destHeight) / 2, destWidth / 2, destHeight);
                    SaveImage(ref resized, currentImageNum, imageCodec, encoderParams);
                    cloneTempImage.Dispose();
                    currentImageNum++;

                    g.FillRectangle(new SolidBrush(Color.White), 0, 0, userWidth, userHeight);

                    g.DrawImage(cloneTempImage = image.Clone(rect2, image.PixelFormat), (userWidth - destWidth / 2) / 2, (userHeight - destHeight) / 2, destWidth / 2, destHeight);
                    SaveImage(ref resized, currentImageNum, imageCodec, encoderParams);
                    cloneTempImage.Dispose();
                    currentImageNum++;
                }
                else
                {
                    g.DrawImage(image, (userWidth - destWidth) / 2, (userHeight - destHeight) / 2, destWidth, destHeight);
                    SaveImage(ref resized, currentImageNum, imageCodec, encoderParams);
                    currentImageNum++;
                }

                image.Dispose();
                resized.Dispose();
                g.Dispose();

                form.Invoke(spb3, (Num_currentImage++), Num_totalImage);

            }
        }

        private void SaveImage(ref Bitmap bm, int currentImageNum, ImageCodecInfo ic, EncoderParameters param)
        {
            Properties.Settings setting = new Properties.Settings();
            bm.Save(Path.Combine(extractPath, "OEBPS", String.Format("{0:D8}", currentImageNum) + "." + setting.imagetype), ic, param);
        }

        private ImageCodecInfo getEncoderInfo(string mimeType)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType == mimeType)
                    return codecs[i];
            return null;
        }


        private void makeXHTML(String titleinXml, ref int currentWork, ref int totalWork)
        {
            Properties.Settings setting = new Properties.Settings();

            int metaWidth = 0;
            int metaHeight = 0;

            var imagefiles = from file in Directory.GetFiles(Path.Combine(extractPath, "OEBPS")) orderby file ascending select file;
            totalWork = imagefiles.Count() + 5;
            foreach (string imagefile in imagefiles)
            {
                Image tempimage = Image.FromFile(imagefile);
                Size size = tempimage.Size;
                tempimage.Dispose();
                int Width = size.Width, Height = size.Height;

                if (metaWidth == 0)
                {
                    metaWidth = Width; metaHeight = Height;
                }

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"no\"?>");
                sb.AppendLine("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.1//EN\"");
                sb.AppendLine("\"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\">");
                sb.AppendLine("<html xmlns=\"http://www.w3.org/1999/xhtml\" xml:lang=\"en\">");
                sb.AppendLine("<head>");
                sb.AppendLine("<title>" + titleinXml + "</title>");
                if (!setting.forApple)
                {
                    sb.AppendLine("<style type=\"text/css\">body{width:" + Width + "px;height:" + Height + "px;margin:0;padding:0;}img {width:" + Width + "px;height:" + Height + "px;position:absolute;padding:0;margin:0;top:0;left:0;}</style>");
                    sb.AppendLine("<meta content=\"width=" + Width + ", height=" + Height + "\" name=\"viewport\" />");
                }
                else
                {
                    sb.AppendLine("<style type=\"text/css\">body{width:" + metaWidth + "px;height:" + metaHeight + "px;margin:0;padding:0;}");
                    if (setting.forceResizing)
                    {
                        sb.AppendLine("img {width:" + metaWidth + "px;height:" + metaHeight + "px;position:absolute;padding:0;margin:0;top:0;left:0;}</style>");
                    }
                    else
                    {
                        float nPercent = 0, nPercentW = 0, nPercentH = 0;
                        nPercentW = ((float)metaWidth / (float)Width);
                        nPercentH = ((float)metaHeight / (float)Height);

                        nPercent = (nPercentH < nPercentW) ? nPercentH : nPercentW;
                        int destWidth = (int)(Width * nPercent);
                        int destHeight = (int)(Height * nPercent);

                        sb.AppendLine("img {width:" + destWidth + "px;height:" + destHeight + "px;position:absolute;padding:0;margin:0;top:" + ((metaHeight - destHeight) / 2) + ";left:" + ((metaWidth - destWidth) / 2) + ";}</style>");
                    }

                    sb.AppendLine("<meta content=\"width=" + metaWidth + ", height=" + metaHeight + "\" name=\"viewport\" />");
                }
                sb.AppendLine("</head>");
                sb.AppendLine("<body>");
                sb.AppendLine("<div><img alt=\"\" src=\"" + imagefile.Substring(imagefile.LastIndexOf("\\") + 1) + "\" /></div>");
                sb.AppendLine("</body>");
                sb.AppendLine("</html>");

                string XHTML = imagefile.Substring(imagefile.LastIndexOf("\\"));
                XHTML = XHTML.Substring(0, XHTML.LastIndexOf(".")) + ".xhtml";

                writeFile(extractPath, @"OEBPS\" + XHTML, sb.ToString(), Encoding.UTF8);

                form.Invoke(spb4, (currentWork++), totalWork);
            }
        }

        private void makeMimetype()
        {
            string xmlText = "application/epub+zip";
            writeFile(extractPath, "mimetype", xmlText, Encoding.ASCII);
        }
        private void makeOption()
        {
            string xmlText = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><display_options><platform name=\"*\"><option name=\"fixed-layout\">true</option></platform></display_options>";
            writeFile(extractPath, @"META-INF\com.apple.ibooks.display-options.xml", xmlText, Encoding.UTF8);
        }

        private void makeContainer()
        {
            string xmlText = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><container version=\"1.0\" xmlns=\"urn:oasis:names:tc:opendocument:xmlns:container\"><rootfiles><rootfile full-path=\"OEBPS/content.opf\" media-type=\"application/oebps-package+xml\"/></rootfiles></container>";
            writeFile(extractPath, @"META-INF\container.xml", xmlText, Encoding.UTF8);
        }

        private void makeOPF(string writer, String guid, String titleinXml)
        {
            Properties.Settings setting = new Properties.Settings();

            var list_image = from file in Directory.GetFiles(Path.Combine(extractPath, "OEBPS")) where (isImageFile(file)) orderby file ascending select file;
            var list_xhtml = from file in Directory.GetFiles(Path.Combine(extractPath, "OEBPS")) where (file.EndsWith("xhtml")) orderby file ascending select file;

            StringBuilder contentodf = new StringBuilder();
            contentodf.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\" ?>");
            contentodf.AppendLine("<package xmlns=\"http://www.idpf.org/2007/opf\" unique-identifier=\"bookid\" version=\"2.0\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\">");
            contentodf.AppendLine("<metadata>");
            contentodf.AppendLine("<dc:identifier id=\"bookid\">urn:uuid:" + guid + "</dc:identifier>");
            contentodf.AppendLine("<dc:title>" + titleinXml + "</dc:title>");
            contentodf.AppendLine("<dc:creator xmlns:opf=\"http://www.idpf.org/2007/opf\" opf:role=\"aut\">" + writer + "</dc:creator>");
            contentodf.AppendLine("<dc:language>en</dc:language>");
            contentodf.AppendLine("<dc:date xmlns:opf=\"http://www.idpf.org/2007/opf\" opf:event=\"modification\">" + DateTime.Now.ToString("yyyy-MM-dd") + "</dc:date>");
            contentodf.AppendLine("<meta content=\"1.0.0\" name=\"Comic Converter By AlphaFactory\"/>");
            String coverid = list_image.First();
            contentodf.AppendLine("<meta name=\"cover\" content=\"image_" + coverid.Substring(coverid.LastIndexOf("\\") + 1, 8) + "\"/>");
            contentodf.AppendLine("</metadata>");
            contentodf.AppendLine("<manifest>");
            contentodf.AppendLine("<item href=\"toc.ncx\" id=\"ncxtoc\" media-type=\"application/x-dtbncx+xml\"/>");

            foreach (String curimg in list_image)
                contentodf.AppendLine("<item href=\"" + curimg.Substring(curimg.LastIndexOf("\\") + 1) + "\" id=\"image_" + curimg.Substring(curimg.LastIndexOf("\\") + 1, 8) + "\" media-type=\"image/jpeg\"/>");

            foreach (String curXhtml in list_xhtml)
                contentodf.AppendLine("<item href=\"" + curXhtml.Substring(curXhtml.LastIndexOf("\\") + 1) + "\" id=\"xhtml_" + curXhtml.Substring(curXhtml.LastIndexOf("\\") + 1, 8) + "\" media-type=\"application/xhtml+xml\"/>");

            contentodf.AppendLine("</manifest>");
            contentodf.AppendLine("<spine page-progression-direction=\"" + setting.direction + "\" toc=\"ncxtoc\">");

            foreach (String curXhtml in list_xhtml)
                contentodf.AppendLine("<itemref idref=\"xhtml_" + curXhtml.Substring(curXhtml.LastIndexOf("\\") + 1, 8) + "\"/>");

            contentodf.AppendLine("</spine>");
            contentodf.AppendLine("<guide>");
            contentodf.AppendLine("</guide>");
            contentodf.AppendLine("</package>");
            writeFile(extractPath, @"OEBPS\content.opf", contentodf.ToString(), System.Text.Encoding.UTF8);
        }

        private void makeTOC(String guid, String titleinXml)
        {
            StringBuilder tocncx = new StringBuilder();
            tocncx.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\" ?>");
            tocncx.AppendLine("<!DOCTYPE ncx PUBLIC \"-//NISO//DTD ncx 2005-1//EN\"");
            tocncx.AppendLine("\"http://www.daisy.org/z3986/2005/ncx-2005-1.dtd\">");
            tocncx.AppendLine("<ncx xmlns=\"http://www.daisy.org/z3986/2005/ncx/\" version=\"2005-1\">");
            tocncx.AppendLine("<head>");
            tocncx.AppendLine("<meta content=\"urn:uuid:" + guid + "\" name=\"dtb:uid\"/>");
            tocncx.AppendLine("<meta content=\"0\" name=\"dtb:depth\"/>");
            tocncx.AppendLine("<meta content=\"0\" name=\"dtb:totalPageCount\"/>");
            tocncx.AppendLine("<meta content=\"0\" name=\"dtb:maxPageNumber\"/>");
            tocncx.AppendLine("</head>");
            tocncx.AppendLine("<docTitle>");
            tocncx.AppendLine("<text>" + titleinXml + "</text>");
            tocncx.AppendLine("</docTitle>");
            tocncx.AppendLine("<navMap>");
            tocncx.AppendLine("<navPoint id=\"navPoint-1\" playOrder=\"1\">");
            tocncx.AppendLine("<navLabel>");
            tocncx.AppendLine("<text>Start</text>");
            tocncx.AppendLine("</navLabel>");
            tocncx.AppendLine("<content src=\"00000000.xhtml\"/>");
            tocncx.AppendLine("</navPoint>");
            tocncx.AppendLine("</navMap>");
            tocncx.AppendLine("</ncx>");

            writeFile(extractPath, @"OEBPS\toc.ncx", tocncx.ToString(), System.Text.Encoding.UTF8);
        }

        private bool isImageFile(String path)
        {
            return path.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase)
                        || path.EndsWith(".gif", StringComparison.OrdinalIgnoreCase)
                        || path.EndsWith(".png", StringComparison.OrdinalIgnoreCase);
        }

        private void writeFile(String extractPath, String filename, String textinXML, Encoding encoding)
        {
            StreamWriter SWrite = new StreamWriter(Path.Combine(extractPath, filename), false, encoding);
            SWrite.Write(textinXML);
            SWrite.Close();
        }

        public delegate void setProgressBar1_Delegate(int current, int total);
        public delegate void setProgressBar2_Delegate(int current, int total);
        public delegate void setProgressBar3_Delegate(int current, int total);
        public delegate void setProgressBar4_Delegate(int current, int total);
        public delegate void setProgressBar5_Delegate(int current, int total);
        public delegate void showErrorMessageBox_Delegate();


        public static void showErrorMessageBox()
        {
            MessageBox.Show(Properties.Resources.FileAccessError, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void setProgressBar1(int current, int total)
        {
            setProgressBar(form.progressBar1, form.progressLabel1, current, total, "전체 진행도 : ");
        }

        public static void setProgressBar2(int current, int total)
        {
            setProgressLabel(form.progressLabel2, current, total, "1. 압축 해제 중... ");
        }

        public static void setProgressBar3(int current, int total)
        {
            setProgressLabel(form.progressLabel3, current, total, "2. 이미지 처리 중... ");
        }

        public static void setProgressBar4(int current, int total)
        {
            setProgressLabel(form.progressLabel4, current, total, "3. 필요 파일 작성 중... ");
        }

        public static void setProgressBar5(int current, int total)
        {
            setProgressLabel(form.progressLabel5, current, total, "4. EPUB 파일 생성 중... ");
        }

        public static void setProgressBar(ProgressBar pb, Label lb, int current, int total, String text)
        {
            if (total != 0)
            {
                pb.Maximum = total;
                pb.Value = current + 1;
                lb.Text = text + (current + 1) + "/" + total + " (" + (100 * (current + 1) / total) + "%)";
            }
            else
            {
                pb.Value = pb.Maximum = 0;
                lb.Text = text + "0/0 (0%)";
            }
        }

        public static void setProgressLabel(Label lb, int current, int total, String text)
        {
            if (total != 0)            
                lb.Text = text + (current + 1) + "/" + total + " (" + (100 * (current + 1) / total) + "%)";            
            else
                lb.Text = text + "0/0 (0%)";
        }

        public void SaveProgress(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Saving_Started)
            {

            }
            else if (e.EventType == ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                form.Invoke(spb5, e.EntriesSaved+1, e.EntriesTotal+1);
            }
            else if (e.EventType == ZipProgressEventType.Saving_EntryBytesRead)
            {

            }
            else if (e.EventType == ZipProgressEventType.Saving_Completed)
            {
                ((ZipFile)sender).Dispose();
                RemoveFolder(Path.Combine(extractPath, "TEMP"));
                RemoveFolder(Path.Combine(extractPath, "META-INF"));
                RemoveFolder(Path.Combine(extractPath, "OEBPS"));
                RemoveFolder(extractPath);
            }
        }

        public void RemoveFolder(string foldername)
        {
            DirectoryInfo Folder = new DirectoryInfo(foldername);
            if (Folder.Exists)
            {
                Folder.Attributes = Folder.Attributes & ~System.IO.FileAttributes.ReadOnly;
                FileInfo[] files = Folder.GetFiles();
                Array.ForEach<FileInfo>(files, new Action<FileInfo>(
                                            f =>
                                            {
                                                File.SetAttributes(f.FullName, FileAttributes.Normal);
                                            }));
                Folder.Delete(true);
            }
        }
    }

}
