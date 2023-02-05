using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmnRo
{
    public static class AdditionalBufferStructure
    {
        public static int FullSize
        {
            get
            {
                return ExtensionSize + VersionSize;
            }
        }
        public const int ExtensionSize = 40;
        public const int VersionSize = 20;

    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {   
                        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0 && args[0] == "integrate")
            {
                RegistryUtility.IntegrateCustomIcons();
            }
            Application.Run(new FormBase());

        }
    }
}
