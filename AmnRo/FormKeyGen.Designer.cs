namespace AmnRo
{
    partial class FormKeyGen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKeyGen));
            this.comboBoxKeyLength = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKeyGen = new System.Windows.Forms.Button();
            this.textBoxKeyName = new System.Windows.Forms.TextBox();
            this.textBoxPass1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPass2 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogSaveKeyPath = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelChangePath = new System.Windows.Forms.Label();
            this.changePathButton = new System.Windows.Forms.Button();
            this.textBoxKeyPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogChangeKeyPath = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxKeyLength
            // 
            this.comboBoxKeyLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeyLength.FormattingEnabled = true;
            this.comboBoxKeyLength.Items.AddRange(new object[] {
            "1024",
            "2048",
            "4096"});
            this.comboBoxKeyLength.Location = new System.Drawing.Point(463, 70);
            this.comboBoxKeyLength.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKeyLength.Name = "comboBoxKeyLength";
            this.comboBoxKeyLength.Size = new System.Drawing.Size(113, 27);
            this.comboBoxKeyLength.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(578, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "طول کلید";
            // 
            // btnKeyGen
            // 
            this.btnKeyGen.BackColor = System.Drawing.SystemColors.Control;
            this.btnKeyGen.BackgroundImage = global::AmnRo.Properties.Resources.keygen;
            this.btnKeyGen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKeyGen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyGen.Location = new System.Drawing.Point(297, 226);
            this.btnKeyGen.Name = "btnKeyGen";
            this.btnKeyGen.Size = new System.Drawing.Size(66, 57);
            this.btnKeyGen.TabIndex = 4;
            this.btnKeyGen.UseVisualStyleBackColor = false;
            this.btnKeyGen.Click += new System.EventHandler(this.BtnKeyGen_Click);
            // 
            // textBoxKeyName
            // 
            this.textBoxKeyName.Location = new System.Drawing.Point(27, 71);
            this.textBoxKeyName.MaxLength = 30;
            this.textBoxKeyName.Name = "textBoxKeyName";
            this.textBoxKeyName.Size = new System.Drawing.Size(317, 27);
            this.textBoxKeyName.TabIndex = 1;
            this.textBoxKeyName.Text = "myKey";
            this.textBoxKeyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxKeyName.TextChanged += new System.EventHandler(this.TextBoxKeyName_TextChanged);
            // 
            // textBoxPass1
            // 
            this.textBoxPass1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass1.Location = new System.Drawing.Point(363, 114);
            this.textBoxPass1.MaxLength = 26;
            this.textBoxPass1.Name = "textBoxPass1";
            this.textBoxPass1.Size = new System.Drawing.Size(201, 21);
            this.textBoxPass1.TabIndex = 2;
            this.textBoxPass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPass1.UseSystemPasswordChar = true;
            this.textBoxPass1.TextChanged += new System.EventHandler(this.TextBoxPass1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(351, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "نام کلید:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(571, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "کلمه عبور:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(235, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = " تکرار کلمه عبور:";
            // 
            // textBoxPass2
            // 
            this.textBoxPass2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass2.Location = new System.Drawing.Point(27, 114);
            this.textBoxPass2.MaxLength = 26;
            this.textBoxPass2.Name = "textBoxPass2";
            this.textBoxPass2.Size = new System.Drawing.Size(204, 21);
            this.textBoxPass2.TabIndex = 3;
            this.textBoxPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPass2.UseSystemPasswordChar = true;
            this.textBoxPass2.TextChanged += new System.EventHandler(this.TextBoxPass2_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // labelChangePath
            // 
            this.labelChangePath.AutoSize = true;
            this.labelChangePath.Location = new System.Drawing.Point(494, 160);
            this.labelChangePath.Name = "labelChangePath";
            this.labelChangePath.Size = new System.Drawing.Size(145, 19);
            this.labelChangePath.TabIndex = 14;
            this.labelChangePath.Text = ":محل ذخیره کلید ها";
            // 
            // changePathButton
            // 
            this.changePathButton.Location = new System.Drawing.Point(270, 156);
            this.changePathButton.Name = "changePathButton";
            this.changePathButton.Size = new System.Drawing.Size(218, 27);
            this.changePathButton.TabIndex = 15;
            this.changePathButton.Text = "تغییر محل ذخیره سازی ";
            this.changePathButton.UseVisualStyleBackColor = true;
            this.changePathButton.Click += new System.EventHandler(this.ChangePathButton_Click);
            // 
            // textBoxKeyPath
            // 
            this.textBoxKeyPath.Location = new System.Drawing.Point(27, 191);
            this.textBoxKeyPath.Name = "textBoxKeyPath";
            this.textBoxKeyPath.Size = new System.Drawing.Size(612, 27);
            this.textBoxKeyPath.TabIndex = 16;
            // 
            // FormKeyGen
            // 
            this.AcceptButton = this.btnKeyGen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 295);
            this.Controls.Add(this.textBoxKeyPath);
            this.Controls.Add(this.changePathButton);
            this.Controls.Add(this.labelChangePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPass2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPass1);
            this.Controls.Add(this.textBoxKeyName);
            this.Controls.Add(this.btnKeyGen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKeyLength);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormKeyGen";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تولید کلید";
            this.Load += new System.EventHandler(this.FormKeyGen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyGen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKeyLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKeyGen;
        private System.Windows.Forms.TextBox textBoxKeyName;
        private System.Windows.Forms.TextBox textBoxPass1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPass2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSaveKeyPath;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button changePathButton;
        private System.Windows.Forms.Label labelChangePath;
        private System.Windows.Forms.TextBox textBoxKeyPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogChangeKeyPath;
    }
}