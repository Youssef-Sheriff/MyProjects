using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace College_Management

{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            passAdd.PasswordChar = '*';
            passAdd.MaxLength = 5;
        }
        string username, password;
        const string connectionString = "Data Source=DESKTOP-0RN2EU8;Initial Catalog=College;User ID=omar;Password=computer;";
        string databaseUser = "omar";
        string databasePass = "computer";
        


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void userAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void passAdd_TextChanged(object sender, EventArgs e)
        {
        }

        private void newStudentButton_Click(object sender, EventArgs e)
        {
            username = userAdd.Text.Trim();
            password = passAdd.Text.Trim();
            userAdd.Text = "";
            passAdd.Text = "";
            string query = "";
            if (doctorCheck.Checked)
            {
                query = "INSERT INTO Doctor (Username, Password) VALUES (@username, @password)";
                doctorCheck.Checked = false;
            }
            else if (studentCheck.Checked)
            {
                query = "INSERT INTO Student (Username, Password) VALUES (@username, @password)";
                studentCheck.Checked = false;

            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {
                    connection.Open();
                    // MessageBox.Show("Connection opened successfully!");

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"rows: {rowsAffected}");
                        // int rowsAffected = command.ExecuteNonQuery();
                        // Handle the result...

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }

            }

        }

        private void backAdmin_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            new RegisterForm().Show();
        }
    }
}
