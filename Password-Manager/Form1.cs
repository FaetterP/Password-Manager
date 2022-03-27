using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class MainForm : Form
    {
        private PasswordElement[] _elements;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdatePasswords();
        }

        private void SaveKeyButton_Click(object sender, EventArgs e)
        {
            GenerateKeyForm form = new GenerateKeyForm();
            form.Show();
        }

        private void ReadKeyButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                Crypter.SetKey(File.ReadAllBytes(dialog.FileName));
        }

        private void AddPasswordButton_Click(object sender, EventArgs e)
        {
            AddPasswordForm form = new AddPasswordForm();
            form.Show();
        }

        private void PasswordComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PasswordTextBox.Text = Crypter.Decrypt(_elements[PasswordComboBox.SelectedIndex].Key);
            try
            {
                PasswordTextBox.Text = Crypter.Decrypt(_elements[PasswordComboBox.SelectedIndex].Key);
            }
            catch (CryptographicException exc)
            {
                ErrorForm form = new ErrorForm();
                form.Show();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdatePasswords();
        }

        private void UpdatePasswords()
        {
            PasswordComboBox.Items.Clear();

            string[] lines = File.ReadAllLines(@"passwords.txt");
            _elements = lines.Select((line) => new PasswordElement(line)).ToArray();

            foreach (var t in _elements)
            {
                PasswordComboBox.Items.Add(t.Name);
            }
        }
    }
}
