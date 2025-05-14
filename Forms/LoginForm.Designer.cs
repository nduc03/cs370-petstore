namespace petstore
{
    partial class LoginForm
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
            gbLogin = new GroupBox();
            btnSignup = new Button();
            btnLogin = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // gbLogin
            // 
            gbLogin.Anchor = AnchorStyles.Top;
            gbLogin.Controls.Add(btnSignup);
            gbLogin.Controls.Add(btnLogin);
            gbLogin.Controls.Add(lblPassword);
            gbLogin.Controls.Add(txtPassword);
            gbLogin.Controls.Add(lblUsername);
            gbLogin.Controls.Add(txtUsername);
            gbLogin.Location = new Point(160, 85);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(480, 280);
            gbLogin.TabIndex = 0;
            gbLogin.TabStop = false;
            gbLogin.Text = "Login/Sign up";
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(193, 200);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(94, 29);
            btnSignup.TabIndex = 5;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(193, 165);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(70, 117);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top;
            txtPassword.Location = new Point(149, 114);
            txtPassword.MaxLength = 255;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(262, 27);
            txtPassword.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top;
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(70, 89);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top;
            txtUsername.Location = new Point(149, 86);
            txtUsername.MaxLength = 255;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(262, 27);
            txtUsername.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbLogin);
            Name = "LoginForm";
            Text = "Login/Sign up";
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbLogin;
        private TextBox txtUsername;
        private Label lblUsername;
        private Button btnLogin;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnSignup;
    }
}
