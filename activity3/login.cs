using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace activity3
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recover = new passwordRecovery();
            this.Hide();
            recover.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;

            try
            {
                // Get MySqlConnection object using the connection string from dbConnection class
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) from user where username = @username AND password = @password AND type = 'user'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // Set the status to 1 for the logged-in user
                        string updateSql = "UPDATE user SET status = 1 WHERE username = @username";
                        MySqlCommand updateCmd = new MySqlCommand(updateSql, conn);
                        updateCmd.Parameters.AddWithValue("@username", username);
                        updateCmd.ExecuteNonQuery();

                        //MessageBox.Show("You are now logged in");
                        UserInfo.Username = username;
                        //var home = new AdminDashboard();
                        var home = new Home();
                        this.Hide();
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username/password");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void changeType_Click(object sender, EventArgs e)
        {
            admin.Visible = true;
            user.Visible = true;
        }

        private void admin_Click(object sender, EventArgs e)
        {
            logAdmin.Visible = true;
            logUser.Visible = false;

            userLoginBtn.Visible = false;
            adminLoginBtn.Visible = true;

            admin.Visible = false;
            user.Visible = false;
        }

        private void user_Click(object sender, EventArgs e)
        {
            logAdmin.Visible = false;
            logUser.Visible = true;

            userLoginBtn.Visible = true;
            adminLoginBtn.Visible = false;

            admin.Visible = false;
            user.Visible = false;
        }

        private void adminLoginBtn_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;

            try
            {
                // Get MySqlConnection object using the connection string from dbConnection class
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) from user where username = @username AND password = @password AND type = 'admin'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // Set the status to 1 for the logged-in user
                        string updateSql = "UPDATE user SET status = 1 WHERE username = @username";
                        MySqlCommand updateCmd = new MySqlCommand(updateSql, conn);
                        updateCmd.Parameters.AddWithValue("@username", username);
                        updateCmd.ExecuteNonQuery();

                        //MessageBox.Show("You are now logged in");
                        UserInfo.Username = username;
                        var home = new AdminDashboard();
                        //var home = new Home();
                        this.Hide();
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username/password");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void signupBtn_Click(object sender, EventArgs e)
        {
            var signup = new signup();
            this.Hide();
            signup.Show();
        }
    }
}
