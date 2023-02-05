using AmnRo.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmnRo
{

    class RegistryUtility
    {
        const string RegistryOpenWith = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FileExts\";

        [DllImport("shell32.dll")]
        static extern void SHChangeNotify(int wEventId,
                                   int uFlags,
                                   IntPtr dwItem1,
                                   IntPtr dwItem2);
        public enum Extensions
        {
            private_key_extension ,
            public_key_extension ,
            amn_extension,
        }

        private static string GetExtensionValue(Extensions ext)
        {
            switch (ext)
            {
                case Extensions.private_key_extension:
                    return ".priv";
                case Extensions.public_key_extension:
                    return ".pubk";
                case Extensions.amn_extension:
                    return ".amn";
                default:
                    throw new Exception("Unknown Extension");
            }
        }

        public static void SetValue(Extensions ext ,string key, object value)
        {
            string ext_key = GetExtensionValue(ext);


            RemoveRegistry(ext);

            var extSubKey = Registry.ClassesRoot.CreateSubKey(ext_key);
            if (extSubKey != null)
                extSubKey.SetValue("", "AmnRo.exe");


            var DefaultIcon = extSubKey.CreateSubKey("DefaultIcon");

            
            if (DefaultIcon != null)
                DefaultIcon.SetValue(key, value);
        }

        public static void RemoveRegistry(Extensions ext)
        {

            var ext_string = GetExtensionValue(ext);

            if (Registry.ClassesRoot.OpenSubKey(ext_string) != null)
                Registry.ClassesRoot.DeleteSubKeyTree(ext_string);

            string ext_openWith_path = RegistryOpenWith + ext_string;
            if (Registry.CurrentUser.OpenSubKey(ext_openWith_path) != null)
                Registry.CurrentUser.OpenSubKey(ext_openWith_path , true).DeleteSubKey("UserChoice" , false);

        }

        public static void RefereshWindowsIconCache()
        {
            try
            {
                int SHCNE_ASSOCCHANGED = 0x8000000;
                int SHCNF_FLUSH = 0x1000;
                SHChangeNotify(SHCNE_ASSOCCHANGED, SHCNF_FLUSH, IntPtr.Zero, IntPtr.Zero);
            }
            catch (Exception)
            {
            }

        }

        public static bool IntegrateCustomIcons()
        {
            string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Amnro";
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);

            var prikeyPath = dirPath + "\\PrivateKey.png";
            var pubkeyPath = dirPath + "\\PublicKey.png";
            var enc3Path = dirPath + "\\enc3.png";

            Resources.PrivateKey.Save(prikeyPath);
            Resources.PublicKey.Save(pubkeyPath);
            Resources.enc3.Save(enc3Path);


            bool err = false;

            try
            {
                RegistryUtility.SetValue(RegistryUtility.Extensions.private_key_extension, "", prikeyPath);
                RegistryUtility.SetValue(RegistryUtility.Extensions.public_key_extension, "", pubkeyPath);
                RegistryUtility.SetValue(RegistryUtility.Extensions.amn_extension, "", enc3Path);
            }
            catch (Exception exception)
            {
                err = true;
                //MessageBox.Show(exception.Message, "Integration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RegistryUtility.RefereshWindowsIconCache();
            return err;
        }

        public static void ExecuteAsAdmin()
        {
            try
            {
                var process = new Process();
                process.StartInfo.FileName = Path.Combine(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).FullName, "AmnRo.exe");
                process.StartInfo.Arguments = "integrate";
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.Verb = "runas";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();
                //process.WaitForExit();

                Application.Exit();
            }
            catch (Exception)
            {
            }
           
        }

        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        [DllImport("user32")]
        public static extern UInt32 SendMessage
            (IntPtr hWnd, UInt32 msg, UInt32 wParam, UInt32 lParam);
        internal const int BCM_FIRST = 0x1600; //Normal button
        internal const int BCM_SETSHIELD = (BCM_FIRST + 0x000C); //Elevated button
        public static void AddShieldToButton(Button button)
        {
            button.FlatStyle = FlatStyle.System;
            SendMessage(button.Handle, BCM_SETSHIELD, 0, 0xFFFFFFFF);
        }
    }
}
