namespace activity3
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.loginLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.userLoginBtn = new System.Windows.Forms.Button();
            this.signupLink = new System.Windows.Forms.LinkLabel();
            this.logUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logAdmin = new System.Windows.Forms.Label();
            this.changeType = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.Label();
            this.adminLoginBtn = new System.Windows.Forms.Button();
            this.goToSignup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeType)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(546, 67);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(134, 36);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Hey Yow";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(430, 232);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(111, 22);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "USERNAME";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(435, 260);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(343, 30);
            this.username.TabIndex = 2;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(430, 307);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(115, 22);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "PASSWORD";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(435, 335);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(343, 30);
            this.password.TabIndex = 2;
            // 
            // userLoginBtn
            // 
            this.userLoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.userLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLoginBtn.ForeColor = System.Drawing.Color.White;
            this.userLoginBtn.Location = new System.Drawing.Point(435, 391);
            this.userLoginBtn.Name = "userLoginBtn";
            this.userLoginBtn.Size = new System.Drawing.Size(343, 36);
            this.userLoginBtn.TabIndex = 3;
            this.userLoginBtn.Text = "LOGIN";
            this.userLoginBtn.UseVisualStyleBackColor = false;
            this.userLoginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // signupLink
            // 
            this.signupLink.AutoSize = true;
            this.signupLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLink.Location = new System.Drawing.Point(528, 430);
            this.signupLink.Name = "signupLink";
            this.signupLink.Size = new System.Drawing.Size(145, 20);
            this.signupLink.TabIndex = 5;
            this.signupLink.TabStop = true;
            this.signupLink.Text = "Forgot Password?";
            this.signupLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupLink_LinkClicked);
            // 
            // logUser
            // 
            this.logUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logUser.AutoSize = true;
            this.logUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logUser.Location = new System.Drawing.Point(523, 115);
            this.logUser.Name = "logUser";
            this.logUser.Size = new System.Drawing.Size(182, 22);
            this.logUser.TabIndex = 6;
            this.logUser.Text = "Login to your account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 614);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logAdmin
            // 
            this.logAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logAdmin.AutoSize = true;
            this.logAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logAdmin.Location = new System.Drawing.Point(548, 115);
            this.logAdmin.Name = "logAdmin";
            this.logAdmin.Size = new System.Drawing.Size(133, 22);
            this.logAdmin.TabIndex = 6;
            this.logAdmin.Text = "Login as Admin";
            this.logAdmin.Visible = false;
            // 
            // changeType
            // 
            this.changeType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changeType.BackgroundImage")));
            this.changeType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changeType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeType.Location = new System.Drawing.Point(580, 167);
            this.changeType.Name = "changeType";
            this.changeType.Size = new System.Drawing.Size(50, 46);
            this.changeType.TabIndex = 8;
            this.changeType.TabStop = false;
            this.changeType.Click += new System.EventHandler(this.changeType_Click);
            // 
            // user
            // 
            this.user.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user.AutoSize = true;
            this.user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(636, 191);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(48, 22);
            this.user.TabIndex = 6;
            this.user.Text = "User";
            this.user.Visible = false;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // admin
            // 
            this.admin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.admin.AutoSize = true;
            this.admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.Location = new System.Drawing.Point(636, 167);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(60, 22);
            this.admin.TabIndex = 6;
            this.admin.Text = "Admin";
            this.admin.Visible = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // adminLoginBtn
            // 
            this.adminLoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.adminLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginBtn.ForeColor = System.Drawing.Color.White;
            this.adminLoginBtn.Location = new System.Drawing.Point(435, 391);
            this.adminLoginBtn.Name = "adminLoginBtn";
            this.adminLoginBtn.Size = new System.Drawing.Size(343, 36);
            this.adminLoginBtn.TabIndex = 9;
            this.adminLoginBtn.Text = "LOGIN";
            this.adminLoginBtn.UseVisualStyleBackColor = false;
            this.adminLoginBtn.Visible = false;
            this.adminLoginBtn.Click += new System.EventHandler(this.adminLoginBtn_Click);
            // 
            // goToSignup
            // 
            this.goToSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(42)))));
            this.goToSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToSignup.ForeColor = System.Drawing.Color.White;
            this.goToSignup.Location = new System.Drawing.Point(498, 496);
            this.goToSignup.Name = "goToSignup";
            this.goToSignup.Size = new System.Drawing.Size(236, 36);
            this.goToSignup.TabIndex = 10;
            this.goToSignup.Text = "SIGNUP";
            this.goToSignup.UseVisualStyleBackColor = false;
            this.goToSignup.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "____________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.goToSignup);
            this.Controls.Add(this.adminLoginBtn);
            this.Controls.Add(this.changeType);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.user);
            this.Controls.Add(this.logAdmin);
            this.Controls.Add(this.logUser);
            this.Controls.Add(this.signupLink);
            this.Controls.Add(this.userLoginBtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.username);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button userLoginBtn;
        private System.Windows.Forms.LinkLabel signupLink;
        private System.Windows.Forms.Label logUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logAdmin;
        private System.Windows.Forms.PictureBox changeType;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label admin;
        private System.Windows.Forms.Button adminLoginBtn;
        private System.Windows.Forms.Button goToSignup;
        private System.Windows.Forms.Label label1;
    }
}

