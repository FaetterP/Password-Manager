using System;
using System.IO;
using System.Windows.Forms;

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
            StreamWriter sw = new StreamWriter(@"passwords.txt", true);

            string password = PasswordTextbox.Text;
            if (string.IsNullOrEmpty(password))
                password = Crypter.GetPassword();

            sw.WriteLine(PasswordNameTextbox.Text.Replace(' ', '_') + " " + Crypter.Encrypt(password));
            sw.Close();

            Close();
        }
    }
}
