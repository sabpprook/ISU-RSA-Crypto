namespace ISU_RSA_Crypto
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_certs = new System.Windows.Forms.ListBox();
            this.btn_certsRefreash = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_makeCert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_certPassword = new System.Windows.Forms.TextBox();
            this.btn_makeCerttoPFX = new System.Windows.Forms.Button();
            this.btn_makeCerttoStore = new System.Windows.Forms.Button();
            this.rbtn_4096 = new System.Windows.Forms.RadioButton();
            this.rbtn_2048 = new System.Windows.Forms.RadioButton();
            this.rbtn_1024 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_certName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.txt_fileName = new System.Windows.Forms.TextBox();
            this.txt_AESKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_readPublicKey = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_compareResult = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_SHA_2 = new System.Windows.Forms.TextBox();
            this.txt_decFile = new System.Windows.Forms.TextBox();
            this.txt_SHA_1 = new System.Windows.Forms.TextBox();
            this.txt_sourceFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_certPrivateKey = new System.Windows.Forms.TextBox();
            this.txt_certPublicKey = new System.Windows.Forms.TextBox();
            this.savePFXDialog = new System.Windows.Forms.SaveFileDialog();
            this.openCerDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.sha256Hash = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 298);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "憑證管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_certs);
            this.groupBox2.Controls.Add(this.btn_certsRefreash);
            this.groupBox2.Location = new System.Drawing.Point(298, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 241);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "憑證庫";
            // 
            // listBox_certs
            // 
            this.listBox_certs.FormattingEnabled = true;
            this.listBox_certs.HorizontalScrollbar = true;
            this.listBox_certs.ItemHeight = 12;
            this.listBox_certs.Location = new System.Drawing.Point(19, 21);
            this.listBox_certs.Name = "listBox_certs";
            this.listBox_certs.Size = new System.Drawing.Size(190, 172);
            this.listBox_certs.TabIndex = 1;
            this.listBox_certs.TabStop = false;
            this.listBox_certs.SelectedIndexChanged += new System.EventHandler(this.listBox_certs_SelectedIndexChanged);
            // 
            // btn_certsRefreash
            // 
            this.btn_certsRefreash.Location = new System.Drawing.Point(19, 204);
            this.btn_certsRefreash.Name = "btn_certsRefreash";
            this.btn_certsRefreash.Size = new System.Drawing.Size(190, 23);
            this.btn_certsRefreash.TabIndex = 2;
            this.btn_certsRefreash.TabStop = false;
            this.btn_certsRefreash.Text = "重新整理";
            this.btn_certsRefreash.UseVisualStyleBackColor = true;
            this.btn_certsRefreash.Click += new System.EventHandler(this.btn_certsRefreash_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_makeCert);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_certPassword);
            this.groupBox1.Controls.Add(this.btn_makeCerttoPFX);
            this.groupBox1.Controls.Add(this.btn_makeCerttoStore);
            this.groupBox1.Controls.Add(this.rbtn_4096);
            this.groupBox1.Controls.Add(this.rbtn_2048);
            this.groupBox1.Controls.Add(this.rbtn_1024);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_certName);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "產生憑證";
            // 
            // btn_makeCert
            // 
            this.btn_makeCert.Location = new System.Drawing.Point(172, 84);
            this.btn_makeCert.Name = "btn_makeCert";
            this.btn_makeCert.Size = new System.Drawing.Size(75, 38);
            this.btn_makeCert.TabIndex = 11;
            this.btn_makeCert.TabStop = false;
            this.btn_makeCert.Text = "產生憑證";
            this.btn_makeCert.UseVisualStyleBackColor = true;
            this.btn_makeCert.Click += new System.EventHandler(this.btn_makeCert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "密碼:";
            // 
            // txt_certPassword
            // 
            this.txt_certPassword.Location = new System.Drawing.Point(161, 190);
            this.txt_certPassword.Name = "txt_certPassword";
            this.txt_certPassword.Size = new System.Drawing.Size(93, 22);
            this.txt_certPassword.TabIndex = 9;
            this.txt_certPassword.TabStop = false;
            // 
            // btn_makeCerttoPFX
            // 
            this.btn_makeCerttoPFX.Location = new System.Drawing.Point(17, 188);
            this.btn_makeCerttoPFX.Name = "btn_makeCerttoPFX";
            this.btn_makeCerttoPFX.Size = new System.Drawing.Size(93, 23);
            this.btn_makeCerttoPFX.TabIndex = 8;
            this.btn_makeCerttoPFX.TabStop = false;
            this.btn_makeCerttoPFX.Text = "匯出 PFX";
            this.btn_makeCerttoPFX.UseVisualStyleBackColor = true;
            this.btn_makeCerttoPFX.Click += new System.EventHandler(this.saveCertToPFX);
            // 
            // btn_makeCerttoStore
            // 
            this.btn_makeCerttoStore.Location = new System.Drawing.Point(17, 149);
            this.btn_makeCerttoStore.Name = "btn_makeCerttoStore";
            this.btn_makeCerttoStore.Size = new System.Drawing.Size(93, 23);
            this.btn_makeCerttoStore.TabIndex = 7;
            this.btn_makeCerttoStore.TabStop = false;
            this.btn_makeCerttoStore.Text = "匯出至憑證庫";
            this.btn_makeCerttoStore.UseVisualStyleBackColor = true;
            this.btn_makeCerttoStore.Click += new System.EventHandler(this.saveCertToStore);
            // 
            // rbtn_4096
            // 
            this.rbtn_4096.AutoSize = true;
            this.rbtn_4096.Location = new System.Drawing.Point(74, 106);
            this.rbtn_4096.Name = "rbtn_4096";
            this.rbtn_4096.Size = new System.Drawing.Size(74, 16);
            this.rbtn_4096.TabIndex = 6;
            this.rbtn_4096.Text = "4096 位元";
            this.rbtn_4096.UseVisualStyleBackColor = true;
            // 
            // rbtn_2048
            // 
            this.rbtn_2048.AutoSize = true;
            this.rbtn_2048.Location = new System.Drawing.Point(74, 84);
            this.rbtn_2048.Name = "rbtn_2048";
            this.rbtn_2048.Size = new System.Drawing.Size(74, 16);
            this.rbtn_2048.TabIndex = 5;
            this.rbtn_2048.Text = "2048 位元";
            this.rbtn_2048.UseVisualStyleBackColor = true;
            // 
            // rbtn_1024
            // 
            this.rbtn_1024.AutoSize = true;
            this.rbtn_1024.Checked = true;
            this.rbtn_1024.Location = new System.Drawing.Point(74, 62);
            this.rbtn_1024.Name = "rbtn_1024";
            this.rbtn_1024.Size = new System.Drawing.Size(74, 16);
            this.rbtn_1024.TabIndex = 4;
            this.rbtn_1024.TabStop = true;
            this.rbtn_1024.Text = "1024 位元";
            this.rbtn_1024.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "憑證強度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "憑證名稱";
            // 
            // txt_certName
            // 
            this.txt_certName.Location = new System.Drawing.Point(74, 25);
            this.txt_certName.Name = "txt_certName";
            this.txt_certName.Size = new System.Drawing.Size(129, 22);
            this.txt_certName.TabIndex = 0;
            this.txt_certName.TabStop = false;
            this.txt_certName.Text = "ISU_RSA_Crypto";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.btn_Decrypt);
            this.tabPage2.Controls.Add(this.btn_Encrypt);
            this.tabPage2.Controls.Add(this.btn_openFile);
            this.tabPage2.Controls.Add(this.txt_fileName);
            this.tabPage2.Controls.Add(this.txt_AESKey);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btn_readPublicKey);
            this.tabPage2.Font = new System.Drawing.Font("新細明體", 9F);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "檔案加解密";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(182, 168);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(179, 27);
            this.progressBar1.TabIndex = 8;
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Enabled = false;
            this.btn_Decrypt.Font = new System.Drawing.Font("新細明體", 9F);
            this.btn_Decrypt.Location = new System.Drawing.Point(390, 144);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(129, 72);
            this.btn_Decrypt.TabIndex = 6;
            this.btn_Decrypt.TabStop = false;
            this.btn_Decrypt.Text = "解密";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Enabled = false;
            this.btn_Encrypt.Font = new System.Drawing.Font("新細明體", 9F);
            this.btn_Encrypt.Location = new System.Drawing.Point(23, 144);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(129, 72);
            this.btn_Encrypt.TabIndex = 5;
            this.btn_Encrypt.TabStop = false;
            this.btn_Encrypt.Text = "加密";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_openFile
            // 
            this.btn_openFile.Font = new System.Drawing.Font("新細明體", 9F);
            this.btn_openFile.Location = new System.Drawing.Point(452, 64);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(75, 24);
            this.btn_openFile.TabIndex = 4;
            this.btn_openFile.TabStop = false;
            this.btn_openFile.Text = "開啟檔案";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // txt_fileName
            // 
            this.txt_fileName.Font = new System.Drawing.Font("新細明體", 9F);
            this.txt_fileName.Location = new System.Drawing.Point(19, 64);
            this.txt_fileName.Name = "txt_fileName";
            this.txt_fileName.Size = new System.Drawing.Size(415, 22);
            this.txt_fileName.TabIndex = 3;
            this.txt_fileName.TabStop = false;
            // 
            // txt_AESKey
            // 
            this.txt_AESKey.Font = new System.Drawing.Font("新細明體", 9F);
            this.txt_AESKey.Location = new System.Drawing.Point(313, 15);
            this.txt_AESKey.Name = "txt_AESKey";
            this.txt_AESKey.ReadOnly = true;
            this.txt_AESKey.Size = new System.Drawing.Size(214, 22);
            this.txt_AESKey.TabIndex = 2;
            this.txt_AESKey.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 9F);
            this.label6.Location = new System.Drawing.Point(257, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "AES密碼";
            // 
            // btn_readPublicKey
            // 
            this.btn_readPublicKey.Font = new System.Drawing.Font("新細明體", 9F);
            this.btn_readPublicKey.Location = new System.Drawing.Point(19, 14);
            this.btn_readPublicKey.Name = "btn_readPublicKey";
            this.btn_readPublicKey.Size = new System.Drawing.Size(112, 24);
            this.btn_readPublicKey.TabIndex = 0;
            this.btn_readPublicKey.TabStop = false;
            this.btn_readPublicKey.Text = "讀取公開金鑰";
            this.btn_readPublicKey.UseVisualStyleBackColor = true;
            this.btn_readPublicKey.Click += new System.EventHandler(this.btn_readPublicKey_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_compareResult);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.progressBar2);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txt_SHA_2);
            this.tabPage3.Controls.Add(this.txt_decFile);
            this.tabPage3.Controls.Add(this.txt_SHA_1);
            this.tabPage3.Controls.Add(this.txt_sourceFile);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(542, 272);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "檔案驗證";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_compareResult
            // 
            this.txt_compareResult.Location = new System.Drawing.Point(83, 224);
            this.txt_compareResult.Name = "txt_compareResult";
            this.txt_compareResult.ReadOnly = true;
            this.txt_compareResult.Size = new System.Drawing.Size(100, 22);
            this.txt_compareResult.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "比對結果";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(333, 224);
            this.progressBar2.MarqueeAnimationSpeed = 10;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(148, 22);
            this.progressBar2.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "解密檔案";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "來源檔案";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "SHA-256";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "SHA-256";
            // 
            // txt_SHA_2
            // 
            this.txt_SHA_2.Location = new System.Drawing.Point(83, 171);
            this.txt_SHA_2.Name = "txt_SHA_2";
            this.txt_SHA_2.ReadOnly = true;
            this.txt_SHA_2.Size = new System.Drawing.Size(398, 22);
            this.txt_SHA_2.TabIndex = 3;
            this.txt_SHA_2.TabStop = false;
            // 
            // txt_decFile
            // 
            this.txt_decFile.AllowDrop = true;
            this.txt_decFile.Location = new System.Drawing.Point(83, 131);
            this.txt_decFile.Name = "txt_decFile";
            this.txt_decFile.Size = new System.Drawing.Size(398, 22);
            this.txt_decFile.TabIndex = 2;
            this.txt_decFile.TabStop = false;
            this.txt_decFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.txt_decFile_DragDrop);
            this.txt_decFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_sourceFile_DragEnter);
            // 
            // txt_SHA_1
            // 
            this.txt_SHA_1.Location = new System.Drawing.Point(83, 73);
            this.txt_SHA_1.Name = "txt_SHA_1";
            this.txt_SHA_1.ReadOnly = true;
            this.txt_SHA_1.Size = new System.Drawing.Size(398, 22);
            this.txt_SHA_1.TabIndex = 1;
            this.txt_SHA_1.TabStop = false;
            // 
            // txt_sourceFile
            // 
            this.txt_sourceFile.AllowDrop = true;
            this.txt_sourceFile.Location = new System.Drawing.Point(83, 33);
            this.txt_sourceFile.Name = "txt_sourceFile";
            this.txt_sourceFile.Size = new System.Drawing.Size(398, 22);
            this.txt_sourceFile.TabIndex = 0;
            this.txt_sourceFile.TabStop = false;
            this.txt_sourceFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.txt_sourceFile_DragDrop);
            this.txt_sourceFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_sourceFile_DragEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "私密金鑰";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "公開金鑰";
            // 
            // txt_certPrivateKey
            // 
            this.txt_certPrivateKey.Location = new System.Drawing.Point(99, 349);
            this.txt_certPrivateKey.Name = "txt_certPrivateKey";
            this.txt_certPrivateKey.PasswordChar = '*';
            this.txt_certPrivateKey.ReadOnly = true;
            this.txt_certPrivateKey.Size = new System.Drawing.Size(436, 22);
            this.txt_certPrivateKey.TabIndex = 5;
            this.txt_certPrivateKey.TabStop = false;
            // 
            // txt_certPublicKey
            // 
            this.txt_certPublicKey.Location = new System.Drawing.Point(99, 321);
            this.txt_certPublicKey.Name = "txt_certPublicKey";
            this.txt_certPublicKey.ReadOnly = true;
            this.txt_certPublicKey.Size = new System.Drawing.Size(436, 22);
            this.txt_certPublicKey.TabIndex = 4;
            this.txt_certPublicKey.TabStop = false;
            // 
            // savePFXDialog
            // 
            this.savePFXDialog.DefaultExt = "pfx";
            this.savePFXDialog.Filter = "PFX 憑證|*.pfx";
            // 
            // openCerDialog
            // 
            this.openCerDialog.Filter = "公開金鑰|*.cer";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "所有檔案|*.*";
            // 
            // sha256Hash
            // 
            this.sha256Hash.WorkerReportsProgress = true;
            this.sha256Hash.DoWork += new System.ComponentModel.DoWorkEventHandler(this.sha256Hash_DoWork);
            this.sha256Hash.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.sha256Hash_ProgressChanged);
            this.sha256Hash.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.sha256Hash_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 387);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_certPublicKey);
            this.Controls.Add(this.txt_certPrivateKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_certs;
        private System.Windows.Forms.RadioButton rbtn_4096;
        private System.Windows.Forms.RadioButton rbtn_2048;
        private System.Windows.Forms.RadioButton rbtn_1024;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_certName;
        private System.Windows.Forms.Button btn_certsRefreash;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_certPassword;
        private System.Windows.Forms.Button btn_makeCerttoPFX;
        private System.Windows.Forms.Button btn_makeCerttoStore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_certPrivateKey;
        private System.Windows.Forms.TextBox txt_certPublicKey;
        private System.Windows.Forms.SaveFileDialog savePFXDialog;
        private System.Windows.Forms.Button btn_makeCert;
        private System.Windows.Forms.Button btn_readPublicKey;
        private System.Windows.Forms.OpenFileDialog openCerDialog;
        private System.Windows.Forms.TextBox txt_AESKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.TextBox txt_fileName;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_SHA_2;
        private System.Windows.Forms.TextBox txt_decFile;
        private System.Windows.Forms.TextBox txt_SHA_1;
        private System.Windows.Forms.TextBox txt_sourceFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_compareResult;
        private System.ComponentModel.BackgroundWorker sha256Hash;
    }
}

