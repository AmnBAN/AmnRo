using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;

namespace AmnRo
{
    public partial class FormKeyGen : MaterialForm
    {
        bool _English = true;
        public FormKeyGen(bool English)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800, Primary.Blue900,
                Primary.Blue900, Accent.LightBlue200,
                TextShade.WHITE
            );
            Convert_Lang(English);
            _English = English;
        }

        private void Convert_Lang(bool Lang)
        {
            if (Lang == true)
            {
                label1.Text = "Key Size";
                label2.Text = "Key Name";
                label3.Text = "Password";
                label4.Text = "Re-Enter Pass";
            }
        }
        private void BtnKeyGen_Click(object sender, EventArgs e)
        {   
            if (string.IsNullOrEmpty(textBoxKeyName.Text))
            {
                if(_English == true)
                    MessageBox.Show("Enter The Key's Name", "Key Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("نام کلید را وارد کنید", "نام کلید", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                textBoxKeyName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxPass1.Text))
            {
                if (_English == true)
                    MessageBox.Show("Enter The Password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("کلمه عبور را وارد کنید", "کلمه عبور", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxKeyName.Focus();
                return;
            }
            if (textBoxPass1.Text != textBoxPass2.Text)
            {
                if (_English == true)
                    MessageBox.Show("Enter The Password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("کلمه عبور را یکسان وارد کنید", "کلمه عبور", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxPass1.Focus(); 
                return;
            }

            //chech error provider
            foreach (Control control in Controls)
            {
                if (errorProvider1.GetError(control) != string.Empty)
                {
                    if (_English == true)
                        MessageBox.Show("Error Occured - Fix the form's Errors", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("لطفا خطاهای فرم را برطرف کنید.", "خطا در ورودی ها", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Amnro"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Amnro");
            }
            PGP.Key.GenerateKey(textBoxKeyName.Text, textBoxPass1.Text, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Amnro");
            if (_English == true)
            {
                MessageBox.Show("Keys Genertated Successfully", "Key Gen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("کلیدها با موفقیت ایجاد شدند", "ایجاد کلید", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FormKeyGen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #region Chech input length
        private void TextBoxKeyName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKeyName.Text.Length > 30)
            {
                if (_English == true)
                {
                    MessageBox.Show("Keys Genertated Successfully", "Key Gen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("کلیدها با موفقیت ایجاد شدند", "ایجاد کلید", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void TextBoxPass1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPass1.Text.Length > 25)
            {
                if (_English == true)
                    errorProvider1.SetError(textBoxPass2, "Maximum Pass Size is 25 Character");
                else
                    errorProvider1.SetError(textBoxPass1, "طول کلمه عبور کلید حداکثر 25 کاراکتر باید باشد.");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void TextBoxPass2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPass2.Text.Length > 25)
            {
                if (_English == true)
                    errorProvider1.SetError(textBoxPass2, "Maximum Pass Size is 25 Character");
                else
                    errorProvider1.SetError(textBoxPass2, "طول کلمه عبور کلید حداکثر 25 کاراکتر باید باشد.");

            }
            else if (textBoxPass2.Text != textBoxPass1.Text)
            {
                if (_English == true)
                    errorProvider1.SetError(textBoxPass2, "Entered Passwords Are Not Same");
                else
                    errorProvider1.SetError(textBoxPass2, "کلمه‌های عبور وارد شده یکسان نیستند.");

            }
            else
            {
                errorProvider1.Clear();
            }
        }
        #endregion

        private void FormKeyGen_Load(object sender, EventArgs e)
        {

        }
    }
}
