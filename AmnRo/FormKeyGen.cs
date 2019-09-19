using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AmnRo
{
    public partial class FormKeyGen : Form
    {
        public FormKeyGen()
        {
            InitializeComponent();
        }
        private void FormKeyGen_Load(object sender, EventArgs e)
        {
            comboBoxKeyLength.SelectedIndex = 2;
        }
        private void BtnKeyGen_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(int.Parse(comboBoxKeyLength.Text));
            richTextBoxPublicKey.Text = rsa.ToXmlString(false);
            richTextBoxPRivateKey.Text = rsa.ToXmlString(true);
            buttonSavePrivateKey.Enabled = buttonSavePublicKey.Enabled = true;
        }

        private void ButtonSavePublicKey_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.RestoreDirectory = true;
            save.InitialDirectory = Directory.GetCurrentDirectory();
            save.Filter = "Text Files (*.txt)|*.txt|All Files |*.*";
            save.FileName = "PublicKey";
            if ( save.ShowDialog() == DialogResult.OK)
            {
                richTextBoxPublicKey.SaveFile(save.FileName,RichTextBoxStreamType.PlainText);
                MessageBox.Show("کلید عمومی با موفقیت ذخیره شد", "OK",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void ButtonSavePrivateKey_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.RestoreDirectory = true;
            save.InitialDirectory = Directory.GetCurrentDirectory();
            save.Filter = "Text Files (*.txt)|*.txt|All Files |*.*";
            save.FileName = "PrivateKey";
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTextBoxPRivateKey.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("کلید خصوصی با موفقیت ذخیره شد\nلطفا در نگهداری آن کوشا باشید","OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
