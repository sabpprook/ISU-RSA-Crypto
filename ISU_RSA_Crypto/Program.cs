using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace ISU_RSA_Crypto
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += AssemblyResolve;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static Assembly AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string filename = "ISU_RSA_Crypto.Crypto.dll";
            using (Stream compressed = Assembly.GetExecutingAssembly().GetManifestResourceStream(filename))
            using (var decompressor = new DeflateStream(compressed, CompressionMode.Decompress))
            {
                byte[] data = new byte[2236416];
                decompressor.Read(data, 0, data.Length);
                compressed.Close();
                decompressor.Close();
                return Assembly.Load(data);
            }
        }
    }
}
