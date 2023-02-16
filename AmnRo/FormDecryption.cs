using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        public FormDecryption(bool English , string filePath = "")
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


            if (filePath.EndsWith(".amn"))
            {
                textBoxFilePath.Text = filePath;
                saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(filePath);
            }else if (filePath.EndsWith(".priv"))
            {
                labelReciverKey.Text = Path.GetFileName(filePath);
                openFileDialogPrivateKey.FileName = filePath;
            }

        }
        private void Convert_Lang(bool English)
        {
            if (English == true)
            {
                Text = "Decryption";
                buttonSelectFile.Text = "Select File";
                buttonSelectPrivateKey.Text = "Select Private Key";
                labelReciverKey.Text = "Private Key Didn't Get Selected Yet";
                label1.Text = "Password";
            }
        }

        private void ButtonSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialogEncryptFile.FileName = "";
            if (openFileDialogEncryptFile.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialogEncryptFile.FileName;
                saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(openFileDialogEncryptFile.SafeFileName);
            }
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
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                if (_English == true)
                    MessageBox.Show("Please Enter The Password", "File Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("لطفا کلمه عبور را وارد کنید", "انتخاب فایل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Focus();
                return;
            }

            
            Decrypter decrypter = new PGP.Decrypter();

            void ShowErrorBox()
            {
                if (_English == true)
                    MessageBox.Show("Password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("کلمه عبور اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            string ext;
            string ver;
            try
            {
                var data = decrypter.DecryptFile(textBoxFilePath.Text, openFileDialogPrivateKey.FileName, textBoxPassword.Text, "");
                ext = data.Item1;
                ver = data.Item2;
            }
            catch (Exception exception)
            {
                ShowErrorBox();
                return;
            }
            
            if (ext != "")
                saveFileDialog1.Filter = FilterFormat(ext);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                try
                {
                    decrypter.DecryptFile(textBoxFilePath.Text, openFileDialogPrivateKey.FileName, textBoxPassword.Text, saveFileDialog1.FileName , (ver!=""));
                }
                catch(Exception exception)
                {
                    ShowErrorBox();
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
        private static string FilterFormat(string ext){
            return $"Amn File(*{ext})| *{ext}";
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
            saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(fileNames[0]);
        }

        private void FormDecryption_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void buttonSelectPrivateKey_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if(Path.GetExtension(fileNames[0])== ".priv")
            {
                labelReciverKey.Text =Path.GetFileName(fileNames[0]);
                openFileDialogPrivateKey.FileName = fileNames[0];
            }
            
        }
    }
}
