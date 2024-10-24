namespace RegistruReparatii
{
    partial class LoginForm
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
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            LoginButton = new Button();
            ipBox = new TextBox();
            databaseBox = new TextBox();
            databaseLabel = new Label();
            ipLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.FromArgb(24, 30, 54);
            usernameTextBox.Font = new Font("Georgia", 10F);
            usernameTextBox.ForeColor = Color.Gainsboro;
            usernameTextBox.Location = new Point(519, 298);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(287, 23);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(24, 30, 54);
            passwordTextBox.Font = new Font("Georgia", 10F);
            passwordTextBox.ForeColor = Color.Gainsboro;
            passwordTextBox.Location = new Point(519, 344);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(287, 23);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(24, 30, 54);
            LoginButton.Font = new Font("Georgia", 10F);
            LoginButton.ForeColor = Color.Gainsboro;
            LoginButton.Location = new Point(519, 373);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(287, 36);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // ipBox
            // 
            ipBox.BackColor = Color.FromArgb(24, 30, 54);
            ipBox.Font = new Font("Georgia", 10F);
            ipBox.ForeColor = Color.Gainsboro;
            ipBox.Location = new Point(519, 210);
            ipBox.Name = "ipBox";
            ipBox.Size = new Size(287, 23);
            ipBox.TabIndex = 3;
            ipBox.Text = "SET THE IP";
            // 
            // databaseBox
            // 
            databaseBox.BackColor = Color.FromArgb(24, 30, 54);
            databaseBox.Font = new Font("Georgia", 10F);
            databaseBox.ForeColor = Color.Gainsboro;
            databaseBox.Location = new Point(519, 254);
            databaseBox.Name = "databaseBox";
            databaseBox.Size = new Size(287, 23);
            databaseBox.TabIndex = 4;
            databaseBox.Text = "SET THE DATABASE";
            // 
            // databaseLabel
            // 
            databaseLabel.AutoSize = true;
            databaseLabel.ForeColor = Color.Gainsboro;
            databaseLabel.Location = new Point(629, 236);
            databaseLabel.Name = "databaseLabel";
            databaseLabel.Size = new Size(55, 15);
            databaseLabel.TabIndex = 5;
            databaseLabel.Text = "Database";
            // 
            // ipLabel
            // 
            ipLabel.AutoSize = true;
            ipLabel.ForeColor = Color.Gainsboro;
            ipLabel.Location = new Point(647, 192);
            ipLabel.Name = "ipLabel";
            ipLabel.Size = new Size(17, 15);
            ipLabel.TabIndex = 6;
            ipLabel.Text = "IP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(629, 280);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(629, 326);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(1371, 617);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ipLabel);
            Controls.Add(databaseLabel);
            Controls.Add(databaseBox);
            Controls.Add(ipBox);
            Controls.Add(LoginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button LoginButton;
        private TextBox ipBox;
        private TextBox databaseBox;
        private Label databaseLabel;
        private Label ipLabel;
        private Label label3;
        private Label label4;
    }
}