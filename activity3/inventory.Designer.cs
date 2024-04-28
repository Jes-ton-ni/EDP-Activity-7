namespace activity3
{
    partial class inventory
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
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label18 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.stocksGridView = new System.Windows.Forms.DataGridView();
            this.menuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navigationMenu.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocksGridView)).BeginInit();
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
            this.navigationMenu.TabIndex = 3;
            this.navigationMenu.Text = "Navigation";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(87, 27);
            this.salesToolStripMenuItem.Text = "PROFILE";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Enabled = false;
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(115, 27);
            this.aboutToolStripMenuItem.Text = "INVENTORY";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(73, 27);
            this.homeToolStripMenuItem.Text = "HOME";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(315, 96);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(153, 25);
            this.label18.TabIndex = 36;
            this.label18.Text = "Availabe Stocks";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuPanel.Controls.Add(this.stocksGridView);
            this.menuPanel.Location = new System.Drawing.Point(127, 142);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(573, 390);
            this.menuPanel.TabIndex = 37;
            // 
            // stocksGridView
            // 
            this.stocksGridView.AllowUserToAddRows = false;
            this.stocksGridView.AllowUserToDeleteRows = false;
            this.stocksGridView.AllowUserToResizeColumns = false;
            this.stocksGridView.AllowUserToResizeRows = false;
            this.stocksGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stocksGridView.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.stocksGridView.ColumnHeadersHeight = 29;
            this.stocksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.stocksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuName,
            this.stocks});
            this.stocksGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.stocksGridView.Location = new System.Drawing.Point(22, 27);
            this.stocksGridView.MultiSelect = false;
            this.stocksGridView.Name = "stocksGridView";
            this.stocksGridView.ReadOnly = true;
            this.stocksGridView.RowHeadersWidth = 51;
            this.stocksGridView.RowTemplate.Height = 24;
            this.stocksGridView.ShowCellToolTips = false;
            this.stocksGridView.ShowEditingIcon = false;
            this.stocksGridView.ShowRowErrors = false;
            this.stocksGridView.Size = new System.Drawing.Size(533, 342);
            this.stocksGridView.TabIndex = 0;
            this.stocksGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stocksGridView_CellContentClick);
            // 
            // menuName
            // 
            this.menuName.HeaderText = "Menu";
            this.menuName.MinimumWidth = 6;
            this.menuName.Name = "menuName";
            this.menuName.ReadOnly = true;
            // 
            // stocks
            // 
            this.stocks.HeaderText = "Stocks";
            this.stocks.MinimumWidth = 6;
            this.stocks.Name = "stocks";
            this.stocks.ReadOnly = true;
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.navigationMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inventory";
            this.Load += new System.EventHandler(this.inventory_Load);
            this.navigationMenu.ResumeLayout(false);
            this.navigationMenu.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stocksGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip navigationMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.DataGridView stocksGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocks;
    }
}