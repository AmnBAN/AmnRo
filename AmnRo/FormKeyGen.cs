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
            comboBoxKeyLength.SelectedIndex = 1;
            textBoxSavePath.Text= folderBrowserDialogSaveKeyPath.SelectedPath = Environment.CurrentDirectory;
        }
        private void ButtonChangeSavePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogSaveKeyPath.ShowDialog() == DialogResult.OK)
            {
                textBoxSavePath.Text = folderBrowserDialogSaveKeyPath.SelectedPath;
            }
        }
        private void BtnKeyGen_Click(object sender, EventArgs e)
        {   
            if (string.IsNullOrEmpty(textBoxUserName.Text))
            {
                MessageBox.Show("نام کاربری را وارد کنید", "نام کاربری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxPass1.Text))
            {
                MessageBox.Show("کلمه عبور را وارد کنید", "کلمه عبور", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserName.Focus();
                return;
            }
            if (textBoxPass1.Text != textBoxPass2.Text)
            {
                MessageBox.Show("کلمه عبور را یکسان وارد کنید", "کلمه عبور", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPass1.Focus();
                return;
            }
            if (File.Exists(string.Format("{0}\\{1}-PrivateKey.priv", textBoxSavePath.Text, textBoxUserName.Text)))
            {
                MessageBox.Show("کلید عمومی با همین نام کاربری در مسیر انتخاب شده وجود دارد\n لطفا مسیر دیگری را انتخاب کنید", "کلمه عبور", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonChangeSavePath.Focus();
                return;
            }
            if (File.Exists(string.Format("{0}\\{1}-PublicKey.pub", textBoxSavePath.Text, textBoxUserName.Text)))
            {
                MessageBox.Show("کلید خصوصی با همین نام کاربری در مسیر انتخاب شده وجود دارد\n لطفا مسیر دیگری را انتخاب کنید", "کلمه عبور", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonChangeSavePath.Focus();
                return;
            }

            PGP.Key.GenerateKey(textBoxUserName.Text, textBoxPass1.Text, textBoxSavePath.Text);
            MessageBox.Show("کلیدها با موفقیت ایجاد شدند", "ایجاد کلید", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

    }
}
