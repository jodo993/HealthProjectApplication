using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HealthApplication
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Establish a connection with the database
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\josep\Desktop\HealthApplication\HealthApplication\userInformation.mdf;Integrated Security=True");

            // Verify data to see if there is a match
            SqlDataAdapter sda = new SqlDataAdapter("Select Username From RegistrationTable where Username='" + usernameTextBox.Text + "' and Password='" + passwordTextBox.Text + "'", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                MainHome homeForm = new MainHome(dt.Rows[0][0].ToString());
                homeForm.ShowDialog();
            }
            else
                MessageBox.Show("Username or Password does not match. Please try again.");
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerMainButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registerForm = new RegistrationForm();

            registerForm.ShowDialog();
        }

        private void manageAccountButton_Click(object sender, EventArgs e)
        {

        }
    }
}
