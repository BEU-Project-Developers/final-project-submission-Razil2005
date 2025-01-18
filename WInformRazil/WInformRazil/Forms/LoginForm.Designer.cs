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
            lbl_loginBaslig = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(562, 138);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(49, 20);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(644, 135);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(267, 27);
            txtLogin.TabIndex = 1;
            toolTip.SetToolTip(txtLogin, "Lütfen kullanıcı adınızı girin");
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(562, 175);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(644, 172);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(267, 27);
            txtPassword.TabIndex = 3;
            toolTip.SetToolTip(txtPassword, "Lütfen şifrenizi girin");
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.PeachPuff;
            btnLogin.Location = new Point(644, 257);
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
            btn_SignUp.Location = new Point(775, 306);
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
            lbl_AccountInformation.Location = new Point(562, 306);
            lbl_AccountInformation.Name = "lbl_AccountInformation";
            lbl_AccountInformation.Size = new Size(216, 28);
            lbl_AccountInformation.TabIndex = 7;
            lbl_AccountInformation.Text = "Don't have an account?";
            // 
            // checkBox_ShowPassword
            // 
            checkBox_ShowPassword.AutoSize = true;
            checkBox_ShowPassword.Location = new Point(603, 222);
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
            lbl_PasswordInformation.Location = new Point(763, 222);
            lbl_PasswordInformation.Name = "lbl_PasswordInformation";
            lbl_PasswordInformation.Size = new Size(124, 20);
            lbl_PasswordInformation.TabIndex = 9;
            lbl_PasswordInformation.Text = "Forget Password?";
            // 
            // lbl_loginBaslig
            // 
            lbl_loginBaslig.AutoSize = true;
            lbl_loginBaslig.Location = new Point(717, 49);
            lbl_loginBaslig.Name = "lbl_loginBaslig";
            lbl_loginBaslig.Size = new Size(197, 20);
            lbl_loginBaslig.TabIndex = 10;
            lbl_loginBaslig.Text = "Library Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(498, 374);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(958, 376);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_loginBaslig);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label lbl_loginBaslig;
        private PictureBox pictureBox1;
    }
}