using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Operators;

namespace ISU_RSA_Crypto
{
    class CertManager
    {
        private X509Store certStore = new X509Store(StoreName.My, StoreLocation.CurrentUser);

        public X509Certificate2 create(string certName, int length)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(length);
            var keypair = DotNetUtilities.GetRsaKeyPair(rsa);

            var gen = new X509V3CertificateGenerator();
            var name = new X509Name("CN=" + certName);
            var serial = new BigInteger(Encoding.ASCII.GetBytes("ISU_RSA_Crypto"));

            gen.SetSerialNumber(serial);
            gen.SetIssuerDN(name);
            gen.SetSubjectDN(name);
            gen.SetNotBefore(DateTime.Now.AddDays(-7));
            gen.SetNotAfter(DateTime.Now.AddYears(10));
            gen.SetPublicKey(keypair.Public);

            var newCert = gen.Generate(new Asn1SignatureFactory("SHA512withRSA", keypair.Private));
            var cert = new X509Certificate2(DotNetUtilities.ToX509Certificate(newCert));

            cert.PrivateKey = DotNetUtilities.ToRSA(keypair.Private as RsaPrivateCrtKeyParameters);
            return cert;
        }

        public X509Certificate2 getCertFromStore(string name)
        {
            certStore.Open(OpenFlags.ReadOnly);
            X509Certificate2Collection certCol = certStore.Certificates;
            foreach (X509Certificate2 cert in certCol)
            {
                if (cert.SubjectName.Name == name)
                {
                    certStore.Close();
                    return cert;
                }
            }
            certStore.Close();
            return null;
        }

        public void saveCertToStore(X509Certificate2 cert)
        {
            certStore.Open(OpenFlags.ReadWrite);
            certStore.Add(cert);
            certStore.Close();
        }

        public void saveCertToPFX(string PFX_Name, X509Certificate2 cert, string password)
        {
            File.WriteAllBytes(PFX_Name, cert.Export(X509ContentType.Pfx, password));
        }

        public List<string> listCerts()
        {
            List<string> Certs = new List<string>();
            certStore.Open(OpenFlags.ReadOnly);
            var certCol = certStore.Certificates;
            foreach (var cert in certCol)
                Certs.Add(cert.SubjectName.Name);
            return Certs;
        }
    }
}
