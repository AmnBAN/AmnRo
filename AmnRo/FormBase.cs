using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AmnRo
{
    public partial class FormBase : MaterialForm
    {
        public FormBase()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void BtnKeyGen_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormKeyGen().ShowDialog();
            this.Show();
        }

        private void BtnEncryption_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormEncryption().ShowDialog();
            this.Show();
        }

        private void BtnDecryption_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormDecryption().ShowDialog();
            this.Show();
        }

        private void BtnKeyGen_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "تولید کلید";
            btnKeyGen.Focus();
        }

        private void BtnEncryption_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "رمزگذاری";
            btnEncryption.Focus();
        }

        private void BtnDecryption_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "رمزگشایی";
            btnDecryption.Focus();
        }

        private void BtnKeyGen_Enter(object sender, EventArgs e)
        {
            label1.Text = "تولید کلید";
        }

        private void BtnEncryption_Enter(object sender, EventArgs e)
        {
            label1.Text = "رمزگذاری";
        }

        private void BtnDecryption_Enter(object sender, EventArgs e)
        {
            label1.Text = "رمزگشایی";
        }

        private void BtnDecryption_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void BtnEncryption_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void BtnKeyGen_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void FormBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
