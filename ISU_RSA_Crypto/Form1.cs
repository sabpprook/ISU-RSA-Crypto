using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace ISU_RSA_Crypto
{
    public partial class Form1 : Form
    {
        X509Certificate2 MyCert;
        CertManager certManager = new CertManager();
        RSACryptoServiceProvider RSA;
        AESCrypto AES;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_certsRefreash_Click(null, null);
        }

        private void btn_certsRefreash_Click(object sender, EventArgs e)
        {
            listBox_certs.Items.Clear();
            var certs = certManager.listCerts();
            foreach(var str in certs)
            {
                listBox_certs.Items.Add(str);
            }
        }

        private void btn_makeCert_Click(object sender, EventArgs e)
        {
            int length;
            if (rbtn_1024.Checked)
                length = 1024;
            else if (rbtn_2048.Checked)
                length = 2048;
            else
                length = 4096;
            if (!String.IsNullOrEmpty(txt_certName.Text))
                MyCert = certManager.create(txt_certName.Text, length);
            updateRSAKey(MyCert);
        }

        private void saveCertToStore(object sender, EventArgs e)
        {
            if (MyCert != null)
                certManager.saveCertToStore(MyCert);
            else
                MessageBox.Show("請先產生憑證!");
        }

        private void saveCertToPFX(object sender, EventArgs e)
        {
            if (MyCert != null)
            {
                if (String.IsNullOrEmpty(txt_certPassword.Text))
                    MessageBox.Show("請輸入密碼!");
                else
                {
                    if (savePFXDialog.ShowDialog() == DialogResult.OK)
                        certManager.saveCertToPFX(savePFXDialog.FileName, MyCert, txt_certPassword.Text);
                }
            }
            else
                MessageBox.Show("請先產生憑證!");
        }

        private void updateRSAKey(X509Certificate2 cert)
        {
            txt_certPrivateKey.Text = "";
            if (cert.HasPrivateKey)
            {
                RSA = (RSACryptoServiceProvider)cert.PrivateKey;
                txt_certPrivateKey.Text = RSA.ToXmlString(true);
            }
            else
                RSA = (RSACryptoServiceProvider)cert.PublicKey.Key;
            txt_certPublicKey.Text = RSA.ToXmlString(false);
            AES = new AESCrypto(RSA, progressBar1);
            txt_AESKey.Text = AES.getAESKey();
        }

        private void listBox_certs_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyCert = certManager.getCertFromStore(listBox_certs.GetItemText(listBox_certs.SelectedItem));
            if (MyCert != null)
                updateRSAKey(MyCert);
        }

        private void btn_readPublicKey_Click(object sender, EventArgs e)
        {
            if (openCerDialog.ShowDialog() == DialogResult.OK)
            {
                X509Certificate2 cert = new X509Certificate2(openCerDialog.FileName);
                updateRSAKey(cert);
            }
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            if (RSA == null)
                MessageBox.Show("請先選擇憑證");
            else
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_fileName.Text = openFileDialog.FileName;
                    if (AES.isEncrypt(openFileDialog.FileName))
                    {
                        btn_Decrypt.Enabled = true;
                        btn_Encrypt.Enabled = false;
                    }
                    else
                    {
                        btn_Decrypt.Enabled = false;
                        btn_Encrypt.Enabled = true;
                    }
                }
            }
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            AES.AESEncrypt(txt_fileName.Text);
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            if (RSA.PublicOnly)
                MessageBox.Show("無私密金鑰以供解密");
            else
            {
                AES.AESDecrypt(txt_fileName.Text);
            }
        }

        private void txt_sourceFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txt_sourceFile_DragDrop(object sender, DragEventArgs e)
        {
            txt_sourceFile.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            string[] obj = { txt_sourceFile.Text, "SHA_1" };
            sha256Hash.RunWorkerAsync(obj);
        }

        private void txt_decFile_DragDrop(object sender, DragEventArgs e)
        {
            txt_decFile.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            string[] obj = { txt_decFile.Text, "SHA_2" };
            sha256Hash.RunWorkerAsync(obj);
        }

        private void sha256Hash_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] arg = e.Argument as string[];

            SHA256Managed sha = new SHA256Managed();
            using (FileStream fs = File.OpenRead(arg[0]))
            {
                byte[] data = new byte[1024*1024];
                int len = fs.Read(data, 0, data.Length);
                while (fs.Position < fs.Length)
                {
                    sha256Hash.ReportProgress(Convert.ToInt32(fs.Position * 100 / fs.Length)+1);
                    sha.TransformBlock(data, 0, len, data, 0);
                    len = fs.Read(data, 0, data.Length);
                }
                sha.TransformFinalBlock(data, 0, len);
            }
            e.Result = new string[] {BitConverter.ToString(sha.Hash).Replace("-", String.Empty), arg[1]};
        }

        private void sha256Hash_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
        }

        private void sha256Hash_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string[] result = e.Result as string[];
            if (result[1].Equals("SHA_1"))
                txt_SHA_1.Text = result[0];
            else
                txt_SHA_2.Text = result[0];
            progressBar2.Value = 100;
            if ((!string.IsNullOrEmpty(txt_SHA_1.Text)) && (!string.IsNullOrEmpty(txt_SHA_2.Text)))
            {
                if (txt_SHA_1.Text.Equals(txt_SHA_2.Text))
                    txt_compareResult.Text = "檔案相同";
                else
                    txt_compareResult.Text = "檔案不同";
            }
        }
    }
}
