using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmnRo.PGP;
using Org.BouncyCastle;


namespace AmnRo
{
    public partial class FormEncryption : Form
    {
        public FormEncryption()
        {
            InitializeComponent();
        }
        private void FormEncryption_Load(object sender, EventArgs e)
        {
            
        }
        private void ButtonSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogPlainFile.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialogPlainFile.FileName;
            }
        }
        private void ButtonSelectPubKey_Click(object sender, EventArgs e)
        {
            if (openFileDialogReciverPubKey.ShowDialog() == DialogResult.OK)
            {
                labelReciverKey.Text = openFileDialogReciverPubKey.SafeFileName;
            }
        }

        private void ButtonEncryption_Click(object sender, EventArgs e)
        {
            #region checkPath
            if (string.IsNullOrEmpty(textBoxFilePath.Text))
            {
                MessageBox.Show("لطفا فایل مورد نظر برای رمزگذاری را انتخاب کنید", "انتخاب فایل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSelectFile.Focus();
                return;
            }
            if (!File.Exists(textBoxFilePath.Text))
            {
                MessageBox.Show("فایل انتخاب شده وجود ندارد یا قابل دسترسی نیست", "فایل وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSelectFile.Focus();
                return;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            #endregion
            EncryptionKeys encryptionKeys = new EncryptionKeys(openFileDialogReciverPubKey.FileName);
            Encrypter encrypter = new Encrypter(encryptionKeys);
            using (Stream outputStream = File.Create(saveFileDialog1.FileName))
            {
                encrypter.Encrypt(outputStream, new FileInfo(openFileDialogPlainFile.FileName));
            }
            MessageBox.Show("رمزگذاری با موفقیت انجام شد", "انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
