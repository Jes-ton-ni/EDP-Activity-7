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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace activity3
{
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        private void profile_Load(object sender, EventArgs e)
        {
            LoadUserData();
            // Load transaction history
            LoadTransactionHistory();
        }

        private void LoadUserData()
        {
            // Get the username of the currently logged-in user
            string username = UserInfo.Username;
            usernameTextBox.Text = username;

            // Query to select the name, contact, and email of the user
            string query = "SELECT name, contact, email, password FROM user WHERE username = @username";

            try
            {
                // Get MySqlConnection object using the connection string from dbConnection class
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    // Create a MySqlCommand object
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter for the username
                        command.Parameters.AddWithValue("@username", username);

                        // Open the connection
                        connection.Open();

                        // Execute the query and retrieve the data
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if there are rows in the result set
                            if (reader.Read())
                            {
                                // Retrieve the values of name, contact, and email from the reader
                                string name = reader.GetString("name");
                                string contact = reader.GetString("contact");
                                string email = reader.GetString("email");
                                string password = reader.GetString("password");

                                // Display the retrieved values in the respective labels
                                nameLabel.Text = name;
                                contactTextBox.Text = contact;
                                emailTextBox.Text = email;

                                textBoxUsername.Text = username;
                                textBoxName.Text = name;
                                textBoxContact.Text = contact;
                                textBoxEmail.Text = email;
                                textBoxPassword.Text = password;
                            }
                            else
                            {
                                // If no data was found for the user, display an error message or handle it accordingly
                                MessageBox.Show("User data not found.");
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions that occur during database operation
                MessageBox.Show("Error fetching user data: " + ex.Message);
            }
        }

        private void LoadTransactionHistory()
        {
            // Query to select columns from orders table and username from user table
            string query = "SELECT * FROM transaction_history_view WHERE username = @username";

            try
            {
                // Get MySqlConnection object using the connection string from dbConnection class
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    // Create a MySqlCommand object
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter for the username
                        command.Parameters.AddWithValue("@username", usernameTextBox.Text);

                        // Open the connection
                        connection.Open();

                        // Create a DataTable to store the results
                        DataTable dataTable = new DataTable();

                        // Load the data from the command into the DataTable
                        dataTable.Load(command.ExecuteReader());

                        // Bind the DataTable to the DataGridView
                        transactionGridView.DataSource = dataTable;
                    }
                }

                // Set DataGridView properties
                transactionGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                transactionGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions that occur during database operation
                MessageBox.Show("Error fetching transaction history: " + ex.Message);
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var home = new Home();
            this.Hide();
            home.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inventory = new inventory();
            this.Hide();
            inventory.Show();
        }

        private void editProfileLabel_Click(object sender, EventArgs e)
        {            
            aboutPanel.Visible = false;
            editPanel.Visible = true;
            transactionPanel.Visible = false;

            aboutLabel.Enabled = true;
            about_underline.Visible = false;

            editProfileLabel.Enabled = false;
            edit_underline.Visible = true;

            transLabel.Enabled = true;
            transaction_underline.Visible = false;

        }

        private void aboutLabel_Click(object sender, EventArgs e)
        {
            aboutPanel.Visible = true;
            editPanel.Visible = false;
            transactionPanel.Visible = false;

            aboutLabel.Enabled = false;
            about_underline.Visible = true;

            editProfileLabel.Enabled = true;
            edit_underline.Visible = false;

            transLabel.Enabled = true;
            transaction_underline.Visible = false;

        }

        private void transLabel_Click(object sender, EventArgs e)
        {
            aboutPanel.Visible = false;
            editPanel.Visible = false;
            transactionPanel.Visible = true;

            aboutLabel.Enabled = true;
            about_underline.Visible = false;

            editProfileLabel.Enabled = true;
            edit_underline.Visible = false;

            transLabel.Enabled = false;
            transaction_underline.Visible = true;
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
                }

                // Navigate to the login form
                var login = new login();
                this.Hide();
                login.Show();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error logging out: " + ex.Message);
            }
        }

        private void saveEditButton_Click(object sender, EventArgs e)
        {
            // Retrieve values from text boxes
            string newUsername = textBoxUsername.Text;
            string newName = textBoxName.Text;
            string newContact = textBoxContact.Text;
            string newEmail = textBoxEmail.Text;
            string newPassword = textBoxPassword.Text;

            try
            {
                // Get MySqlConnection object using the connection string from dbConnection class
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    // Query to update the user table
                    string query = "UPDATE user SET username = @newUsername, name = @newName, contact = @newContact, email = @newEmail, password = @newPassword WHERE username = @username";

                    // Create a MySqlCommand object
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters for the new values
                        command.Parameters.AddWithValue("@newUsername", newUsername);
                        command.Parameters.AddWithValue("@newName", newName);
                        command.Parameters.AddWithValue("@newContact", newContact);
                        command.Parameters.AddWithValue("@newEmail", newEmail);
                        command.Parameters.AddWithValue("@newPassword", newPassword);

                        // Add parameter for the current username
                        command.Parameters.AddWithValue("@username", UserInfo.Username);

                        // Open the connection
                        connection.Open();

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if the data was successfully updated
                        if (rowsAffected > 0)
                        {
                            UserInfo.Username = newUsername;
                            MessageBox.Show("User details updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No changes were made.");
                        }
                    }
                }

                // Refresh user data
                LoadUserData();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error updating user details: " + ex.Message);
            }
        }

    }
}
