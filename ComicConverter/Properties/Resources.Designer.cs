﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.18047
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComicConverter.Properties {
    using System;
    
    
    /// <summary>
    ///   지역화된 문자열 등을 찾기 위한 강력한 형식의 리소스 클래스입니다.
    /// </summary>
    // 이 클래스는 ResGen 또는 Visual Studio와 같은 도구를 통해 StronglyTypedResourceBuilder
    // 클래스에서 자동으로 생성되었습니다.
    // 멤버를 추가하거나 제거하려면 .ResX 파일을 편집한 다음 /str 옵션을 사용하여 ResGen을
    // 다시 실행하거나 VS 프로젝트를 다시 빌드하십시오.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   이 클래스에서 사용하는 캐시된 ResourceManager 인스턴스를 반환합니다.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ComicConverter.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   이 강력한 형식의 리소스 클래스를 사용하여 모든 리소스 조회에 대한 현재 스레드의 CurrentUICulture
        ///   속성을 재정의합니다.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Epub 파일을 생성할 수 없습니다. 권한이 없는 폴더입니다.
        ///대상 폴더를 변경해주시기 바랍니다.과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        internal static string FileAccessError {
            get {
                return ResourceManager.GetString("FileAccessError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Comic Converter for iBooks and Google Play Books (Ver 1.0.1.0)
        ///Developed By Alphafactory
        ///
        ///홈페이지 : http://www.alphafactory.co.kr/
        ///
        ///본 변환기 프로그램을 이용해 생성되는 EPUB 파일은 iBooks Style Fixed-Layout을 사용한 EPUB 3.0 파일입니다.과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        internal static string ProgramInfo {
            get {
                return ResourceManager.GetString("ProgramInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ver 1.0.1.0
        /// - 드래그앤 드롭으로 파일 추가
        /// - ZIP파일에 폴더이름에 &quot;.&quot;이 들어간 폴더가 있고 그 아래에 이미지 파일이 있는 경우 제대로 변환되지 않는 현상 수정
        /// - 권한이 없는 폴더에 변환시 프로그램 다운되는 현상 수정
        /// - 변환 대상 기기 옵션 추가
        /// - 양면 페이지 분할 및 표지 따로 분할 기능 추가
        /// - 이미지 화질 조절 옵션 추가
        /// - 이미지 크기 조절 옵션 추가
        /// - 이미지 변환 포맷 옵션 추가
        /// - EPUB 변환 대상 폴더 열기 버튼 UI에 추가
        ///
        ///Ver 1.0.0.3
        /// - 제목에 특수문자 있어도 제대로 변환되도록 수정.
        ///
        ///Ver 1.0.0.2
        /// - 특정 ZIP 파일을 변환시 책의 순서가 뒤죽박죽 되는 오류 수정
        /// - ZIP 폴더 내부에 폴더구조가 있을 경우 제대로 변환되지 않는 오류 수정
        /// - 이미지 파일 이름이 일본어, 한자 등으로 되어 있는 ZIP파일이 제대로 변환되지 않는 오류 수정.
        /// - EPUB 문법 오류 수정.
        /// - PNG, [나머지 문자열은 잘림]&quot;;과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        internal static string UpdateLog {
            get {
                return ResourceManager.GetString("UpdateLog", resourceCulture);
            }
        }
    }
}