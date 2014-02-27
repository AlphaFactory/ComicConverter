using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicConverter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
