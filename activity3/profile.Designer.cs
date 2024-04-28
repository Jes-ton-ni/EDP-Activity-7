namespace activity3
{
    partial class profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile));
            this.navigationMenu = new System.Windows.Forms.MenuStrip();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.editProfileLabel = new System.Windows.Forms.Label();
            this.transLabel = new System.Windows.Forms.Label();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.about_underline = new System.Windows.Forms.Label();
            this.edit_underline = new System.Windows.Forms.Label();
            this.transaction_underline = new System.Windows.Forms.Label();
            this.editPanel = new System.Windows.Forms.Panel();
            this.cancelEditButton = new System.Windows.Forms.Button();
            this.saveEditButton = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.transactionPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.transactionGridView = new System.Windows.Forms.DataGridView();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.navigationMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.aboutPanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.transactionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationMenu
            // 
            this.navigationMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.navigationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.homeToolStripMenuItem});
            this.navigationMenu.Location = new System.Drawing.Point(0, 0);
            this.navigationMenu.Name = "navigationMenu";
            this.navigationMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.navigationMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.navigationMenu.Size = new System.Drawing.Size(800, 31);
            this.navigationMenu.TabIndex = 4;
            this.navigationMenu.Text = "Navigation";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.salesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(87, 27);
            this.salesToolStripMenuItem.Text = "PROFILE";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(115, 27);
            this.aboutToolStripMenuItem.Text = "INVENTORY";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(73, 27);
            this.homeToolStripMenuItem.Text = "HOME";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(16, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 100);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(144, 80);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(240, 29);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "FirstName LastName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "_________________________________________________________________________________" +
    "____________________________";
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutLabel.Enabled = false;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.Location = new System.Drawing.Point(26, 165);
            this.aboutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(97, 25);
            this.aboutLabel.TabIndex = 10;
            this.aboutLabel.Text = "About Me";
            this.aboutLabel.Click += new System.EventHandler(this.aboutLabel_Click);
            // 
            // editProfileLabel
            // 
            this.editProfileLabel.AutoSize = true;
            this.editProfileLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfileLabel.Location = new System.Drawing.Point(144, 165);
            this.editProfileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.editProfileLabel.Name = "editProfileLabel";
            this.editProfileLabel.Size = new System.Drawing.Size(104, 25);
            this.editProfileLabel.TabIndex = 11;
            this.editProfileLabel.Text = "Edit Profile";
            this.editProfileLabel.Click += new System.EventHandler(this.editProfileLabel_Click);
            // 
            // transLabel
            // 
            this.transLabel.AutoSize = true;
            this.transLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transLabel.Location = new System.Drawing.Point(272, 165);
            this.transLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.transLabel.Name = "transLabel";
            this.transLabel.Size = new System.Drawing.Size(180, 25);
            this.transLabel.TabIndex = 12;
            this.transLabel.Text = "Transaction History";
            this.transLabel.Click += new System.EventHandler(this.transLabel_Click);
            // 
            // aboutPanel
            // 
            this.aboutPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.aboutPanel.Controls.Add(this.emailTextBox);
            this.aboutPanel.Controls.Add(this.contactTextBox);
            this.aboutPanel.Controls.Add(this.usernameTextBox);
            this.aboutPanel.Controls.Add(this.emailLabel);
            this.aboutPanel.Controls.Add(this.contactLabel);
            this.aboutPanel.Controls.Add(this.usernameLabel);
            this.aboutPanel.Location = new System.Drawing.Point(149, 222);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(519, 200);
            this.aboutPanel.TabIndex = 13;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(146, 127);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(269, 28);
            this.emailTextBox.TabIndex = 15;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Enabled = false;
            this.contactTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTextBox.Location = new System.Drawing.Point(146, 80);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.ReadOnly = true;
            this.contactTextBox.Size = new System.Drawing.Size(269, 28);
            this.contactTextBox.TabIndex = 15;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Enabled = false;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(146, 34);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(269, 28);
            this.usernameTextBox.TabIndex = 15;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(31, 130);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(66, 25);
            this.emailLabel.TabIndex = 14;
            this.emailLabel.Text = "Email:";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(31, 83);
            this.contactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(86, 25);
            this.contactLabel.TabIndex = 14;
            this.contactLabel.Text = "Contact:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(31, 37);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(108, 25);
            this.usernameLabel.TabIndex = 14;
            this.usernameLabel.Text = "Username:";
            // 
            // about_underline
            // 
            this.about_underline.AutoSize = true;
            this.about_underline.BackColor = System.Drawing.Color.Transparent;
            this.about_underline.Enabled = false;
            this.about_underline.Location = new System.Drawing.Point(22, 177);
            this.about_underline.Name = "about_underline";
            this.about_underline.Size = new System.Drawing.Size(105, 16);
            this.about_underline.TabIndex = 14;
            this.about_underline.Text = "______________";
            // 
            // edit_underline
            // 
            this.edit_underline.AutoSize = true;
            this.edit_underline.BackColor = System.Drawing.Color.Transparent;
            this.edit_underline.Enabled = false;
            this.edit_underline.Location = new System.Drawing.Point(143, 177);
            this.edit_underline.Name = "edit_underline";
            this.edit_underline.Size = new System.Drawing.Size(105, 16);
            this.edit_underline.TabIndex = 14;
            this.edit_underline.Text = "______________";
            this.edit_underline.Visible = false;
            // 
            // transaction_underline
            // 
            this.transaction_underline.AutoSize = true;
            this.transaction_underline.BackColor = System.Drawing.Color.Transparent;
            this.transaction_underline.Enabled = false;
            this.transaction_underline.Location = new System.Drawing.Point(275, 177);
            this.transaction_underline.Name = "transaction_underline";
            this.transaction_underline.Size = new System.Drawing.Size(175, 16);
            this.transaction_underline.TabIndex = 14;
            this.transaction_underline.Text = "________________________";
            this.transaction_underline.Visible = false;
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.editPanel.Controls.Add(this.cancelEditButton);
            this.editPanel.Controls.Add(this.saveEditButton);
            this.editPanel.Controls.Add(this.textBoxPassword);
            this.editPanel.Controls.Add(this.textBoxEmail);
            this.editPanel.Controls.Add(this.textBoxContact);
            this.editPanel.Controls.Add(this.label5);
            this.editPanel.Controls.Add(this.textBoxName);
            this.editPanel.Controls.Add(this.textBoxUsername);
            this.editPanel.Controls.Add(this.label2);
            this.editPanel.Controls.Add(this.label7);
            this.editPanel.Controls.Add(this.label3);
            this.editPanel.Controls.Add(this.label4);
            this.editPanel.Location = new System.Drawing.Point(149, 222);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(519, 331);
            this.editPanel.TabIndex = 16;
            this.editPanel.Visible = false;
            // 
            // cancelEditButton
            // 
            this.cancelEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelEditButton.Location = new System.Drawing.Point(324, 280);
            this.cancelEditButton.Name = "cancelEditButton";
            this.cancelEditButton.Size = new System.Drawing.Size(93, 34);
            this.cancelEditButton.TabIndex = 16;
            this.cancelEditButton.Text = "Cancel";
            this.cancelEditButton.UseVisualStyleBackColor = true;
            // 
            // saveEditButton
            // 
            this.saveEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEditButton.Location = new System.Drawing.Point(223, 280);
            this.saveEditButton.Name = "saveEditButton";
            this.saveEditButton.Size = new System.Drawing.Size(93, 34);
            this.saveEditButton.TabIndex = 16;
            this.saveEditButton.Text = "Save";
            this.saveEditButton.UseVisualStyleBackColor = true;
            this.saveEditButton.Click += new System.EventHandler(this.saveEditButton_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(148, 190);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(269, 28);
            this.textBoxEmail.TabIndex = 15;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(148, 143);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(269, 28);
            this.textBoxContact.TabIndex = 15;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(148, 53);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(269, 28);
            this.textBoxUsername.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Username:";
            // 
            // transactionPanel
            // 
            this.transactionPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.transactionPanel.Controls.Add(this.transactionGridView);
            this.transactionPanel.Controls.Add(this.label6);
            this.transactionPanel.Location = new System.Drawing.Point(93, 222);
            this.transactionPanel.Name = "transactionPanel";
            this.transactionPanel.Size = new System.Drawing.Size(623, 288);
            this.transactionPanel.TabIndex = 17;
            this.transactionPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Transaction History";
            // 
            // transactionGridView
            // 
            this.transactionGridView.AllowUserToAddRows = false;
            this.transactionGridView.AllowUserToDeleteRows = false;
            this.transactionGridView.AllowUserToResizeColumns = false;
            this.transactionGridView.AllowUserToResizeRows = false;
            this.transactionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.transactionGridView.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.transactionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.transactionGridView.Location = new System.Drawing.Point(31, 47);
            this.transactionGridView.Name = "transactionGridView";
            this.transactionGridView.ReadOnly = true;
            this.transactionGridView.RowHeadersWidth = 51;
            this.transactionGridView.RowTemplate.Height = 24;
            this.transactionGridView.ShowCellToolTips = false;
            this.transactionGridView.ShowEditingIcon = false;
            this.transactionGridView.Size = new System.Drawing.Size(572, 225);
            this.transactionGridView.TabIndex = 15;
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(148, 235);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(269, 28);
            this.textBoxPassword.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(148, 95);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(269, 28);
            this.textBoxName.TabIndex = 15;
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.aboutPanel);
            this.Controls.Add(this.transLabel);
            this.Controls.Add(this.editProfileLabel);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.navigationMenu);
            this.Controls.Add(this.transaction_underline);
            this.Controls.Add(this.edit_underline);
            this.Controls.Add(this.about_underline);
            this.Controls.Add(this.transactionPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "profile";
            this.Load += new System.EventHandler(this.profile_Load);
            this.navigationMenu.ResumeLayout(false);
            this.navigationMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.aboutPanel.ResumeLayout(false);
            this.aboutPanel.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.transactionPanel.ResumeLayout(false);
            this.transactionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip navigationMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label editProfileLabel;
        private System.Windows.Forms.Label transLabel;
        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label about_underline;
        private System.Windows.Forms.Label edit_underline;
        private System.Windows.Forms.Label transaction_underline;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelEditButton;
        private System.Windows.Forms.Button saveEditButton;
        private System.Windows.Forms.Panel transactionPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView transactionGridView;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label7;
    }
}