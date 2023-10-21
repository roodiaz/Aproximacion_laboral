namespace Gestion_productos
{
    partial class frmLogin
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
            pnlUp = new Panel();
            btnMinimize = new PictureBox();
            btnClose = new PictureBox();
            pnlDown = new Panel();
            picBoxSun = new PictureBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblTitle = new Label();
            picBoxPassword = new PictureBox();
            picBoxUsername = new PictureBox();
            pnlUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxSun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxUsername).BeginInit();
            SuspendLayout();
            // 
            // pnlUp
            // 
            pnlUp.BackColor = Color.SkyBlue;
            pnlUp.Controls.Add(btnMinimize);
            pnlUp.Controls.Add(btnClose);
            pnlUp.Dock = DockStyle.Top;
            pnlUp.Location = new Point(0, 0);
            pnlUp.Name = "pnlUp";
            pnlUp.Size = new Size(408, 41);
            pnlUp.TabIndex = 0;
            // 
            // btnMinimize
            // 
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Image = Properties.Resources.minimize__1_;
            btnMinimize.Location = new Point(298, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(52, 41);
            btnMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimize.TabIndex = 3;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.close_window;
            btnClose.Location = new Point(356, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(52, 41);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 2;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlDown
            // 
            pnlDown.BackColor = Color.SkyBlue;
            pnlDown.Dock = DockStyle.Bottom;
            pnlDown.Location = new Point(0, 431);
            pnlDown.Name = "pnlDown";
            pnlDown.Size = new Size(408, 41);
            pnlDown.TabIndex = 1;
            // 
            // picBoxSun
            // 
            picBoxSun.Image = Properties.Resources.sun;
            picBoxSun.Location = new Point(130, 110);
            picBoxSun.Name = "picBoxSun";
            picBoxSun.Size = new Size(149, 116);
            picBoxSun.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxSun.TabIndex = 0;
            picBoxSun.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.HighlightText;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Location = new Point(117, 248);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Username";
            txtUserName.Size = new Size(203, 31);
            txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.HighlightText;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(117, 303);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(203, 31);
            txtPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SkyBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(139, 362);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(127, 44);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(84, 61);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(245, 28);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "User login ARS";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picBoxPassword
            // 
            picBoxPassword.Image = Properties.Resources.icons8_password_48;
            picBoxPassword.Location = new Point(76, 303);
            picBoxPassword.Name = "picBoxPassword";
            picBoxPassword.Size = new Size(35, 31);
            picBoxPassword.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxPassword.TabIndex = 8;
            picBoxPassword.TabStop = false;
            // 
            // picBoxUsername
            // 
            picBoxUsername.Image = Properties.Resources.icons8_user_64;
            picBoxUsername.Location = new Point(76, 248);
            picBoxUsername.Name = "picBoxUsername";
            picBoxUsername.Size = new Size(35, 31);
            picBoxUsername.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxUsername.TabIndex = 9;
            picBoxUsername.TabStop = false;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 472);
            Controls.Add(picBoxUsername);
            Controls.Add(picBoxPassword);
            Controls.Add(lblTitle);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(picBoxSun);
            Controls.Add(pnlDown);
            Controls.Add(pnlUp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Opacity = 0.97D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            pnlUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxSun).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxUsername).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlUp;
        private PictureBox btnClose;
        private Panel pnlDown;
        private PictureBox picBoxSun;
        private PictureBox btnMinimize;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblTitle;
        private PictureBox picBoxPassword;
        private PictureBox picBoxUsername;
    }
}