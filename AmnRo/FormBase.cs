using System;
using System.Drawing;
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
        public FormBase(string arg)
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this) 
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //Change Form Font to thahoma
            materialSkinManager.ROBOTO_MEDIUM_10 = new Font("Tahoma", 10);
            materialSkinManager.ROBOTO_MEDIUM_11 = new Font("Tahoma", 11);
            materialSkinManager.ROBOTO_MEDIUM_12 = new Font("Tahoma", 11,FontStyle.Bold); //Form title font
            materialSkinManager.ROBOTO_REGULAR_11 = new Font("Tahoma", 11);

            if (RegistryUtility.IsAdministrator())
            {
                // Configure color schema
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Grey800, Primary.Grey900,
                    Primary.Grey500, Accent.LightBlue200,
                    TextShade.WHITE
                );
            }
            else
            {
                // Configure color schema
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Indigo800, Primary.Indigo900,
                    Primary.Indigo500, Accent.LightBlue200,
                    TextShade.WHITE
                );
            }

            //MessageBox.Show("Message: " + arg);

            if (arg.EndsWith("pubk"))
            {
                StartEncForm(arg);
            }else if (arg.EndsWith(".amn") || arg.EndsWith(".priv"))
            {
                StartDecForm(arg);
            }
            
        }
        private void BtnKeyGen_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormKeyGen(English).ShowDialog();
            this.Show();
        }

        private void BtnEncryption_Click(object sender, EventArgs e)
        {
            StartEncForm();
        }

        private void StartEncForm(string pubkeyPath = "")
        {
            this.Hide();
            new FormEncryption(English , pubkeyPath).ShowDialog();
            this.Show();
        }

        private void BtnDecryption_Click(object sender, EventArgs e)
        {
            StartDecForm();
        }
        private void StartDecForm(string filePath = "")
        {
            this.Hide();
            new FormDecryption(English , filePath).ShowDialog();
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
                labelInfo.Text = "About Us";
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
            labelInfo.Text = "English Language";
        }



        private void FormBase_Load(object sender, EventArgs e)
        {
            //IntegrateCustomIcons();
            //RegistryUtility.AddShieldToButton(ButtonIntegrate);
        }

        private void ButtonIntegrate_Click_1(object sender, EventArgs e)
        {

            var isAdmin = RegistryUtility.IsAdministrator();

            if (isAdmin)
            {
                var err = RegistryUtility.IntegrateCustomIcons();
                if (!err)
                {
                    if (English)
                        MessageBox.Show("Icons Integrated Successfully", "Integration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("شخصی سازی آیکون ها با موفقیت انجام شد", "ادغام", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                RegistryUtility.ExecuteAsAdmin();
            }


        }

        private void ButtonIntegrate_Enter(object sender, EventArgs e)
        {
            if (English == true)
                labelInfo.Text = "Add AmnRo Icons to the OS";
            else
                labelInfo.Text = "افزودن آیکون‌های امن‌رو به سیستم عامل";
        }

        private void ButtonIntegrate_MouseHover(object sender, EventArgs e)
        {
            if (English == true)
                labelInfo.Text = "Add AmnRo Icons to the OS";
            else
                labelInfo.Text = "افزودن آیکون‌های امن‌رو به سیستم عامل";
            ButtonIntegrate.Focus();
        }
        private void ButtonIntegrate_MouseLeave(object sender, EventArgs e)
        {
            labelInfo.Text = "";
        }
    }

}
