using System;
using System.Drawing;
using System.IO;
using System.Threading;
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

            comboBoxLanguage.SelectedIndex = 0;

            ChangeLanguageIR.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject($"{Thread.CurrentThread.CurrentCulture.Name}");
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
            labelInfo.Text = Resources.Messages.GenerateKey;
            btnKeyGen.Focus();
        }
        private void BtnEncryption_MouseHover(object sender, EventArgs e)
        {
            labelInfo.Text = Resources.Messages.Encryption;

            btnEncryption.Focus();
        }

        private void BtnDecryption_MouseHover(object sender, EventArgs e)
        {
            labelInfo.Text = Resources.Messages.Decryption;

            btnDecryption.Focus();
        }
        private void ButtonAbout_MouseHover(object sender, EventArgs e)
        {
            labelInfo.Text = Resources.Messages.AboutUs;

            buttonAbout.Focus();
        }
        private void BtnKeyGen_Enter(object sender, EventArgs e)
        {
            labelInfo.Text = Resources.Messages.GenerateKey;

        }

        private void BtnEncryption_Enter(object sender, EventArgs e)
        {
            labelInfo.Text = Resources.Messages.Encryption;
        }

        private void BtnDecryption_Enter(object sender, EventArgs e)
        {
            labelInfo.Text = Resources.Messages.Decryption;

        }
        private void ButtonAbout_Enter(object sender, EventArgs e)
        {
            labelInfo.Text = Resources.Messages.AboutUs;

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

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fa");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fa");
            this.Refresh();

            English = false;
        }

        private void ChangeLanguage_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fa");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fa"); this.Refresh();
            //English = false;
        }

        private void ChangeLangageEn_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en"); this.Refresh();

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



        private void FormBase_Load(object sender, EventArgs e)
        {
            //IntegrateCustomIcons();
            RegistryUtility.AddShieldToButton(ButtonIntegrate);
        }

        private void ButtonIntegrate_Click_1(object sender, EventArgs e)
        {

            var isAdmin = RegistryUtility.IsAdministrator();

            if (isAdmin)
            {
                var err = RegistryUtility.IntegrateCustomIcons();
                if (!err)
                {
                    MessageBox.Show(Resources.Messages.IconsIntegratedSuccessfully, Resources.Messages.Integration, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                RegistryUtility.ExecuteAsAdmin();
            }


        }
    }

}
