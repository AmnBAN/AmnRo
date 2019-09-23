namespace AmnRo
{
    partial class FormEncryption
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
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.openFileDialogPlainFile = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonEncryption = new System.Windows.Forms.Button();
            this.textBoxSavePath = new System.Windows.Forms.TextBox();
            this.buttonSavePath = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.labelReciverKey = new System.Windows.Forms.Label();
            this.openFileDialogReciverPubKey = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(12, 19);
            this.buttonSelectFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(87, 28);
            this.buttonSelectFile.TabIndex = 0;
            this.buttonSelectFile.Text = "انتخاب فایل";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.ButtonSelectFile_Click);
            // 
            // openFileDialogPlainFile
            // 
            this.openFileDialogPlainFile.FileName = "openFileDialog1";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(105, 22);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(487, 23);
            this.textBoxFilePath.TabIndex = 1;
            // 
            // buttonEncryption
            // 
            this.buttonEncryption.ForeColor = System.Drawing.Color.Green;
            this.buttonEncryption.Location = new System.Drawing.Point(234, 128);
            this.buttonEncryption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEncryption.Name = "buttonEncryption";
            this.buttonEncryption.Size = new System.Drawing.Size(139, 48);
            this.buttonEncryption.TabIndex = 2;
            this.buttonEncryption.Text = "رمزگذاری";
            this.buttonEncryption.UseVisualStyleBackColor = true;
            this.buttonEncryption.Click += new System.EventHandler(this.ButtonEncryption_Click);
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.Location = new System.Drawing.Point(105, 88);
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.Size = new System.Drawing.Size(487, 23);
            this.textBoxSavePath.TabIndex = 4;
            this.textBoxSavePath.Text = "پوشه فعلی";
            // 
            // buttonSavePath
            // 
            this.buttonSavePath.Location = new System.Drawing.Point(12, 85);
            this.buttonSavePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSavePath.Name = "buttonSavePath";
            this.buttonSavePath.Size = new System.Drawing.Size(87, 28);
            this.buttonSavePath.TabIndex = 3;
            this.buttonSavePath.Text = "محل ذخیره";
            this.buttonSavePath.UseVisualStyleBackColor = true;
            this.buttonSavePath.Click += new System.EventHandler(this.ButtonSavePath_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Amn files (*.amn)|*.amn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "انتخاب کلید عمومی گیرنده";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelReciverKey
            // 
            this.labelReciverKey.AutoSize = true;
            this.labelReciverKey.Location = new System.Drawing.Point(192, 57);
            this.labelReciverKey.Name = "labelReciverKey";
            this.labelReciverKey.Size = new System.Drawing.Size(218, 16);
            this.labelReciverKey.TabIndex = 17;
            this.labelReciverKey.Text = "کلید عمومی گیرنده هنوز انتخاب نشده";
            // 
            // openFileDialogReciverPubKey
            // 
            this.openFileDialogReciverPubKey.FileName = "openFileDialog2";
            this.openFileDialogReciverPubKey.Filter = "Public Key files (*.asc)|*.asc";
            // 
            // FormEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 185);
            this.Controls.Add(this.labelReciverKey);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSavePath);
            this.Controls.Add(this.buttonSavePath);
            this.Controls.Add(this.buttonEncryption);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonSelectFile);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEncryption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "رمزگذاری";
            this.Load += new System.EventHandler(this.FormEncryption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogPlainFile;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonEncryption;
        private System.Windows.Forms.TextBox textBoxSavePath;
        private System.Windows.Forms.Button buttonSavePath;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelReciverKey;
        private System.Windows.Forms.OpenFileDialog openFileDialogReciverPubKey;
    }
}