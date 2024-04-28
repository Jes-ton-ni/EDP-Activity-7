namespace activity3
{
    partial class OrderSummary
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
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionGridView = new System.Windows.Forms.DataGridView();
            this.all = new System.Windows.Forms.Button();
            this.completed = new System.Windows.Forms.Button();
            this.processing = new System.Windows.Forms.Button();
            this.printTransaction = new System.Windows.Forms.Button();
            this.navigationMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridView)).BeginInit();
            this.SuspendLayout();
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
            this.navigationMenu.TabIndex = 34;
            this.navigationMenu.Text = "Navigation";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Enabled = false;
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.salesToolStripMenuItem.Text = "Order Transaction";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // transactionGridView
            // 
            this.transactionGridView.AllowUserToAddRows = false;
            this.transactionGridView.AllowUserToDeleteRows = false;
            this.transactionGridView.AllowUserToResizeColumns = false;
            this.transactionGridView.AllowUserToResizeRows = false;
            this.transactionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.transactionGridView.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.transactionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.transactionGridView.Location = new System.Drawing.Point(66, 129);
            this.transactionGridView.Name = "transactionGridView";
            this.transactionGridView.RowHeadersWidth = 51;
            this.transactionGridView.RowTemplate.Height = 24;
            this.transactionGridView.Size = new System.Drawing.Size(682, 318);
            this.transactionGridView.TabIndex = 35;
            // 
            // all
            // 
            this.all.Location = new System.Drawing.Point(66, 82);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(100, 28);
            this.all.TabIndex = 36;
            this.all.Text = "All";
            this.all.UseVisualStyleBackColor = true;
            this.all.Click += new System.EventHandler(this.all_Click);
            // 
            // completed
            // 
            this.completed.Location = new System.Drawing.Point(172, 82);
            this.completed.Name = "completed";
            this.completed.Size = new System.Drawing.Size(100, 28);
            this.completed.TabIndex = 36;
            this.completed.Text = "Completed";
            this.completed.UseVisualStyleBackColor = true;
            this.completed.Click += new System.EventHandler(this.completed_Click);
            // 
            // processing
            // 
            this.processing.Location = new System.Drawing.Point(278, 82);
            this.processing.Name = "processing";
            this.processing.Size = new System.Drawing.Size(100, 28);
            this.processing.TabIndex = 36;
            this.processing.Text = "Processing";
            this.processing.UseVisualStyleBackColor = true;
            this.processing.Click += new System.EventHandler(this.processing_Click);
            // 
            // printTransaction
            // 
            this.printTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printTransaction.Location = new System.Drawing.Point(483, 480);
            this.printTransaction.Name = "printTransaction";
            this.printTransaction.Size = new System.Drawing.Size(265, 48);
            this.printTransaction.TabIndex = 37;
            this.printTransaction.Text = "Print Transaction History";
            this.printTransaction.UseVisualStyleBackColor = true;
            this.printTransaction.Click += new System.EventHandler(this.printTransactionHistory_Click);
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.printTransaction);
            this.Controls.Add(this.processing);
            this.Controls.Add(this.completed);
            this.Controls.Add(this.all);
            this.Controls.Add(this.transactionGridView);
            this.Controls.Add(this.navigationMenu);
            this.Name = "OrderSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.navigationMenu.ResumeLayout(false);
            this.navigationMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip navigationMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.DataGridView transactionGridView;
        private System.Windows.Forms.Button all;
        private System.Windows.Forms.Button completed;
        private System.Windows.Forms.Button processing;
        private System.Windows.Forms.Button printTransaction;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
    }
}