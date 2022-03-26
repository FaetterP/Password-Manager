using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Password_Manager
{
    public partial class AddPasswordForm : Form
    {
        public AddPasswordForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"passwords.txt",true);
            sw.WriteLine(PasswordNameTextbox.Text + " "+ Crypter.GetPassword());
            sw.Close();
            
            Close();
        }
    }
}
