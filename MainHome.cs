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
    public partial class MainHome : Form
    {
        //DataSet dataSet = new DataSet();
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\josep\Desktop\HealthApplication\HealthApplication\userInformation.mdf;Integrated Security=True");
        public MainHome(string FirstName)
        {
            InitializeComponent();
            loggedInAsLabel.Text = FirstName;        // Show who is logged on 
        }

        private void nutritionalFactButton_Click(object sender, EventArgs e)
        {
            NutritionForm nutritionAndMineral = new NutritionForm();
            nutritionAndMineral.ShowDialog();
        }

        private void planMyMealButton_Click(object sender, EventArgs e)
        {
            MealPlanForm mealPlan = new MealPlanForm();
            mealPlan.ShowDialog();
        }

        private void calculateBmiButton_Click(object sender, EventArgs e)
        {
            //connection.Open();
            //SqlDataAdapter dataAdapter = new SqlDataAdapter();
            //dataAdapter.SelectCommand = new SqlCommand("Select Height From RegistrationTable", connection);
            //dataAdapter.Fill(dataSet);

            //Int32 userHeight = 0;
            //string sql = "INSERT INTO Production.Pr"


        }

        private void exitMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOffMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 mainPage = new Form1();

            mainPage.ShowDialog();
        }
    }
}
