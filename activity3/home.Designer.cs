namespace activity3
{
    partial class Home
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
            this.label19 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuGridView = new System.Windows.Forms.DataGridView();
            this.navigationMenu.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).BeginInit();
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
            this.navigationMenu.TabIndex = 2;
            this.navigationMenu.Text = "Navigation";
            this.navigationMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
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
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(115, 27);
            this.aboutToolStripMenuItem.Text = "INVENTORY";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Checked = true;
            this.homeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.homeToolStripMenuItem.Enabled = false;
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(73, 27);
            this.homeToolStripMenuItem.Text = "MENU";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.HeheToolStripMenuItem_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(323, 98);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(147, 25);
            this.label19.TabIndex = 20;
            this.label19.Text = "Available Menu";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuPanel.Controls.Add(this.menuGridView);
            this.menuPanel.Location = new System.Drawing.Point(127, 142);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(573, 329);
            this.menuPanel.TabIndex = 21;
            // 
            // menuGridView
            // 
            this.menuGridView.AllowUserToAddRows = false;
            this.menuGridView.AllowUserToDeleteRows = false;
            this.menuGridView.AllowUserToResizeColumns = false;
            this.menuGridView.AllowUserToResizeRows = false;
            this.menuGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menuGridView.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.menuGridView.ColumnHeadersHeight = 29;
            this.menuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.menuGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.menuGridView.Location = new System.Drawing.Point(21, 20);
            this.menuGridView.MultiSelect = false;
            this.menuGridView.Name = "menuGridView";
            this.menuGridView.ReadOnly = true;
            this.menuGridView.RowHeadersWidth = 51;
            this.menuGridView.RowTemplate.Height = 24;
            this.menuGridView.ShowCellToolTips = false;
            this.menuGridView.ShowEditingIcon = false;
            this.menuGridView.ShowRowErrors = false;
            this.menuGridView.Size = new System.Drawing.Size(533, 292);
            this.menuGridView.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.navigationMenu);
            this.MainMenuStrip = this.navigationMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Home_Load);
            this.navigationMenu.ResumeLayout(false);
            this.navigationMenu.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip navigationMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.DataGridView menuGridView;
    }
}