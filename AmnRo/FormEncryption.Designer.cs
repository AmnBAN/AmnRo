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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEncryption));
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.openFileDialogPlainFile = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonEncryption = new System.Windows.Forms.Button();
            this.buttonSelectPubKey = new System.Windows.Forms.Button();
            this.labelReciverKey = new System.Windows.Forms.Label();
            this.openFileDialogReciverPubKey = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.radioButtonSelectKey = new System.Windows.Forms.RadioButton();
            this.radioButtonAmnBanKey = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(12, 72);
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
            this.openFileDialogPlainFile.Filter = "All files (*.*)|*.*";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.AllowDrop = true;
            this.textBoxFilePath.Location = new System.Drawing.Point(105, 75);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(487, 23);
            this.textBoxFilePath.TabIndex = 1;
            this.textBoxFilePath.TextChanged += new System.EventHandler(this.TextBoxFilePath_TextChanged);
            this.textBoxFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBoxFilePath_DragDrop);
            this.textBoxFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxFilePath_DragEnter);
            // 
            // buttonEncryption
            // 
            this.buttonEncryption.BackgroundImage = global::AmnRo.Properties.Resources.enc3;
            this.buttonEncryption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEncryption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncryption.ForeColor = System.Drawing.Color.Green;
            this.buttonEncryption.Location = new System.Drawing.Point(283, 149);
            this.buttonEncryption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEncryption.Name = "buttonEncryption";
            this.buttonEncryption.Size = new System.Drawing.Size(64, 55);
            this.buttonEncryption.TabIndex = 2;
            this.buttonEncryption.UseVisualStyleBackColor = true;
            this.buttonEncryption.Click += new System.EventHandler(this.ButtonEncryption_Click);
            // 
            // buttonSelectPubKey
            // 
            this.buttonSelectPubKey.Location = new System.Drawing.Point(305, 108);
            this.buttonSelectPubKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSelectPubKey.Name = "buttonSelectPubKey";
            this.buttonSelectPubKey.Size = new System.Drawing.Size(174, 28);
            this.buttonSelectPubKey.TabIndex = 16;
            this.buttonSelectPubKey.Text = "انتخاب کلید عمومی گیرنده";
            this.buttonSelectPubKey.UseVisualStyleBackColor = true;
            this.buttonSelectPubKey.Click += new System.EventHandler(this.ButtonSelectPubKey_Click);
            // 
            // labelReciverKey
            // 
            this.labelReciverKey.AutoSize = true;
            this.labelReciverKey.BackColor = System.Drawing.Color.Transparent;
            this.labelReciverKey.Location = new System.Drawing.Point(70, 114);
            this.labelReciverKey.Name = "labelReciverKey";
            this.labelReciverKey.Size = new System.Drawing.Size(218, 16);
            this.labelReciverKey.TabIndex = 17;
            this.labelReciverKey.Text = "کلید عمومی گیرنده هنوز انتخاب نشده";
            this.labelReciverKey.Click += new System.EventHandler(this.LabelReciverKey_Click);
            // 
            // openFileDialogReciverPubKey
            // 
            this.openFileDialogReciverPubKey.Filter = "Public Key files (*.pubk)|*.pubk";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Amn File (*.amn)|*.amn";
            this.saveFileDialog1.Title = "محل ذخیره فایل را انتخاب کنید";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // radioButtonSelectKey
            // 
            this.radioButtonSelectKey.AutoSize = true;
            this.radioButtonSelectKey.Checked = true;
            this.radioButtonSelectKey.Location = new System.Drawing.Point(494, 110);
            this.radioButtonSelectKey.Name = "radioButtonSelectKey";
            this.radioButtonSelectKey.Size = new System.Drawing.Size(89, 20);
            this.radioButtonSelectKey.TabIndex = 19;
            this.radioButtonSelectKey.TabStop = true;
            this.radioButtonSelectKey.Text = "انتخاب کلید";
            this.radioButtonSelectKey.UseVisualStyleBackColor = true;
            // 
            // radioButtonAmnBanKey
            // 
            this.radioButtonAmnBanKey.AutoSize = true;
            this.radioButtonAmnBanKey.Location = new System.Drawing.Point(493, 141);
            this.radioButtonAmnBanKey.Name = "radioButtonAmnBanKey";
            this.radioButtonAmnBanKey.Size = new System.Drawing.Size(90, 20);
            this.radioButtonAmnBanKey.TabIndex = 20;
            this.radioButtonAmnBanKey.Text = "کلید امن‌بان";
            this.radioButtonAmnBanKey.UseVisualStyleBackColor = true;
            this.radioButtonAmnBanKey.CheckedChanged += new System.EventHandler(this.RadioButtonAmnBanKey_CheckedChanged);
            // 
            // FormEncryption
            // 
            this.AcceptButton = this.buttonEncryption;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 217);
            this.Controls.Add(this.radioButtonAmnBanKey);
            this.Controls.Add(this.radioButtonSelectKey);
            this.Controls.Add(this.labelReciverKey);
            this.Controls.Add(this.buttonSelectPubKey);
            this.Controls.Add(this.buttonEncryption);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonSelectFile);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormEncryption";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "رمزگذاری";
            this.Load += new System.EventHandler(this.FormEncryption_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEncryption_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogPlainFile;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonEncryption;
        private System.Windows.Forms.Button buttonSelectPubKey;
        private System.Windows.Forms.Label labelReciverKey;
        private System.Windows.Forms.OpenFileDialog openFileDialogReciverPubKey;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton radioButtonSelectKey;
        private System.Windows.Forms.RadioButton radioButtonAmnBanKey;
    }
}