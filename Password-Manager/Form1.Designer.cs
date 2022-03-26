
namespace Password_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadKeyButton = new System.Windows.Forms.Button();
            this.PasswordComboBox = new System.Windows.Forms.ComboBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SaveKeyButton = new System.Windows.Forms.Button();
            this.PasswordComboBoxLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.AddPasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadKeyButton
            // 
            this.ReadKeyButton.Location = new System.Drawing.Point(112, 4);
            this.ReadKeyButton.Name = "ReadKeyButton";
            this.ReadKeyButton.Size = new System.Drawing.Size(94, 29);
            this.ReadKeyButton.TabIndex = 0;
            this.ReadKeyButton.Text = "Read key";
            this.ReadKeyButton.UseVisualStyleBackColor = true;
            this.ReadKeyButton.Click += new System.EventHandler(this.ReadKeyButton_Click);
            // 
            // PasswordComboBox
            // 
            this.PasswordComboBox.FormattingEnabled = true;
            this.PasswordComboBox.Location = new System.Drawing.Point(12, 67);
            this.PasswordComboBox.Name = "PasswordComboBox";
            this.PasswordComboBox.Size = new System.Drawing.Size(151, 28);
            this.PasswordComboBox.TabIndex = 1;
            this.PasswordComboBox.SelectedIndexChanged += new System.EventHandler(this.PasswordComboBox_SelectedIndexChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(169, 67);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(125, 27);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // SaveKeyButton
            // 
            this.SaveKeyButton.Location = new System.Drawing.Point(12, 3);
            this.SaveKeyButton.Name = "SaveKeyButton";
            this.SaveKeyButton.Size = new System.Drawing.Size(94, 29);
            this.SaveKeyButton.TabIndex = 3;
            this.SaveKeyButton.Text = "Save key";
            this.SaveKeyButton.UseVisualStyleBackColor = true;
            this.SaveKeyButton.Click += new System.EventHandler(this.SaveKeyButton_Click);
            // 
            // PasswordComboBoxLabel
            // 
            this.PasswordComboBoxLabel.AutoSize = true;
            this.PasswordComboBoxLabel.Location = new System.Drawing.Point(12, 44);
            this.PasswordComboBoxLabel.Name = "PasswordComboBoxLabel";
            this.PasswordComboBoxLabel.Size = new System.Drawing.Size(116, 20);
            this.PasswordComboBoxLabel.TabIndex = 4;
            this.PasswordComboBoxLabel.Text = "Select password";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(169, 44);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(70, 20);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // AddPasswordButton
            // 
            this.AddPasswordButton.Location = new System.Drawing.Point(212, 3);
            this.AddPasswordButton.Name = "AddPasswordButton";
            this.AddPasswordButton.Size = new System.Drawing.Size(120, 29);
            this.AddPasswordButton.TabIndex = 6;
            this.AddPasswordButton.Text = "Add password";
            this.AddPasswordButton.UseVisualStyleBackColor = true;
            this.AddPasswordButton.Click += new System.EventHandler(this.AddPasswordButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 116);
            this.Controls.Add(this.AddPasswordButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordComboBoxLabel);
            this.Controls.Add(this.SaveKeyButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordComboBox);
            this.Controls.Add(this.ReadKeyButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadKeyButton;
        private System.Windows.Forms.ComboBox PasswordComboBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button SaveKeyButton;
        private System.Windows.Forms.Label PasswordComboBoxLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button AddPasswordButton;
    }
}

