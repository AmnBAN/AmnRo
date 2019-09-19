using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Starksoft.Aspen.GnuPG;
using Org.BouncyCastle;


namespace AmnRo
{
    public partial class FormEncryption : Form
    {
        public FormEncryption()
        {
            InitializeComponent();
        }
        private void FormEncryption_Load(object sender, EventArgs e)
        {
            textBoxSavePath.Text= saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
        }
        private void ButtonSelectFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void ButtonSavePath_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSavePath.Text = saveFileDialog1.FileName;
            }
        }

        private void ButtonEncryption_Click(object sender, EventArgs e)
        {

            /*
             * OLD code use gnupgp
             * 
            Gpg gpg = new Gpg();
            gpg.Recipient = "test@test.com";
            FileStream sourceFile = new FileStream(textBoxFilePath.Text, FileMode.Open);
            FileStream outputFile = new FileStream(textBoxSavePath.Text, FileMode.OpenOrCreate);

            // encrypt the data using IO Streams - any type of input and output IO Stream can be used
            gpg.BinaryPath = @"C:\Program Files (x86)\GnuPG\bin\gpg.exe";
            gpg.Encrypt(sourceFile, outputFile);
            */
        }
    }
}
