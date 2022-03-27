using System;
using System.IO;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class GenerateKeyForm : Form
    {
        public GenerateKeyForm()
        {
            InitializeComponent();
        }

        private void GenerateKeyButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            BinaryWriter bw = new BinaryWriter(File.Open(dialog.FileName, FileMode.OpenOrCreate));
            bw.Write(Crypter.GenerateKey());
            bw.Close();

            Close();
        }
    }
}
