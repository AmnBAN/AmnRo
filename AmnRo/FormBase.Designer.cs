namespace AmnRo
{
    partial class FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.btnDecryption = new System.Windows.Forms.Button();
            this.btnEncryption = new System.Windows.Forms.Button();
            this.btnKeyGen = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.ChangeLanguageIR = new System.Windows.Forms.PictureBox();
            this.ChangeLangageEn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeLanguageIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeLangageEn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDecryption
            // 
            this.btnDecryption.BackgroundImage = global::AmnRo.Properties.Resources.dec4;
            this.btnDecryption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecryption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecryption.ForeColor = System.Drawing.Color.Red;
            this.btnDecryption.Location = new System.Drawing.Point(314, 80);
            this.btnDecryption.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecryption.Name = "btnDecryption";
            this.btnDecryption.Size = new System.Drawing.Size(110, 85);
            this.btnDecryption.TabIndex = 2;
            this.btnDecryption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDecryption.UseVisualStyleBackColor = true;
            this.btnDecryption.Click += new System.EventHandler(this.BtnDecryption_Click);
            this.btnDecryption.Enter += new System.EventHandler(this.BtnDecryption_Enter);
            this.btnDecryption.MouseLeave += new System.EventHandler(this.BtnDecryption_MouseLeave);
            this.btnDecryption.MouseHover += new System.EventHandler(this.BtnDecryption_MouseHover);
            // 
            // btnEncryption
            // 
            this.btnEncryption.BackgroundImage = global::AmnRo.Properties.Resources.enc3;
            this.btnEncryption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEncryption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncryption.ForeColor = System.Drawing.Color.Green;
            this.btnEncryption.Location = new System.Drawing.Point(177, 80);
            this.btnEncryption.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(108, 85);
            this.btnEncryption.TabIndex = 1;
            this.btnEncryption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEncryption.UseVisualStyleBackColor = true;
            this.btnEncryption.Click += new System.EventHandler(this.BtnEncryption_Click);
            this.btnEncryption.Enter += new System.EventHandler(this.BtnEncryption_Enter);
            this.btnEncryption.MouseLeave += new System.EventHandler(this.BtnEncryption_MouseLeave);
            this.btnEncryption.MouseHover += new System.EventHandler(this.BtnEncryption_MouseHover);
            // 
            // btnKeyGen
            // 
            this.btnKeyGen.BackgroundImage = global::AmnRo.Properties.Resources.keygen;
            this.btnKeyGen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKeyGen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeyGen.Location = new System.Drawing.Point(36, 80);
            this.btnKeyGen.Margin = new System.Windows.Forms.Padding(4);
            this.btnKeyGen.Name = "btnKeyGen";
            this.btnKeyGen.Size = new System.Drawing.Size(109, 85);
            this.btnKeyGen.TabIndex = 0;
            this.btnKeyGen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKeyGen.UseVisualStyleBackColor = true;
            this.btnKeyGen.Click += new System.EventHandler(this.BtnKeyGen_Click);
            this.btnKeyGen.Enter += new System.EventHandler(this.BtnKeyGen_Enter);
            this.btnKeyGen.MouseLeave += new System.EventHandler(this.BtnKeyGen_MouseLeave);
            this.btnKeyGen.MouseHover += new System.EventHandler(this.BtnKeyGen_MouseHover);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Location = new System.Drawing.Point(187, 175);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 19);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.BackgroundImage = global::AmnRo.Properties.Resources.icons8_infographic_64;
            this.buttonAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Location = new System.Drawing.Point(426, 167);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(35, 35);
            this.buttonAbout.TabIndex = 3;
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            this.buttonAbout.Enter += new System.EventHandler(this.ButtonAbout_Enter);
            this.buttonAbout.MouseLeave += new System.EventHandler(this.ButtonAbout_MouseLeave);
            this.buttonAbout.MouseHover += new System.EventHandler(this.ButtonAbout_MouseHover);
            // 
            // ChangeLanguageIR
            // 
            this.ChangeLanguageIR.BackColor = System.Drawing.Color.Transparent;
            this.ChangeLanguageIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeLanguageIR.Image = global::AmnRo.Properties.Resources.ir_flag;
            this.ChangeLanguageIR.Location = new System.Drawing.Point(411, 25);
            this.ChangeLanguageIR.Margin = new System.Windows.Forms.Padding(0);
            this.ChangeLanguageIR.Name = "ChangeLanguageIR";
            this.ChangeLanguageIR.Size = new System.Drawing.Size(45, 38);
            this.ChangeLanguageIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChangeLanguageIR.TabIndex = 5;
            this.ChangeLanguageIR.TabStop = false;
            this.ChangeLanguageIR.Click += new System.EventHandler(this.ChangeLanguage_Click);
            this.ChangeLanguageIR.MouseLeave += new System.EventHandler(this.BtnDecryption_MouseLeave);
            this.ChangeLanguageIR.MouseHover += new System.EventHandler(this.ChangeLanguageIR_MouseHover);
            // 
            // ChangeLangageEn
            // 
            this.ChangeLangageEn.BackColor = System.Drawing.Color.Transparent;
            this.ChangeLangageEn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeLangageEn.Image = global::AmnRo.Properties.Resources.en_flag;
            this.ChangeLangageEn.Location = new System.Drawing.Point(353, 26);
            this.ChangeLangageEn.Margin = new System.Windows.Forms.Padding(0);
            this.ChangeLangageEn.Name = "ChangeLangageEn";
            this.ChangeLangageEn.Size = new System.Drawing.Size(45, 35);
            this.ChangeLangageEn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChangeLangageEn.TabIndex = 6;
            this.ChangeLangageEn.TabStop = false;
            this.ChangeLangageEn.Click += new System.EventHandler(this.ChangeLangageEn_Click);
            this.ChangeLangageEn.MouseLeave += new System.EventHandler(this.BtnDecryption_MouseLeave);
            this.ChangeLangageEn.MouseHover += new System.EventHandler(this.ChangeLangageEn_MouseHover);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 204);
            this.Controls.Add(this.ChangeLangageEn);
            this.Controls.Add(this.ChangeLanguageIR);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.btnDecryption);
            this.Controls.Add(this.btnEncryption);
            this.Controls.Add(this.btnKeyGen);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormBase";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: AmnRo ::..";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBase_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ChangeLanguageIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeLangageEn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKeyGen;
        private System.Windows.Forms.Button btnEncryption;
        private System.Windows.Forms.Button btnDecryption;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.PictureBox ChangeLanguageIR;
        private System.Windows.Forms.PictureBox ChangeLangageEn;
    }
}

