using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ISU_RSA_Crypto
{
    class AESCrypto
    {
        private AesCryptoServiceProvider AES;
        private RSACrypto RSA;
        ProgressBar ProgBar;
        
        public AESCrypto(RSACryptoServiceProvider rsa, ProgressBar _ProgBar = null)
        {
            RSA = new RSACrypto(rsa);
            AES = new AesCryptoServiceProvider();
            AES.IV = Encoding.ASCII.GetBytes("_ISU_RSA_Crypto_");
            ProgBar = _ProgBar;
        }

        public void AESEncrypt(string fileName)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (sender, e) =>
                {
                    byte[] Key = RSA.Encrypt(AES.Key);

                    FileStream src = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    FileStream dst = new FileStream(fileName + ".enc", FileMode.OpenOrCreate, FileAccess.Write);

                    dst.Write(Encoding.Default.GetBytes("Encrypt\0"), 0, 8);
                    dst.Write(Key, 0, Key.Length);

                    CryptoStream cfs = new CryptoStream(dst, AES.CreateEncryptor(), CryptoStreamMode.Write);
                    byte[] buffer = new byte[4096];
                    for (long i = 0; i < src.Length; i += 4096)
                    {
                        worker.ReportProgress(Convert.ToInt32(i * 100 / src.Length));
                        int dwRead = src.Read(buffer, 0, 4096);
                        cfs.Write(buffer, 0, dwRead);
                    }
                    cfs.Close();
                    dst.Close();
                    src.Close();
                };
            worker.ProgressChanged += (sender, e) =>
                {
                    ProgBar.Value = e.ProgressPercentage;
                };
            worker.RunWorkerCompleted += (sender, e) =>
                {
                    ProgBar.Value = 100;
                };
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.RunWorkerAsync();
        }

        public void AESDecrypt(string fileName)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (sender, e) =>
            {
                FileStream src = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                src.Seek(8, SeekOrigin.Current);
                byte[] EncAesKey = new byte[RSA.getKeySize() >> 3];
                src.Read(EncAesKey, 0, EncAesKey.Length);
                AES.Key = RSA.Decrypt(EncAesKey);

                FileStream dst = new FileStream(fileName + ".dec", FileMode.OpenOrCreate, FileAccess.Write);
                CryptoStream cfs = new CryptoStream(dst, AES.CreateDecryptor(), CryptoStreamMode.Write);
                byte[] buffer = new byte[4096];
                for (long i = 0; i < src.Length - EncAesKey.Length - 8; i += 4096)
                {
                    worker.ReportProgress(Convert.ToInt32(i * 100 / src.Length));
                    int dwRead = src.Read(buffer, 0, 4096);
                    cfs.Write(buffer, 0, dwRead);
                }
                cfs.Close();
                dst.Close();
                src.Close();
            };
            worker.ProgressChanged += (sender, e) =>
            {
                ProgBar.Value = e.ProgressPercentage;
            };
            worker.RunWorkerCompleted += (sender, e) =>
            {
                ProgBar.Value = 100;
            };
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.RunWorkerAsync();
        }

        public bool isEncrypt(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] header = new byte[8];
            fs.Read(header, 0, 8);
            fs.Close();
            return Encoding.Default.GetString(header).Equals("Encrypt\0");
        }

        public string getAESKey()
        {
            return Convert.ToBase64String(AES.Key);
        }
    }
}
