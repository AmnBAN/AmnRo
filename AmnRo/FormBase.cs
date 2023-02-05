using System;
using System.IO;
using System.Windows.Forms;
using AmnRo.Properties;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AmnRo
{
    public partial class FormBase : MaterialForm
    {       
        bool English = false;
        public FormBase()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this) 
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }
        private void BtnKeyGen_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormKeyGen(English).ShowDialog();
            this.Show();
        }

        private void BtnEncryption_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormEncryption(English).ShowDialog();
            this.Show();
        }

        private void BtnDecryption_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormDecryption(English).ShowDialog();
            this.Show();
        }

        #region label texts
        private void BtnKeyGen_MouseHover(object sender, EventArgs e)
        {
            if (English == true)
            {
                labelInfo.Text = "Generate Key";
            }
            else
                labelInfo.Text = "تولید کلید";
            btnKeyGen.Focus();
        }
        private void BtnEncryption_MouseHover(object sender, EventArgs e)
        {
            if (English == true)
            {
                labelInfo.Text = "Encryption";
            }
            else
                labelInfo.Text = "رمزگذاری";
            btnEncryption.Focus();
        }

        private void BtnDecryption_MouseHover(object sender, EventArgs e)
        {
            if (English == true)
            {
                labelInfo.Text = "Decryption";
            }
            else
                labelInfo.Text = "رمزگشایی";
            btnDecryption.Focus();
        }
        private void ButtonAbout_MouseHover(object sender, EventArgs e)
        {
            if (English == true)
            {
                labelInfo.Text = "About Us";
            }
            else
                labelInfo.Text = "درباره ما";
            buttonAbout.Focus();
        }
        private void BtnKeyGen_Enter(object sender, EventArgs e)
        {
            if (English == true)
            {
                labelInfo.Text = "Generate Key";
            }
            else
                labelInfo.Text = "تولید کلید";
        }

        private void BtnEncryption_Enter(object sender, EventArgs e)
        {
            if (English == true)
            {
                labelInfo.Text = "Encryption";
            }
            else
                labelInfo.Text = "رمزگذاری";
        }

        private void BtnDecryption_Enter(object sender, EventArgs e)
        {
            if (English == true)
            {
                labelInfo.Text = "Decryption";
            }
            else
                labelInfo.Text = "رمزگشایی";
        }
        private void ButtonAbout_Enter(object sender, EventArgs e)
        {
            if (English == true)
            {
                labelInfo.Text = "About Us";
            }
            else
                labelInfo.Text = "درباره ما";
        }

        private void ButtonAbout_MouseLeave(object sender, EventArgs e)
        {
            labelInfo.Text = "";
        }

        private void BtnDecryption_MouseLeave(object sender, EventArgs e)
        {
            labelInfo.Text = "";
        }

        private void BtnEncryption_MouseLeave(object sender, EventArgs e)
        {
            labelInfo.Text = "";
        }

        private void BtnKeyGen_MouseLeave(object sender, EventArgs e)
        {
            labelInfo.Text = "";
        }
        #endregion

        private void FormBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AboutBox().ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            English = true;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            English = false;
        }

        private void ChangeLanguage_Click(object sender, EventArgs e)
        {
            English = false;
        }

        private void ChangeLangageEn_Click(object sender, EventArgs e)
        {
            English = true;
        }

        private void ChangeLanguageIR_MouseHover(object sender, EventArgs e)
        {
            labelInfo.Text = "زبان فارسی";
        }

        private void ChangeLangageEn_MouseHover(object sender, EventArgs e)
        {
            labelInfo.Text = "EN Language";
        }

        private void ButtonIntegrate_Click(object sender, EventArgs e)
        {
            var err = IntegrateCustomIcons();
            if (!err)
            {
                MessageBox.Show("Icons Integrated Successfully", "Integration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private bool IntegrateCustomIcons()
        {
            string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Amnro";
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);

            var prikeyPath = dirPath + "\\PrivateKey.png";
            var pubkeyPath = dirPath + "\\PublicKey.png";
            var enc3Path = dirPath + "\\enc3.png";

            Resources.PrivateKey.Save(prikeyPath);
            Resources.PublicKey.Save(pubkeyPath);
            Resources.enc3.Save(enc3Path);


            bool err = false;

            try
            {
                RegistryUtility.SetValue(RegistryUtility.Extensions.private_key_extension, "", prikeyPath);
                RegistryUtility.SetValue(RegistryUtility.Extensions.public_key_extension, "", pubkeyPath);
                RegistryUtility.SetValue(RegistryUtility.Extensions.amn_extension, "", enc3Path);
            }
            catch (Exception exception)
            {
                err = true;
                //MessageBox.Show(exception.Message, "Integration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RegistryUtility.RefereshWindowsIconCache();
            return err;
        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            IntegrateCustomIcons();
        }
    }
    
}
