using System;
using System.Data;
using System.IO;
using System.Linq;
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

        private void PasswordComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PasswordTextBox.Text = Crypter.Decrypt(_elements[PasswordComboBox.SelectedIndex].Key);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdatePasswords();
        }

        private void UpdatePasswords()
        {
            string[] lines = File.ReadAllLines(@"passwords.txt");
            _elements = lines.Select((line) => new PasswordElement(line)).ToArray();

            foreach (var t in _elements)
            {
                PasswordComboBox.Items.Add(t.Name);
            }
        }
    }
}
