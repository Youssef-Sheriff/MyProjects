using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace College_Management
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            userPassTxt.PasswordChar = '*';
            userPassTxt.MaxLength = 5;
        }
        const string connectionString = "Data Source=DESKTOP-0RN2EU8;Initial Catalog=College;User ID=omar;Password=computer;";
        const string ADMIN_PASSWORD = "00000";
        string databaseUser = "omar";
        string databasePass = "computer";
        string username = "";
        string password = "";

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void userPassTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            username = userNameTxt.Text;
            password = userPassTxt.Text;

            userNameTxt.Text = "";
            userPassTxt.Text = "";
            if(adminCheckBox.Checked)
            {
                if (password.Equals(ADMIN_PASSWORD))
                {
                    this.Hide();
                    new AdminForm().Show();
                    
                }
                else
                {
                    MessageBox.Show("Invalid Admin");
                    
                }
                return;

            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "";
                    if (loginButtons.SelectedIndex == 0)
                    {
                        query = "SELECT COUNT(*) FROM Student WHERE Username = @username AND Password = @password";
                    }
                    else if (loginButtons.SelectedIndex == 1)
                    {
                        query = "SELECT COUNT(*) FROM Doctor WHERE Username = @username AND Password = @password";
                    }
                    

                    int count = 0;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        count = (int)command.ExecuteScalar();
                    }

                    if (count > 0)
                    {
                        this.Hide();
                        if (loginButtons.SelectedIndex == 0)
                            new StudentForm().Show();
                        else if (loginButtons.SelectedIndex == 1)
                            new DoctorForm().Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }

        private void adminButton_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(adminCheckBox.Checked)
            {
                userNameTxt.Text = "Admin";
                userNameTxt.Enabled = false;
                loginButtons.SelectedIndex = 2;
                loginButtons.Enabled = false;
            }
            else
            {
                userNameTxt.Text = "";
                userNameTxt.Enabled = true;
                loginButtons.Enabled = true;
            }
                
        }
    }
}
