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
        bool _English;
        public FormDecryption(bool English)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.DeepOrange400, Primary.DeepOrange500,
                Primary.DeepOrange500, Accent.Orange200,
                TextShade.WHITE
            );
            Convert_Lang(English);
            _English = English;
        }
        private void Convert_Lang(bool English)
        {
            if (English == true)
            {
                buttonSelectFile.Text = "Select File";
                buttonSelectPrivateKey.Text = "Select Private Key";
                labelReciverKey.Text = "Private Key Didn't Get Selected Yet";
                label1.Text = "Password";
            }
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
                if (_English == true)
                    MessageBox.Show("Please Select A File To Decrypt", "File Select", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                else
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
                if (_English == true)
                    MessageBox.Show("Please Select A File To Decrypt", "File Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("لطفا فایل مورد نظر برای رمزگشایی را انتخاب کنید", "انتخاب فایل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSelectFile.Focus();
                return;
            }
            if (string.IsNullOrEmpty(openFileDialogPrivateKey.FileName))
            {
                if (_English == true)
                    MessageBox.Show("Please Select Private Key File To Decrypt", "File Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("لطفا کلید خصوصی خود را برای رمزگشایی انتخاب کنید", "انتخاب فایل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSelectPrivateKey.Focus();
                return;
            }
            if (labelReciverKey.Text.Equals("کلید خصوصی هنوز انتخاب نشده") || labelReciverKey.Text.Equals("Private Key Didn't Selected Yet"))
            {
                if (_English == true)
                    MessageBox.Show("Private Key ", "File Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("کلید خصوصی انتخاب نشده است", "انتخاب فایل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSelectFile.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                if (_English == true)
                    MessageBox.Show("Please Enter The Password", "File Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("لطفا کلمه عبور را وارد کنید", "انتخاب فایل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Focus();
                return;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Decrypter decrypter = new PGP.Decrypter();
                try
                {
                    decrypter.Decrypt(textBoxFilePath.Text, openFileDialogPrivateKey.FileName, textBoxPassword.Text, saveFileDialog1.FileName);
                }
                catch
                {
                    if(_English == true)
                        MessageBox.Show("Password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("کلمه عبور اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_English == true)
                    MessageBox.Show("Decryption Finished Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("رمزگشایی با موفقت انجام شد", "انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TextBoxFilePath_TextChanged(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = createNewFilter(textBoxFilePath.Text);
        }
        private static string createNewFilter(string fileName)
        {
            if (fileName.Contains("."))
            {
                string prefix = "Amn File(*";
                string from0ToAmn = fileName.Substring(0, fileName.LastIndexOf("."));
                if (from0ToAmn.Contains("."))
                {
                    string format = from0ToAmn.Substring(from0ToAmn.LastIndexOf("."));
                    string filter = format + ")| *" + format;
                    return prefix + filter;
                }
            }
                return "Amn File(*.*)| *.*";

        }
        private void OpenFileDialogEncryptFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void LabelReciverKey_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxFilePath_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void TextBoxFilePath_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            textBoxFilePath.Text = fileNames[0];
        }

        private void FormDecryption_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
