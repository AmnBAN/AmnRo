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
            textBoxSavePath.Text= saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
        }
        private void ButtonSelectFile_Click(object sender, EventArgs e)
        {
            if(openFileDialogPlainFile.ShowDialog()==DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialogPlainFile.FileName;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialogReciverPubKey.ShowDialog() == DialogResult.OK)
            {
                labelReciverKey.Text = openFileDialogReciverPubKey.SafeFileName;
            }
        }
        private void ButtonSavePath_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSavePath.Text = saveFileDialog1.FileName;
            }
        }

        private void ButtonEncryption_Click(object sender, EventArgs e)
        {
            #region checkPath
            if(textBoxFilePath.Text=="")
            {
                MessageBox.Show("لطفا فایل مورد نظر برای رمزکذاری را انتخاب کنبد", "انتخاب فایل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSelectFile.Focus();
                return;
            }
            if (!File.Exists(textBoxFilePath.Text) )
            {
                MessageBox.Show("فایل انتخاب شده وجود ندارد یا قابل دسترسی نیست", "فایل وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSelectFile.Focus();
                return;
            }
            #endregion
            EncryptionKeys encryptionKeys = new EncryptionKeys(openFileDialogReciverPubKey.FileName);
            Encrypter encrypter = new Encrypter(encryptionKeys);
            using (Stream outputStream = File.Create(textBoxSavePath.Text))
            {
                encrypter.Encrypt(outputStream, new FileInfo(openFileDialogPlainFile.FileName));
            }
            MessageBox.Show("رمزگذاری با موفقت انجام شد", "انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
