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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void passLabel_Click(object sender, EventArgs e)
        {

        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var login = new login();
            this.Hide();
            login.Show();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=0511;database=canteen_db";

            // Create a MySqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                try
                {
                    // Open the connection
                    connection.Open();

                    // Check if password and confirm password match
                    if (confirmpass.Text != confirmpass.Text)
                    {
                        MessageBox.Show("Password and Confirm Password do not match. Please try again.");
                        return; // Exit the method to prevent further execution
                    }

                    // Check if password is empty
                    if (string.IsNullOrEmpty(confirmpass.Text))
                    {
                        MessageBox.Show("Password cannot be empty. Please enter a password.");
                        return; // Exit the method to prevent further execution
                    }

                    // SQL command to check if the user exists
                    string checkUserSql = "SELECT COUNT(*) FROM user WHERE username = @username";

                    // Create a MySqlCommand object to check if the user exists
                    using (MySqlCommand checkUserCmd = new MySqlCommand(checkUserSql, connection))
                    {
                        // Set parameter value for username
                        checkUserCmd.Parameters.AddWithValue("@username", username.Text);

                        // Execute the command to check if the user exists
                        int userCount = Convert.ToInt32(checkUserCmd.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different username.");
                            return; // Exit the method to prevent further execution
                        }
                    }

                    // SQL command to insert data into the database
                    string sql = "INSERT INTO user (username, password) VALUES (@value1, @value2)";

                    // Create a MySqlCommand object
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        // Set parameter values from textboxes
                        cmd.Parameters.AddWithValue("@value1", username.Text);
                        cmd.Parameters.AddWithValue("@value2", password.Text);
                        cmd.Parameters.AddWithValue("@value3", confirmpass.Text);

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            username.Clear();
                            password.Clear();
                            confirmpass.Clear();
                            MessageBox.Show("You have successfully signed up!");
                            var login = new login();
                            this.Hide();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("No data inserted.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void goToLogin_Click(object sender, EventArgs e)
        {
            var login = new login();
            this.Hide();
            login.Show();
        }
    }
}
