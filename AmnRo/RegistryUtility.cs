using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
    }
}
