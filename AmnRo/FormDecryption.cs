using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmnRo.PGP;

namespace AmnRo
{
    public partial class FormDecryption : Form
    {
        public FormDecryption()
        {
            InitializeComponent();
        }

        private void ButtonSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogEncryptFile.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialogEncryptFile.FileName;
            }
        }

        private void ButtonSavePath_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSavePath.Text = saveFileDialog1.FileName;
            }
        }

        private void ButtonSelectPrivateKey_Click(object sender, EventArgs e)
        {
            if (openFileDialogPrivateKey.ShowDialog() == DialogResult.OK)
            {
                labelReciverKey.Text = openFileDialogPrivateKey.SafeFileName;
            }
        }

        private void ButtonDecryption_Click(object sender, EventArgs e)
        {
            Decrypter decrypter = new PGP.Decrypter();
            decrypter.Decrypt(textBoxFilePath.Text, openFileDialogPrivateKey.FileName, textBoxPassword.Text, textBoxSavePath.Text);
            MessageBox.Show("رمزگشایی با موفقت انجام شد", "انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
