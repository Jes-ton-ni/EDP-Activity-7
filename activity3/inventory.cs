using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activity3
{
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inventory_Load(object sender, EventArgs e)
        {
            // Clear any existing data in the DataGridView
            stocksGridView.Rows.Clear();

            // Query to select all user accounts
            string query = "SELECT ProductName, Quantity FROM productavailable";

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

                                    // Convert Quantity from Decimal to string
                                    string quantity = reader.GetDecimal("Quantity").ToString();

                                    // Add a new row to the DataGridView
                                    stocksGridView.Rows.Add(productName, quantity);
                                }
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions that occur during database operation
                MessageBox.Show("Error fetching inventory: " + ex.Message);
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var home = new Home();
            this.Hide();
            home.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var profile = new profile();
            this.Hide();
            profile.Show();
        }

        private void stocksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
