namespace Store.App
{
    partial class Login
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.noAccountLabel = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(260, 42);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(125, 41);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(158, 118);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PlaceholderText = "Username";
            this.userNameTextBox.Size = new System.Drawing.Size(331, 31);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(158, 170);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PlaceholderText = "Password";
            this.passwordTextBox.Size = new System.Drawing.Size(331, 31);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(273, 225);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(112, 34);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // noAccountLabel
            // 
            this.noAccountLabel.AutoSize = true;
            this.noAccountLabel.Location = new System.Drawing.Point(203, 286);
            this.noAccountLabel.Name = "noAccountLabel";
            this.noAccountLabel.Size = new System.Drawing.Size(114, 25);
            this.noAccountLabel.TabIndex = 4;
            this.noAccountLabel.Text = "No Account?";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(332, 281);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(112, 34);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 362);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.noAccountLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.loginLabel);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label loginLabel;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Button loginBtn;
        private Label noAccountLabel;
        private Button registerBtn;
    }
}