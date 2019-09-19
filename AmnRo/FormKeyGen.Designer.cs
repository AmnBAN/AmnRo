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
            this.comboBoxKeyLength = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKeyGen = new System.Windows.Forms.Button();
            this.richTextBoxPRivateKey = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxPublicKey = new System.Windows.Forms.RichTextBox();
            this.buttonSavePublicKey = new System.Windows.Forms.Button();
            this.buttonSavePrivateKey = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxKeyLength
            // 
            this.comboBoxKeyLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeyLength.FormattingEnabled = true;
            this.comboBoxKeyLength.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048",
            "4096"});
            this.comboBoxKeyLength.Location = new System.Drawing.Point(435, 18);
            this.comboBoxKeyLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnKeyGen.Location = new System.Drawing.Point(273, 18);
            this.btnKeyGen.Name = "btnKeyGen";
            this.btnKeyGen.Size = new System.Drawing.Size(100, 34);
            this.btnKeyGen.TabIndex = 2;
            this.btnKeyGen.Text = "تولید کلید";
            this.btnKeyGen.UseVisualStyleBackColor = true;
            this.btnKeyGen.Click += new System.EventHandler(this.BtnKeyGen_Click);
            // 
            // richTextBoxPRivateKey
            // 
            this.richTextBoxPRivateKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxPRivateKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxPRivateKey.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxPRivateKey.Location = new System.Drawing.Point(3, 23);
            this.richTextBoxPRivateKey.Name = "richTextBoxPRivateKey";
            this.richTextBoxPRivateKey.ReadOnly = true;
            this.richTextBoxPRivateKey.Size = new System.Drawing.Size(294, 415);
            this.richTextBoxPRivateKey.TabIndex = 3;
            this.richTextBoxPRivateKey.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxPublicKey);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(318, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 441);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "کلید عمومی (Public Key)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxPRivateKey);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 441);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "کلید خصوصی (Private Key)";
            // 
            // richTextBoxPublicKey
            // 
            this.richTextBoxPublicKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxPublicKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxPublicKey.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxPublicKey.Location = new System.Drawing.Point(3, 23);
            this.richTextBoxPublicKey.Name = "richTextBoxPublicKey";
            this.richTextBoxPublicKey.ReadOnly = true;
            this.richTextBoxPublicKey.Size = new System.Drawing.Size(294, 415);
            this.richTextBoxPublicKey.TabIndex = 4;
            this.richTextBoxPublicKey.Text = "";
            // 
            // buttonSavePublicKey
            // 
            this.buttonSavePublicKey.Enabled = false;
            this.buttonSavePublicKey.ForeColor = System.Drawing.Color.Blue;
            this.buttonSavePublicKey.Location = new System.Drawing.Point(321, 515);
            this.buttonSavePublicKey.Name = "buttonSavePublicKey";
            this.buttonSavePublicKey.Size = new System.Drawing.Size(294, 34);
            this.buttonSavePublicKey.TabIndex = 6;
            this.buttonSavePublicKey.Text = "ذخیره کلید عمومی";
            this.buttonSavePublicKey.UseVisualStyleBackColor = true;
            this.buttonSavePublicKey.Click += new System.EventHandler(this.ButtonSavePublicKey_Click);
            // 
            // buttonSavePrivateKey
            // 
            this.buttonSavePrivateKey.Enabled = false;
            this.buttonSavePrivateKey.ForeColor = System.Drawing.Color.Red;
            this.buttonSavePrivateKey.Location = new System.Drawing.Point(15, 516);
            this.buttonSavePrivateKey.Name = "buttonSavePrivateKey";
            this.buttonSavePrivateKey.Size = new System.Drawing.Size(294, 34);
            this.buttonSavePrivateKey.TabIndex = 7;
            this.buttonSavePrivateKey.Text = "ذخیره کلید خصوصی";
            this.buttonSavePrivateKey.UseVisualStyleBackColor = true;
            this.buttonSavePrivateKey.Click += new System.EventHandler(this.ButtonSavePrivateKey_Click);
            // 
            // FormKeyGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 561);
            this.Controls.Add(this.buttonSavePrivateKey);
            this.Controls.Add(this.buttonSavePublicKey);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKeyGen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKeyLength);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormKeyGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تولید کلید";
            this.Load += new System.EventHandler(this.FormKeyGen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKeyLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKeyGen;
        private System.Windows.Forms.RichTextBox richTextBoxPRivateKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxPublicKey;
        private System.Windows.Forms.Button buttonSavePublicKey;
        private System.Windows.Forms.Button buttonSavePrivateKey;
    }
}