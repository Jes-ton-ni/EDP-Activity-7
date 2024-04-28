using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activity3
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void HeheToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Clear any existing data in the DataGridView
            menuGridView.Rows.Clear();

            // Define columns if not already defined
            if (menuGridView.Columns.Count == 0)
            {
                menuGridView.Columns.Add("ProductName", "Product Name");
                menuGridView.Columns.Add("Description", "Description");
                menuGridView.Columns.Add("Price", "Price");
            }

            // Continue with your existing code to populate the DataGridView
            // Query to select all products
            string query = "SELECT ProductName, Description, Price FROM products";

            try
            {
                // Get MySqlConnection object using the connection string from dbConnection class
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    // Create a MySqlCommand object
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the query and retrieve the data
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if there are rows in the result set
                            if (reader.HasRows)
                            {
                                // Loop through each row in the result set
                                while (reader.Read())
                                {
                                    // Retrieve values from the reader
                                    string productName = reader.GetString("ProductName");
                                    string description = reader.GetString("Description");
                                    decimal price = reader.GetDecimal("Price");

                                    // Add a new row to the DataGridView
                                    menuGridView.Rows.Add(productName, description, price);
                                }
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions that occur during database operation
                MessageBox.Show("Error fetching products: " + ex.Message);
            }

            // Set the DefaultCellStyle.WrapMode for the Description column
            menuGridView.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Set the AutoSizeRowsMode of the DataGridView
            menuGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inventory = new inventory();
            this.Hide();
            inventory.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var profile = new profile();
            this.Hide();
            profile.Show();
        }
    }
}
