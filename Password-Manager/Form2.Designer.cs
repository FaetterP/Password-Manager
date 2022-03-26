
namespace Password_Manager
{
    partial class AddPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PasswordNameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordNameLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordNameTextbox
            // 
            this.PasswordNameTextbox.Location = new System.Drawing.Point(74, 39);
            this.PasswordNameTextbox.Name = "PasswordNameTextbox";
            this.PasswordNameTextbox.Size = new System.Drawing.Size(125, 27);
            this.PasswordNameTextbox.TabIndex = 0;
            // 
            // PasswordNameLabel
            // 
            this.PasswordNameLabel.AutoSize = true;
            this.PasswordNameLabel.Location = new System.Drawing.Point(86, 9);
            this.PasswordNameLabel.Name = "PasswordNameLabel";
            this.PasswordNameLabel.Size = new System.Drawing.Size(106, 20);
            this.PasswordNameLabel.TabIndex = 1;
            this.PasswordNameLabel.Text = "Passwod name";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(86, 72);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 112);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PasswordNameLabel);
            this.Controls.Add(this.PasswordNameTextbox);
            this.Name = "AddPasswordForm";
            this.Text = "Add password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordNameTextbox;
        private System.Windows.Forms.Label PasswordNameLabel;
        private System.Windows.Forms.Button AddButton;
    }
}