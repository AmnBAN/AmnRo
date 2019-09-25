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
            this.btnKeyGen = new System.Windows.Forms.Button();
            this.btnEncryption = new System.Windows.Forms.Button();
            this.btnDecryption = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKeyGen
            // 
            this.btnKeyGen.Location = new System.Drawing.Point(18, 80);
            this.btnKeyGen.Margin = new System.Windows.Forms.Padding(4);
            this.btnKeyGen.Name = "btnKeyGen";
            this.btnKeyGen.Size = new System.Drawing.Size(164, 85);
            this.btnKeyGen.TabIndex = 2;
            this.btnKeyGen.Text = "تولید کلید";
            this.btnKeyGen.UseVisualStyleBackColor = true;
            this.btnKeyGen.Click += new System.EventHandler(this.BtnKeyGen_Click);
            // 
            // btnEncryption
            // 
            this.btnEncryption.ForeColor = System.Drawing.Color.Green;
            this.btnEncryption.Location = new System.Drawing.Point(190, 80);
            this.btnEncryption.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(164, 85);
            this.btnEncryption.TabIndex = 1;
            this.btnEncryption.Text = "رمزگذاری";
            this.btnEncryption.UseVisualStyleBackColor = true;
            this.btnEncryption.Click += new System.EventHandler(this.BtnEncryption_Click);
            // 
            // btnDecryption
            // 
            this.btnDecryption.ForeColor = System.Drawing.Color.Red;
            this.btnDecryption.Location = new System.Drawing.Point(363, 80);
            this.btnDecryption.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecryption.Name = "btnDecryption";
            this.btnDecryption.Size = new System.Drawing.Size(164, 85);
            this.btnDecryption.TabIndex = 0;
            this.btnDecryption.Text = "رمزگشایی";
            this.btnDecryption.UseVisualStyleBackColor = true;
            this.btnDecryption.Click += new System.EventHandler(this.BtnDecryption_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 178);
            this.Controls.Add(this.btnDecryption);
            this.Controls.Add(this.btnEncryption);
            this.Controls.Add(this.btnKeyGen);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: AmnRo ::..";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKeyGen;
        private System.Windows.Forms.Button btnEncryption;
        private System.Windows.Forms.Button btnDecryption;
    }
}

