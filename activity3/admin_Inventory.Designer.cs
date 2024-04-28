namespace activity3
{
    partial class admin_Inventory
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
            this.navigationMenu = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invntoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printInventory = new System.Windows.Forms.Button();
            this.outOfStock = new System.Windows.Forms.Button();
            this.Available = new System.Windows.Forms.Button();
            this.all = new System.Windows.Forms.Button();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.navigationMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationMenu
            // 
            this.navigationMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.navigationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.invntoryToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.navigationMenu.Location = new System.Drawing.Point(0, 0);
            this.navigationMenu.Name = "navigationMenu";
            this.navigationMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.navigationMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.navigationMenu.Size = new System.Drawing.Size(800, 28);
            this.navigationMenu.TabIndex = 38;
            this.navigationMenu.Text = "Navigation";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // invntoryToolStripMenuItem
            // 
            this.invntoryToolStripMenuItem.Enabled = false;
            this.invntoryToolStripMenuItem.Name = "invntoryToolStripMenuItem";
            this.invntoryToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.invntoryToolStripMenuItem.Text = "Inventory";
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
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // printInventory
            // 
            this.printInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printInventory.Location = new System.Drawing.Point(587, 508);
            this.printInventory.Name = "printInventory";
            this.printInventory.Size = new System.Drawing.Size(161, 48);
            this.printInventory.TabIndex = 43;
            this.printInventory.Text = "Print Inventory";
            this.printInventory.UseVisualStyleBackColor = true;
            this.printInventory.Click += new System.EventHandler(this.printInventory_Click);
            // 
            // outOfStock
            // 
            this.outOfStock.Location = new System.Drawing.Point(278, 106);
            this.outOfStock.Name = "outOfStock";
            this.outOfStock.Size = new System.Drawing.Size(160, 32);
            this.outOfStock.TabIndex = 40;
            this.outOfStock.Text = "Out of Stocks";
            this.outOfStock.UseVisualStyleBackColor = true;
            this.outOfStock.Click += new System.EventHandler(this.outOfStock_Click);
            // 
            // Available
            // 
            this.Available.Location = new System.Drawing.Point(172, 106);
            this.Available.Name = "Available";
            this.Available.Size = new System.Drawing.Size(100, 32);
            this.Available.TabIndex = 41;
            this.Available.Text = "Available";
            this.Available.UseVisualStyleBackColor = true;
            this.Available.Click += new System.EventHandler(this.Available_Click);
            // 
            // all
            // 
            this.all.Location = new System.Drawing.Point(66, 106);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(100, 32);
            this.all.TabIndex = 42;
            this.all.Text = "All";
            this.all.UseVisualStyleBackColor = true;
            this.all.Click += new System.EventHandler(this.all_Click);
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AllowUserToAddRows = false;
            this.inventoryGridView.AllowUserToDeleteRows = false;
            this.inventoryGridView.AllowUserToResizeColumns = false;
            this.inventoryGridView.AllowUserToResizeRows = false;
            this.inventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGridView.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.inventoryGridView.Location = new System.Drawing.Point(66, 157);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.RowHeadersWidth = 51;
            this.inventoryGridView.RowTemplate.Height = 24;
            this.inventoryGridView.Size = new System.Drawing.Size(682, 318);
            this.inventoryGridView.TabIndex = 39;
            // 
            // admin_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.navigationMenu);
            this.Controls.Add(this.printInventory);
            this.Controls.Add(this.outOfStock);
            this.Controls.Add(this.Available);
            this.Controls.Add(this.all);
            this.Controls.Add(this.inventoryGridView);
            this.Name = "admin_Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_Inventory";
            this.Load += new System.EventHandler(this.admin_Inventory_Load);
            this.navigationMenu.ResumeLayout(false);
            this.navigationMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip navigationMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.Button printInventory;
        private System.Windows.Forms.Button outOfStock;
        private System.Windows.Forms.Button Available;
        private System.Windows.Forms.Button all;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.ToolStripMenuItem invntoryToolStripMenuItem;
    }
}