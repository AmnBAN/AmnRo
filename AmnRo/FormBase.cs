using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmnRo
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
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
    }
}
