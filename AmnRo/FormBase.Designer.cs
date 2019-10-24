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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDecryption
            // 
            this.btnDecryption.BackgroundImage = global::AmnRo.Properties.Resources.dec4;
            this.btnDecryption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecryption.ForeColor = System.Drawing.Color.Red;
            this.btnDecryption.Location = new System.Drawing.Point(314, 80);
            this.btnDecryption.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecryption.Name = "btnDecryption";
            this.btnDecryption.Size = new System.Drawing.Size(110, 85);
            this.btnDecryption.TabIndex = 0;
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
            this.btnKeyGen.Location = new System.Drawing.Point(36, 80);
            this.btnKeyGen.Margin = new System.Windows.Forms.Padding(4);
            this.btnKeyGen.Name = "btnKeyGen";
            this.btnKeyGen.Size = new System.Drawing.Size(109, 85);
            this.btnKeyGen.TabIndex = 2;
            this.btnKeyGen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKeyGen.UseVisualStyleBackColor = true;
            this.btnKeyGen.Click += new System.EventHandler(this.BtnKeyGen_Click);
            this.btnKeyGen.Enter += new System.EventHandler(this.BtnKeyGen_Enter);
            this.btnKeyGen.MouseLeave += new System.EventHandler(this.BtnKeyGen_MouseLeave);
            this.btnKeyGen.MouseHover += new System.EventHandler(this.BtnKeyGen_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 204);
            this.Controls.Add(this.label1);
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBase_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKeyGen;
        private System.Windows.Forms.Button btnEncryption;
        private System.Windows.Forms.Button btnDecryption;
        private System.Windows.Forms.Label label1;
    }
}

