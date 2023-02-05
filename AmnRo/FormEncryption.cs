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
        bool _English;
        public FormEncryption(bool English)
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
            Convert_Lang(English);
            _English = English;
        }
        private void Convert_Lang(bool English)
        {
            if (English == true)
            {
                Text = "Encryption";
                buttonSelectFile.Text = "Select File";
                labelReciverKey.Text = "Receiver's Public Key Did't Got Selected Yet";
                radioButtonSelectKey.Text = "Key Select";
                radioButtonAmnBanKey.Text = "Amnban Key";
                buttonSelectPubKey.Text = "Choose Receiver's Public Key";

            }
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
                if (_English == true)
                    MessageBox.Show("Please Choose A File to Encrypt", "File Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("لطفا فایل مورد نظر برای رمزگذاری را انتخاب کنید", "انتخاب فایل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSelectFile.Focus();
                return;
            }
            if (!File.Exists(textBoxFilePath.Text))
            {
                if (_English == true)
                    MessageBox.Show("Selected File Does Not Exist Or Is Not Accessable", "File Does Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("فایل انتخاب شده وجود ندارد یا قابل دسترسی نیست", "فایل وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSelectFile.Focus();
                return;
            }
            if (radioButtonSelectKey.Checked)
            {
                if (string.IsNullOrEmpty(openFileDialogReciverPubKey.FileName))
                {
                    if (_English == true)
                        MessageBox.Show("Receiver's Public Key Did't Get Selected Yet", "File Does Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("کلید عمومی گیرنده انتخاب نشده است ", "فایل وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    buttonSelectFile.Focus();
                    return;
                }
            }

            else if (!radioButtonAmnBanKey.Checked)
            {
                if (_English == true)
                    MessageBox.Show("Receiver's Public Key Did't Got Selected Yet", "File Does Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
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
                if (_English == true)
                    MessageBox.Show("Encryption Done Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("رمزگذاری با موفقیت انجام شد", "انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private static string createNewFilter(string fileName)
        {
            return "Amn File(*.amn)| *.amn";
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
            if (radioButtonAmnBanKey.Checked)
            {
                buttonSelectPubKey.Enabled = false;
                labelReciverKey.Text = "";
            }
            else
            {
                buttonSelectPubKey.Enabled = true;
                if (_English == true)
                    labelReciverKey.Text = "Public Key Didn't Get Selected Yet";
                else
                    labelReciverKey.Text = "کلید عمومی گیرنده هنوز انتخاب نشده";
            }
        }
    }
}
