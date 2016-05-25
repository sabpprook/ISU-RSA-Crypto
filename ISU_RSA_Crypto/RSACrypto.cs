using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ISU_RSA_Crypto
{
    class RSACrypto
    {
        private RSACryptoServiceProvider RSA;

        public RSACrypto(RSACryptoServiceProvider rsa)
        {
            RSA = rsa;
        }

        public byte[] Encrypt(byte[] data)
        {
            return RSA.Encrypt(data, false);
        }

        public byte[] Decrypt(byte[] data)
        {
            try
            {
                return RSA.Decrypt(data, false);
            }
            catch
            {
                throw new Exception("解密失敗!");
            }
        }

        public int getKeySize()
        {
            return RSA.KeySize;
        }
    }
}
