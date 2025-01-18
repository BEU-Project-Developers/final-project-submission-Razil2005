namespace WInformRazil
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            btnChangeLogin = new Button();
            lblInformation = new Label();
            btn_InformationPage = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.GhostWhite;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(21, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(601, 265);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Location = new Point(21, 407);
            button1.Name = "button1";
            button1.Size = new Size(114, 34);
            button1.TabIndex = 1;
            button1.Text = "Take Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.Location = new Point(672, 407);
            button2.Name = "button2";
            button2.Size = new Size(109, 34);
            button2.TabIndex = 2;
            button2.Text = "Give Book";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.MintCream;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(672, 118);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(558, 265);
            dataGridView2.TabIndex = 3;
            // 
            // btnChangeLogin
            // 
            btnChangeLogin.BackColor = Color.DarkOrchid;
            btnChangeLogin.ForeColor = SystemColors.ButtonFace;
            btnChangeLogin.Location = new Point(136, 490);
            btnChangeLogin.Name = "btnChangeLogin";
            btnChangeLogin.Size = new Size(278, 50);
            btnChangeLogin.TabIndex = 4;
            btnChangeLogin.Text = "Go To Change Login";
            btnChangeLogin.UseVisualStyleBackColor = false;
            btnChangeLogin.Click += BtnChangeLogin_Click;
            // 
            // lblInformation
            // 
            lblInformation.AutoSize = true;
            lblInformation.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInformation.Location = new Point(346, 24);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new Size(420, 54);
            lblInformation.TabIndex = 5;
            lblInformation.Text = "Library Management";
            // 
            // btn_InformationPage
            // 
            btn_InformationPage.BackColor = Color.Purple;
            btn_InformationPage.ForeColor = SystemColors.ButtonHighlight;
            btn_InformationPage.Location = new Point(656, 490);
            btn_InformationPage.Name = "btn_InformationPage";
            btn_InformationPage.Size = new Size(203, 45);
            btn_InformationPage.TabIndex = 6;
            btn_InformationPage.Text = "Go To About";
            btn_InformationPage.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orchid;
            ClientSize = new Size(1279, 600);
            Controls.Add(btn_InformationPage);
            Controls.Add(lblInformation);
            Controls.Add(dataGridView2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnChangeLogin);
            Name = "Form1";
            Text = "Home";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView2;
        private Button btnChangeLogin;
        private Label lblInformation;
        private Button btn_InformationPage;
    }
}
