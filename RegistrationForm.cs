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
    public partial class RegistrationForm : Form
    {
        // Open connection with database
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\josep\Desktop\HealthApplication\HealthApplication\userInformation.mdf;Integrated Security=True");
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void signupRegistrationButton_Click(object sender, EventArgs e)
        {
            // Open the connection
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();            // Create the command
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into RegistrationTable values('"+usernameRegistrationTextBox.Text+"','"+passwordRegistrationTextBox.Text+"','"+firstnameRegistrationTextBox.Text+"','"+lastnameRegistrationTextBox.Text+"','"+heightRegistrationTextBox.Text+"','"+weightRegistrationTextBox.Text+"','"+ageRegistrationTextBox.Text+"','"+genderRegistrationTextBox.Text+"')";
            cmd.ExecuteNonQuery();
            connection.Close();             // Close the connection

            // Let user know that sign up was successful
            MessageBox.Show("Thank you! Registration was successful!");
        }

        private void quitRegistrationButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
