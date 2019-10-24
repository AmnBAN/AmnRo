using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using AmnRo.PGP;
using MaterialSkin;
using MaterialSkin.Controls;


namespace AmnRo
{
    public partial class FormEncryption : MaterialForm
    {
        public FormEncryption()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green500,
                Primary.Green500, Accent.LightGreen200,
                TextShade.WHITE
            );
        }
        private void FormEncryption_Load(object sender, EventArgs e)
        {
            
        }
        private void ButtonSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogPlainFile.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialogPlainFile.FileName;
                saveFileDialog1.Filter = createNewFilter(textBoxFilePath.Text);

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
            if (radioButtonSelectKey.Checked)
            {
                if (string.IsNullOrEmpty(openFileDialogReciverPubKey.FileName))
                {
                    MessageBox.Show("کلید عمومی گیرنده انتخاب نشده است ", "فایل وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    buttonSelectFile.Focus();
                    return;
                }
            }

            else if (!radioButtonAmnBanKey.Checked)
            {
                MessageBox.Show("کلید عمومی گیرنده انتخاب نشده است ", "فایل وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSelectFile.Focus();
                return;
            }
            #endregion

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                EncryptionKeys encryptionKeys;

                if(radioButtonAmnBanKey.Checked)
                    encryptionKeys = new EncryptionKeys(Properties.Resources.AmnBAN_PubKey, true);
                else
                    encryptionKeys = new EncryptionKeys(openFileDialogReciverPubKey.FileName);

                //if (checkBoxAmnbanKey.Checked)
                //    encryptionKeys = new EncryptionKeys(Properties.Resources.AmnBAN_PubKey , true);
                //else
                //    encryptionKeys = new EncryptionKeys(openFileDialogReciverPubKey.FileName);

                Encrypter encrypter = new Encrypter(encryptionKeys);
                using (Stream outputStream = File.Create(saveFileDialog1.FileName))
                {
                    encrypter.Encrypt(outputStream, new FileInfo(textBoxFilePath.Text));
                }
                MessageBox.Show("رمزگذاری با موفقیت انجام شد", "انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private static string createNewFilter(string fileName)
        {
            if (fileName.Contains(".")){
            string prefix = "Amn File(*";
            string filter = fileName.Substring(fileName.LastIndexOf(".")) + ".amn)| *" + fileName.Substring(fileName.LastIndexOf(".")) + ".amn";
            return prefix + filter;
            }
            else
            {
                return "Amn File(*.amn)| *.amn";
            }
        }

        private void TextBoxFilePath_TextChanged(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = createNewFilter(textBoxFilePath.Text);
        }

        private void LabelReciverKey_Click(object sender, EventArgs e)
        {

        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
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

        private void FormEncryption_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void RadioButtonAmnBanKey_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonAmnBanKey.Checked)
                buttonSelectPubKey.Enabled = false;
            else
                buttonSelectPubKey.Enabled = true;
        }
    }
}
