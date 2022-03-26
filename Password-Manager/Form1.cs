using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Password_Manager
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveKeyButton_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(@"key.txt", FileMode.OpenOrCreate));
            bw.Write(Crypter.GetKey());
            bw.Close();
        }

        private void ReadKeyButton_Click(object sender, EventArgs e)
        {
            Crypter.SetKey(File.ReadAllBytes(@"key.txt"));
        }

        private void AddPasswordButton_Click(object sender, EventArgs e)
        {
            AddPasswordForm form = new AddPasswordForm();
            form.Show();
        }
    }
}
