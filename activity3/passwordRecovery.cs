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
    public partial class passwordRecovery : Form
    {
        public passwordRecovery()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var login = new login();
            this.Hide();
            login.Show();
        }

        private void recoveryButton_Click(object sender, EventArgs e)
        {
            string username = usernameTxtBox.Text;
            string password = passwordTxtBox.Text;

            string myConnectionString = "server=127.0.0.1;uid=root;pwd=0511;database=canteen_db";
            using (MySqlConnection conn = new MySqlConnection(myConnectionString))
            {
                string sql = "SELECT COUNT(*) FROM user WHERE username = @username";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    // Set the parameters
                    cmd.Parameters.AddWithValue("@username", username);

                    try
                    {
                        conn.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 0)
                        {
                            MessageBox.Show("Username not found.");
                            return;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }

                // Update the password in the database
                sql = "UPDATE user SET password = @password WHERE username = @username";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    // Set the parameters
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@username", username);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account Recovery Succesfully!");
                            var login = new login();
                            this.Hide();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("Account Recovery Failed!");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            // Clear the textboxes after saving
            usernameTxtBox.Clear();
            passwordTxtBox.Clear();

        }
    }
}
