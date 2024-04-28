namespace activity3
{
    partial class passwordRecovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passwordRecovery));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.recoveryButton = new System.Windows.Forms.Button();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.changeType = new System.Windows.Forms.PictureBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recoveryLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.recoveryButton);
            this.panel1.Controls.Add(this.passwordTxtBox);
            this.panel1.Controls.Add(this.changeType);
            this.panel1.Controls.Add(this.passLabel);
            this.panel1.Controls.Add(this.usernameTxtBox);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(148, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 359);
            this.panel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(79)))), ((int)(((byte)(86)))));
            this.cancelButton.Location = new System.Drawing.Point(126, 284);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(155, 36);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // recoveryButton
            // 
            this.recoveryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.recoveryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryButton.ForeColor = System.Drawing.Color.White;
            this.recoveryButton.Location = new System.Drawing.Point(287, 284);
            this.recoveryButton.Name = "recoveryButton";
            this.recoveryButton.Size = new System.Drawing.Size(155, 36);
            this.recoveryButton.TabIndex = 10;
            this.recoveryButton.Text = "Save";
            this.recoveryButton.UseVisualStyleBackColor = false;
            this.recoveryButton.Click += new System.EventHandler(this.recoveryButton_Click);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(50, 218);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(392, 30);
            this.passwordTxtBox.TabIndex = 5;
            // 
            // changeType
            // 
            this.changeType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changeType.BackgroundImage")));
            this.changeType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changeType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeType.Location = new System.Drawing.Point(169, 3);
            this.changeType.Name = "changeType";
            this.changeType.Size = new System.Drawing.Size(160, 91);
            this.changeType.TabIndex = 9;
            this.changeType.TabStop = false;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(45, 190);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(115, 22);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "PASSWORD";
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.Location = new System.Drawing.Point(50, 143);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(392, 30);
            this.usernameTxtBox.TabIndex = 6;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(45, 115);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(111, 22);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "USERNAME";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(457, 36);
            this.label4.TabIndex = 17;
            this.label4.Text = "__________________________";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recoveryLabel
            // 
            this.recoveryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recoveryLabel.AutoSize = true;
            this.recoveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryLabel.Location = new System.Drawing.Point(257, 89);
            this.recoveryLabel.Name = "recoveryLabel";
            this.recoveryLabel.Size = new System.Drawing.Size(259, 36);
            this.recoveryLabel.TabIndex = 1;
            this.recoveryLabel.Text = "Account Recovery";
            this.recoveryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.recoveryLabel);
            this.Controls.Add(this.panel1);
            this.Name = "passwordRecovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Recovery";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox changeType;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label recoveryLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button recoveryButton;
        private System.Windows.Forms.Label label4;
    }
}