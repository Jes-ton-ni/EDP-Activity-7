namespace activity3
{
    partial class AdminDashboard
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
            this.accountGridView = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.crudFormPanel = new System.Windows.Forms.Panel();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeTxtBx = new System.Windows.Forms.TextBox();
            this.crudLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.editSaveBtn = new System.Windows.Forms.Button();
            this.addSaveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.contactLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passTxtBx = new System.Windows.Forms.TextBox();
            this.emailTxtBx = new System.Windows.Forms.TextBox();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.contactTxtBx = new System.Windows.Forms.TextBox();
            this.usernameTxtBx = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.navigationMenu = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridView)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.crudFormPanel.SuspendLayout();
            this.navigationMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountGridView
            // 
            this.accountGridView.AllowUserToAddRows = false;
            this.accountGridView.AllowUserToDeleteRows = false;
            this.accountGridView.AllowUserToResizeColumns = false;
            this.accountGridView.AllowUserToResizeRows = false;
            this.accountGridView.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.accountGridView.ColumnHeadersHeight = 29;
            this.accountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.accountGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.password,
            this.name,
            this.contact,
            this.email,
            this.type,
            this.status});
            this.accountGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.accountGridView.Location = new System.Drawing.Point(22, 27);
            this.accountGridView.MultiSelect = false;
            this.accountGridView.Name = "accountGridView";
            this.accountGridView.ReadOnly = true;
            this.accountGridView.RowHeadersWidth = 51;
            this.accountGridView.RowTemplate.Height = 24;
            this.accountGridView.ShowCellToolTips = false;
            this.accountGridView.ShowEditingIcon = false;
            this.accountGridView.ShowRowErrors = false;
            this.accountGridView.Size = new System.Drawing.Size(547, 342);
            this.accountGridView.TabIndex = 0;
            // 
            // username
            // 
            this.username.HeaderText = "username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 125;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // contact
            // 
            this.contact.HeaderText = "Contact";
            this.contact.MinimumWidth = 6;
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            this.contact.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 125;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuPanel.Controls.Add(this.crudFormPanel);
            this.menuPanel.Controls.Add(this.accountGridView);
            this.menuPanel.Location = new System.Drawing.Point(173, 116);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(595, 390);
            this.menuPanel.TabIndex = 22;
            // 
            // crudFormPanel
            // 
            this.crudFormPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.crudFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crudFormPanel.Controls.Add(this.typeLabel);
            this.crudFormPanel.Controls.Add(this.typeTxtBx);
            this.crudFormPanel.Controls.Add(this.crudLabel);
            this.crudFormPanel.Controls.Add(this.passwordLabel);
            this.crudFormPanel.Controls.Add(this.emailLabel);
            this.crudFormPanel.Controls.Add(this.editSaveBtn);
            this.crudFormPanel.Controls.Add(this.addSaveBtn);
            this.crudFormPanel.Controls.Add(this.cancelBtn);
            this.crudFormPanel.Controls.Add(this.contactLabel);
            this.crudFormPanel.Controls.Add(this.nameLabel);
            this.crudFormPanel.Controls.Add(this.usernameLabel);
            this.crudFormPanel.Controls.Add(this.passTxtBx);
            this.crudFormPanel.Controls.Add(this.emailTxtBx);
            this.crudFormPanel.Controls.Add(this.nameTxtBx);
            this.crudFormPanel.Controls.Add(this.contactTxtBx);
            this.crudFormPanel.Controls.Add(this.usernameTxtBx);
            this.crudFormPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.crudFormPanel.Location = new System.Drawing.Point(45, 3);
            this.crudFormPanel.Name = "crudFormPanel";
            this.crudFormPanel.Size = new System.Drawing.Size(493, 343);
            this.crudFormPanel.TabIndex = 1;
            this.crudFormPanel.Visible = false;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(76, 260);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(42, 16);
            this.typeLabel.TabIndex = 27;
            this.typeLabel.Text = "Type:";
            // 
            // typeTxtBx
            // 
            this.typeTxtBx.Location = new System.Drawing.Point(165, 254);
            this.typeTxtBx.Name = "typeTxtBx";
            this.typeTxtBx.Size = new System.Drawing.Size(242, 22);
            this.typeTxtBx.TabIndex = 26;
            // 
            // crudLabel
            // 
            this.crudLabel.AutoSize = true;
            this.crudLabel.Location = new System.Drawing.Point(182, 26);
            this.crudLabel.Name = "crudLabel";
            this.crudLabel.Size = new System.Drawing.Size(83, 16);
            this.crudLabel.TabIndex = 2;
            this.crudLabel.Text = "CRUD Label";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(76, 221);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(70, 16);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(76, 183);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(44, 16);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email:";
            // 
            // editSaveBtn
            // 
            this.editSaveBtn.Location = new System.Drawing.Point(244, 292);
            this.editSaveBtn.Name = "editSaveBtn";
            this.editSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.editSaveBtn.TabIndex = 25;
            this.editSaveBtn.Text = "Save";
            this.editSaveBtn.UseVisualStyleBackColor = true;
            this.editSaveBtn.Visible = false;
            this.editSaveBtn.Click += new System.EventHandler(this.editSaveBtn_Click);
            // 
            // addSaveBtn
            // 
            this.addSaveBtn.Location = new System.Drawing.Point(244, 292);
            this.addSaveBtn.Name = "addSaveBtn";
            this.addSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.addSaveBtn.TabIndex = 25;
            this.addSaveBtn.Text = "Save";
            this.addSaveBtn.UseVisualStyleBackColor = true;
            this.addSaveBtn.Visible = false;
            this.addSaveBtn.Click += new System.EventHandler(this.addSaveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(332, 292);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 25;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(76, 142);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(55, 16);
            this.contactLabel.TabIndex = 1;
            this.contactLabel.Text = "Contact:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(76, 103);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 16);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(76, 58);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 16);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
            // 
            // passTxtBx
            // 
            this.passTxtBx.Location = new System.Drawing.Point(165, 215);
            this.passTxtBx.Name = "passTxtBx";
            this.passTxtBx.PasswordChar = '*';
            this.passTxtBx.Size = new System.Drawing.Size(242, 22);
            this.passTxtBx.TabIndex = 0;
            // 
            // emailTxtBx
            // 
            this.emailTxtBx.Location = new System.Drawing.Point(165, 177);
            this.emailTxtBx.Name = "emailTxtBx";
            this.emailTxtBx.Size = new System.Drawing.Size(242, 22);
            this.emailTxtBx.TabIndex = 0;
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(165, 97);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(242, 22);
            this.nameTxtBx.TabIndex = 0;
            // 
            // contactTxtBx
            // 
            this.contactTxtBx.Location = new System.Drawing.Point(165, 136);
            this.contactTxtBx.Name = "contactTxtBx";
            this.contactTxtBx.Size = new System.Drawing.Size(242, 22);
            this.contactTxtBx.TabIndex = 0;
            // 
            // usernameTxtBx
            // 
            this.usernameTxtBx.Location = new System.Drawing.Point(165, 58);
            this.usernameTxtBx.Name = "usernameTxtBx";
            this.usernameTxtBx.Size = new System.Drawing.Size(242, 22);
            this.usernameTxtBx.TabIndex = 0;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(271, 61);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(311, 22);
            this.searchBox.TabIndex = 23;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(215, 64);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(50, 16);
            this.searchLabel.TabIndex = 24;
            this.searchLabel.Text = "Search";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(32, 143);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 25;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(32, 185);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 25;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(32, 230);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 25;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // navigationMenu
            // 
            this.navigationMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.navigationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.navigationMenu.Location = new System.Drawing.Point(0, 0);
            this.navigationMenu.Name = "navigationMenu";
            this.navigationMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.navigationMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.navigationMenu.Size = new System.Drawing.Size(800, 28);
            this.navigationMenu.TabIndex = 26;
            this.navigationMenu.Text = "Navigation";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.salesToolStripMenuItem.Text = "Order Transaction";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Enabled = false;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(32, 285);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 27;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.navigationMenu);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.menuPanel);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountGridView)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.crudFormPanel.ResumeLayout(false);
            this.crudFormPanel.PerformLayout();
            this.navigationMenu.ResumeLayout(false);
            this.navigationMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView accountGridView;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel crudFormPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox emailTxtBx;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.TextBox contactTxtBx;
        private System.Windows.Forms.TextBox usernameTxtBx;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label crudLabel;
        private System.Windows.Forms.Button editSaveBtn;
        private System.Windows.Forms.Button addSaveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox typeTxtBx;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passTxtBx;
        private System.Windows.Forms.MenuStrip navigationMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
    }
}