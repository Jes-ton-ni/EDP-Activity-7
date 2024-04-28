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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Load user accounts when the form loads
            LoadUserAccounts();

        }

        private void LoadUserAccounts()
        {
            // Clear any existing data in the DataGridView
            accountGridView.Rows.Clear();

            // Query to select all user accounts
            string query = "SELECT username, password, name, contact, email, type, status FROM user";

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
                                    // Get the boolean value of the status column
                                    bool isActive = reader.GetBoolean("status");

                                    // Convert the boolean value to a string representation
                                    string status = isActive ? "Active" : "Inactive";

                                    // Add a new row to the DataGridView
                                    accountGridView.Rows.Add(reader.GetString("username"), reader.GetString("password"), reader.GetString("name"), reader.GetString("contact"), reader.GetString("email"), reader.GetString("type"), status);
                                }
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions that occur during database operation
                MessageBox.Show("Error loading user accounts: " + ex.Message);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            crudFormPanel.Visible = true;
            addSaveBtn.Visible = true;
            editSaveBtn.Visible = false;
            crudLabel.Text = "Add Account";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            crudFormPanel.Visible = false;
            LoadUserAccounts();

            // Clear the TextBoxes
            usernameTxtBx.Clear();
            nameTxtBx.Clear();
            contactTxtBx.Clear();
            emailTxtBx.Clear();
            passTxtBx.Clear();
            typeTxtBx.Clear();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            addSaveBtn.Visible = false;
            editSaveBtn.Visible = true;
            crudLabel.Text = "Edit Account";
            // Check if any row is selected
            if (accountGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = accountGridView.SelectedRows[0];
                crudFormPanel.Visible = true;

                // Populate the TextBoxes with the values of the selected row
                usernameTxtBx.Text = selectedRow.Cells["Username"].Value.ToString();
                nameTxtBx.Text = selectedRow.Cells["Name"].Value.ToString();
                contactTxtBx.Text = selectedRow.Cells["Contact"].Value.ToString();
                emailTxtBx.Text = selectedRow.Cells["email"].Value.ToString();
                passTxtBx.Text = selectedRow.Cells["password"].Value.ToString();
                typeTxtBx.Text = selectedRow.Cells["type"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void addSaveBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxtBx.Text;
            string name = nameTxtBx.Text;
            string contact = contactTxtBx.Text;
            string password = passTxtBx.Text;
            string email = emailTxtBx.Text;
            string type = typeTxtBx.Text;

            try
            {
                // Get MySqlConnection object using the connection string from dbConnection class
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    // Create an SQL INSERT statement
                    string query = "INSERT INTO user (username, password, name, contact, email, type) VALUES (@username, @password, @name, @contact, @email, @type)";

                    // Create a MySqlCommand object
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@contact", contact);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@type", type);

                        // Open the connection
                        connection.Open();

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if the data was successfully added
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data added successfully.");
                            crudFormPanel.Visible = false;
                            LoadUserAccounts();

                            // Clear the TextBoxes
                            usernameTxtBx.Clear();
                            nameTxtBx.Clear();
                            contactTxtBx.Clear();
                            passTxtBx.Clear();
                            emailTxtBx.Clear();
                            typeTxtBx.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add data.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Check if the exception is due to a duplicate username
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                }
                else
                {
                    MessageBox.Show("Error adding data: " + ex.Message);
                }
            }
        }

        private void editSaveBtn_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (accountGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = accountGridView.SelectedRows[0];

                // Get the values from the TextBoxes
                string username = usernameTxtBx.Text;
                string name = nameTxtBx.Text;
                string contact = contactTxtBx.Text;
                string password = passTxtBx.Text;
                string email = emailTxtBx.Text;
                string type = typeTxtBx.Text;

                try
                {
                    // Get MySqlConnection object using the connection string from dbConnection class
                    using (MySqlConnection connection = dbConnection.GetConnection())
                    {
                        // Create an SQL UPDATE statement
                        string query = "UPDATE user SET username = @newUsername, name = @name, contact = @contact, password = @password, email = @email, type = @type WHERE username = @oldUsername";

                        // Create a MySqlCommand object
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            // Add parameters to the command
                            command.Parameters.AddWithValue("@newUsername", username);
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@contact", contact);
                            command.Parameters.AddWithValue("@password", password);
                            command.Parameters.AddWithValue("@email", email);
                            command.Parameters.AddWithValue("@type", type);
                            command.Parameters.AddWithValue("@oldUsername", selectedRow.Cells["Username"].Value.ToString()); // Use the old username for the WHERE clause

                            // Open the connection
                            connection.Open();

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            // Check if the data was successfully updated
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data updated successfully.");
                                LoadUserAccounts();
                                crudFormPanel.Visible = false;
                                usernameTxtBx.Clear();
                                nameTxtBx.Clear();
                                contactTxtBx.Clear();
                                emailTxtBx.Clear();
                                passTxtBx.Clear();
                                typeTxtBx.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update data.");
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error updating data: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (accountGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = accountGridView.SelectedRows[0];

                // Get the username of the selected row
                string username = selectedRow.Cells["Username"].Value.ToString();

                try
                {
                    // Get MySqlConnection object using the connection string from dbConnection class
                    using (MySqlConnection connection = dbConnection.GetConnection())
                    {
                        // Perform the database operation to delete the selected record
                        string query = "DELETE FROM user WHERE username = @username";

                        // Create a MySqlCommand object
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            // Add parameters
                            command.Parameters.AddWithValue("@username", username);

                            // Open the connection
                            connection.Open();

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Remove the selected row from the DataGridView
                                accountGridView.Rows.Remove(selectedRow);
                                MessageBox.Show("Record deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No records deleted.");
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            // Get the search keyword from the TextBox
            string keyword = searchBox.Text.Trim().ToLower();

            // Clear the current selection
            accountGridView.ClearSelection();

            // Filter the DataGridView based on the search keyword
            if (!string.IsNullOrEmpty(keyword))
            {
                // Iterate through each row in the DataGridView
                foreach (DataGridViewRow row in accountGridView.Rows)
                {
                    // Check if the name column contains the search keyword
                    if (row.Cells["name"].Value.ToString().ToLower().Contains(keyword))
                    {
                        // Display the row that matches the search keyword
                        row.Visible = true;
                    }
                    else
                    {
                        // Hide rows that do not match the search keyword
                        row.Visible = false;
                    }
                }
            }
            else
            {
                // Show all rows if the search keyword is empty
                foreach (DataGridViewRow row in accountGridView.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Get MySqlConnection object using the connection string from dbConnection class
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    // Open the connection
                    conn.Open();

                    // Set the status to 0 for the logged-in user
                    string updateSql = "UPDATE user SET status = 0 WHERE username = @username";
                    MySqlCommand updateCmd = new MySqlCommand(updateSql, conn);
                    updateCmd.Parameters.AddWithValue("@username", UserInfo.Username);
                    updateCmd.ExecuteNonQuery();

                    // Navigate to the login form
                    var login = new login();
                    this.Hide();
                    login.Show();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error updating user status: " + ex.Message);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadUserAccounts();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OrderSummary().Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_Inventory().Show();
        }
    }
}
