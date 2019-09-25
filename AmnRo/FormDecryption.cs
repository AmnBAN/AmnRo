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
using MaterialSkin;
using MaterialSkin.Controls;

namespace AmnRo
{
    public partial class FormDecryption : MaterialForm
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

        }

        private void ButtonSelectPrivateKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFilePath.Text))
            {
                MessageBox.Show("لطفا فایل مورد نظر برای رمزگشایی را انتخاب کنید", "انتخاب فایل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSelectFile.Focus();
                return;
            }
            if (openFileDialogPrivateKey.ShowDialog() == DialogResult.OK)
            {
                labelReciverKey.Text = openFileDialogPrivateKey.SafeFileName;
            }
        }

        private void ButtonDecryption_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFilePath.Text))
            {
                MessageBox.Show("لطفا فایل مورد نظر برای رمزگشایی را انتخاب کنید", "انتخاب فایل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSelectFile.Focus();
                return;
            }
            if (string.IsNullOrEmpty(openFileDialogPrivateKey.FileName))
            {
                MessageBox.Show("لطفا کلید خصوصی خود را برای رمزگذاری انتخاب کنید", "انتخاب فایل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSelectPrivateKey.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("لطفا کلمه عبور را وارد کنید", "انتخاب فایل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Focus();
                return;
            }
            Decrypter decrypter = new PGP.Decrypter();
            decrypter.Decrypt(textBoxFilePath.Text, openFileDialogPrivateKey.FileName, textBoxPassword.Text, saveFileDialog1.FileName);
            MessageBox.Show("رمزگشایی با موفقت انجام شد", "انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
