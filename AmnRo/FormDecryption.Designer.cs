namespace AmnRo
{
    partial class FormDecryption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDecryption));
            this.labelReciverKey = new System.Windows.Forms.Label();
            this.buttonSelectPrivateKey = new System.Windows.Forms.Button();
            this.buttonDecryption = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.openFileDialogEncryptFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogPrivateKey = new System.Windows.Forms.OpenFileDialog();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelReciverKey
            // 
            this.labelReciverKey.AutoSize = true;
            this.labelReciverKey.BackColor = System.Drawing.Color.Transparent;
            this.labelReciverKey.Location = new System.Drawing.Point(189, 111);
            this.labelReciverKey.Name = "labelReciverKey";
            this.labelReciverKey.Size = new System.Drawing.Size(186, 16);
            this.labelReciverKey.TabIndex = 24;
            this.labelReciverKey.Text = "کلید خصوصی هنوز انتخاب نشده";
            this.labelReciverKey.Click += new System.EventHandler(this.LabelReciverKey_Click);
            // 
            // buttonSelectPrivateKey
            // 
            this.buttonSelectPrivateKey.AllowDrop = true;
            this.buttonSelectPrivateKey.Location = new System.Drawing.Point(9, 105);
            this.buttonSelectPrivateKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSelectPrivateKey.Name = "buttonSelectPrivateKey";
            this.buttonSelectPrivateKey.Size = new System.Drawing.Size(174, 28);
            this.buttonSelectPrivateKey.TabIndex = 23;
            this.buttonSelectPrivateKey.Text = "انتخاب کلید خصوصی";
            this.buttonSelectPrivateKey.UseVisualStyleBackColor = true;
            this.buttonSelectPrivateKey.Click += new System.EventHandler(this.ButtonSelectPrivateKey_Click);
            this.buttonSelectPrivateKey.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonSelectPrivateKey_DragDrop);
            this.buttonSelectPrivateKey.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxFilePath_DragEnter);
            // 
            // buttonDecryption
            // 
            this.buttonDecryption.BackgroundImage = global::AmnRo.Properties.Resources.dec4;
            this.buttonDecryption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDecryption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecryption.ForeColor = System.Drawing.Color.Blue;
            this.buttonDecryption.Location = new System.Drawing.Point(281, 180);
            this.buttonDecryption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDecryption.Name = "buttonDecryption";
            this.buttonDecryption.Size = new System.Drawing.Size(60, 52);
            this.buttonDecryption.TabIndex = 20;
            this.buttonDecryption.UseVisualStyleBackColor = true;
            this.buttonDecryption.Click += new System.EventHandler(this.ButtonDecryption_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.AllowDrop = true;
            this.textBoxFilePath.Location = new System.Drawing.Point(137, 76);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(452, 23);
            this.textBoxFilePath.TabIndex = 19;
            this.textBoxFilePath.TextChanged += new System.EventHandler(this.TextBoxFilePath_TextChanged);
            this.textBoxFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBoxFilePath_DragDrop);
            this.textBoxFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxFilePath_DragEnter);
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(9, 73);
            this.buttonSelectFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(122, 28);
            this.buttonSelectFile.TabIndex = 18;
            this.buttonSelectFile.Text = "انتخاب فایل";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.ButtonSelectFile_Click);
            // 
            // openFileDialogEncryptFile
            // 
            this.openFileDialogEncryptFile.FileName = "openFileDialog1";
            this.openFileDialogEncryptFile.Filter = "Amn Files (*.amn)|*.amn";
            this.openFileDialogEncryptFile.Title = "انتخاب فایل رمزشده";
            this.openFileDialogEncryptFile.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialogEncryptFile_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "All files (*.*)|*.*";
            this.saveFileDialog1.Title = "انتخاب محل ذخیره";
            // 
            // openFileDialogPrivateKey
            // 
            this.openFileDialogPrivateKey.Filter = "Private Key files (*.priv)|*.priv";
            this.openFileDialogPrivateKey.Title = "بازکردن کلید خصوصی";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(113, 142);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(476, 23);
            this.textBoxPassword.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "کلمه عبور:";
            // 
            // FormDecryption
            // 
            this.AcceptButton = this.buttonDecryption;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelReciverKey);
            this.Controls.Add(this.buttonSelectPrivateKey);
            this.Controls.Add(this.buttonDecryption);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonSelectFile);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "FormDecryption";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "رمزگشایی";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDecryption_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReciverKey;
        private System.Windows.Forms.Button buttonSelectPrivateKey;
        private System.Windows.Forms.Button buttonDecryption;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogEncryptFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialogPrivateKey;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
    }
}