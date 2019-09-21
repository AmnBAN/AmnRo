﻿namespace AmnRo
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
            this.comboBoxKeyLength = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKeyGen = new System.Windows.Forms.Button();
            this.textBoxuserName = new System.Windows.Forms.TextBox();
            this.textBoxPass1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPass2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialogSaveKeyPath = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxSavePath = new System.Windows.Forms.TextBox();
            this.buttonChangeSavePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxKeyLength
            // 
            this.comboBoxKeyLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeyLength.Enabled = false;
            this.comboBoxKeyLength.FormattingEnabled = true;
            this.comboBoxKeyLength.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048",
            "4096"});
            this.comboBoxKeyLength.Location = new System.Drawing.Point(450, 18);
            this.comboBoxKeyLength.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKeyLength.Name = "comboBoxKeyLength";
            this.comboBoxKeyLength.Size = new System.Drawing.Size(100, 27);
            this.comboBoxKeyLength.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "طول کلید";
            // 
            // btnKeyGen
            // 
            this.btnKeyGen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyGen.Location = new System.Drawing.Point(230, 197);
            this.btnKeyGen.Name = "btnKeyGen";
            this.btnKeyGen.Size = new System.Drawing.Size(146, 57);
            this.btnKeyGen.TabIndex = 4;
            this.btnKeyGen.Text = "تولید کلید";
            this.btnKeyGen.UseVisualStyleBackColor = true;
            this.btnKeyGen.Click += new System.EventHandler(this.BtnKeyGen_Click);
            // 
            // textBoxuserName
            // 
            this.textBoxuserName.Location = new System.Drawing.Point(112, 19);
            this.textBoxuserName.MaxLength = 20;
            this.textBoxuserName.Name = "textBoxuserName";
            this.textBoxuserName.Size = new System.Drawing.Size(231, 27);
            this.textBoxuserName.TabIndex = 1;
            this.textBoxuserName.Text = "amnban";
            this.textBoxuserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPass1
            // 
            this.textBoxPass1.Location = new System.Drawing.Point(358, 60);
            this.textBoxPass1.MaxLength = 10;
            this.textBoxPass1.Name = "textBoxPass1";
            this.textBoxPass1.Size = new System.Drawing.Size(172, 27);
            this.textBoxPass1.TabIndex = 2;
            this.textBoxPass1.Text = "123";
            this.textBoxPass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPass1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "نام کاربری:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 64);
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
            this.label4.Location = new System.Drawing.Point(230, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = " تکرار کلمه عبور:";
            // 
            // textBoxPass2
            // 
            this.textBoxPass2.Location = new System.Drawing.Point(15, 60);
            this.textBoxPass2.MaxLength = 10;
            this.textBoxPass2.Name = "textBoxPass2";
            this.textBoxPass2.Size = new System.Drawing.Size(204, 27);
            this.textBoxPass2.TabIndex = 3;
            this.textBoxPass2.Text = "123";
            this.textBoxPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPass2.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "محل ذخیره کلیدها:";
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.Location = new System.Drawing.Point(3, 144);
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.Size = new System.Drawing.Size(611, 27);
            this.textBoxSavePath.TabIndex = 15;
            // 
            // buttonChangeSavePath
            // 
            this.buttonChangeSavePath.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeSavePath.Location = new System.Drawing.Point(307, 111);
            this.buttonChangeSavePath.Name = "buttonChangeSavePath";
            this.buttonChangeSavePath.Size = new System.Drawing.Size(164, 27);
            this.buttonChangeSavePath.TabIndex = 16;
            this.buttonChangeSavePath.Text = "تغییر محل ذخیره سازی";
            this.buttonChangeSavePath.UseVisualStyleBackColor = true;
            this.buttonChangeSavePath.Click += new System.EventHandler(this.ButtonChangeSavePath_Click);
            // 
            // FormKeyGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 266);
            this.Controls.Add(this.buttonChangeSavePath);
            this.Controls.Add(this.textBoxSavePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPass2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPass1);
            this.Controls.Add(this.textBoxuserName);
            this.Controls.Add(this.btnKeyGen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKeyLength);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKeyGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تولید کلید";
            this.Load += new System.EventHandler(this.FormKeyGen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKeyLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKeyGen;
        private System.Windows.Forms.TextBox textBoxuserName;
        private System.Windows.Forms.TextBox textBoxPass1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPass2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSaveKeyPath;
        private System.Windows.Forms.TextBox textBoxSavePath;
        private System.Windows.Forms.Button buttonChangeSavePath;
    }
}