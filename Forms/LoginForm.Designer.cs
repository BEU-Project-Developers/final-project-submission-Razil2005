namespace WInformRazil.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblLogin;
        private TextBox txtLogin;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private ToolTip toolTip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            toolTip = new ToolTip(components);
            btn_SignUp = new Button();
            lbl_AccountInformation = new Label();
            checkBox_ShowPassword = new CheckBox();
            lbl_PasswordInformation = new Label();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(24, 50);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(49, 20);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(106, 43);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(267, 27);
            txtLogin.TabIndex = 1;
            toolTip.SetToolTip(txtLogin, "Lütfen kullanıcı adınızı girin");
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(24, 87);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(106, 84);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(267, 27);
            txtPassword.TabIndex = 3;
            toolTip.SetToolTip(txtPassword, "Lütfen şifrenizi girin");
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.PeachPuff;
            btnLogin.Location = new Point(106, 169);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(190, 43);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            toolTip.SetToolTip(btnLogin, "Giriş yap");
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // btn_SignUp
            // 
            btn_SignUp.BackColor = Color.Peru;
            btn_SignUp.Location = new Point(237, 218);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(105, 33);
            btn_SignUp.TabIndex = 6;
            btn_SignUp.Text = "sign up";
            btn_SignUp.TextAlign = ContentAlignment.TopCenter;
            btn_SignUp.UseVisualStyleBackColor = false;
            // 
            // lbl_AccountInformation
            // 
            lbl_AccountInformation.AutoSize = true;
            lbl_AccountInformation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AccountInformation.ForeColor = Color.Red;
            lbl_AccountInformation.Location = new Point(24, 218);
            lbl_AccountInformation.Name = "lbl_AccountInformation";
            lbl_AccountInformation.Size = new Size(216, 28);
            lbl_AccountInformation.TabIndex = 7;
            lbl_AccountInformation.Text = "Don't have an account?";
            // 
            // checkBox_ShowPassword
            // 
            checkBox_ShowPassword.AutoSize = true;
            checkBox_ShowPassword.Location = new Point(65, 134);
            checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            checkBox_ShowPassword.Size = new Size(129, 24);
            checkBox_ShowPassword.TabIndex = 8;
            checkBox_ShowPassword.Text = "Remember me";
            checkBox_ShowPassword.UseVisualStyleBackColor = true;
            // 
            // lbl_PasswordInformation
            // 
            lbl_PasswordInformation.AutoSize = true;
            lbl_PasswordInformation.ForeColor = Color.Red;
            lbl_PasswordInformation.Location = new Point(225, 134);
            lbl_PasswordInformation.Name = "lbl_PasswordInformation";
            lbl_PasswordInformation.Size = new Size(124, 20);
            lbl_PasswordInformation.TabIndex = 9;
            lbl_PasswordInformation.Text = "Forget Password?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(410, 267);
            Controls.Add(lbl_PasswordInformation);
            Controls.Add(checkBox_ShowPassword);
            Controls.Add(lbl_AccountInformation);
            Controls.Add(btn_SignUp);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Login and Password cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool isAuthenticated = WInformRazil.Services.LoginService.Authenticate(login, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 mainForm = new Form1();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Button btn_SignUp;
        private Label lbl_AccountInformation;
        private CheckBox checkBox_ShowPassword;
        private Label lbl_PasswordInformation;
    }
}