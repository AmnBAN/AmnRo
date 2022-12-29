using System;
using System.Windows.Forms;
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
                labelInfo.Text = "Key Generation";
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
                labelInfo.Text = "Key Generation";
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
    }
}
