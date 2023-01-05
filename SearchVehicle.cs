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

namespace VehicleServiceManagement
{
    public partial class SearchVehicle : Form
    {
        int currentClientId;
        Main Main;
        public string connectionString = "Data Source=(localdb)\\LocalHost;Initial Catalog=VehicleServiceManagement;Integrated Security=True";
        public SearchVehicle(int clientID, Main main)
        {
            InitializeComponent();
            currentClientId = clientID;
            Main = main;
            Setup();
        }

        private void Setup()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Clients WHERE ID = '" + currentClientId + "'";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();

            string firstName = String.Empty;
            string lastName = String.Empty;
            string phoneNumber = String.Empty;

            while (read.Read())
            {
                firstName = (read["FirstName"].ToString());
                lastName = (read["LastName"].ToString());
                phoneNumber = (read["PhoneNumber"].ToString());
            }
            read.Close();
            connection.Close();
            string currentText = String.Format($"{firstName} {lastName} | {phoneNumber}");
            LabelCurrentClientData.Text = currentText;


            connection.Open();
            //DataGridViewVehicles.Rows.Clear();

            read = (null);
            query = "SELECT * FROM Vehicles WHERE ClientID = '" + currentClientId + "'";

            command = new SqlCommand(query, connection);
            read = command.ExecuteReader();

            string make = String.Empty;
            string model = String.Empty;
            string year = String.Empty;
            string capacity = String.Empty;
            string hp = String.Empty;
            string lp = String.Empty;

            while (read.Read())
            {
                make = (read["Make"].ToString());
                model = (read["Model"].ToString());
                year = (read["Year"].ToString());
                capacity = (read["Capаcity"].ToString());
                hp = (read["HorsePower"].ToString());
                lp = (read["LicensePlate"].ToString());

                Vehicle vehicle = new Vehicle(make, model, year, capacity, hp, lp);

                vehicleBindingSource.Add(vehicle);

            }
            read.Close();
            connection.Close();
        }

        public SearchVehicle()
        {
            InitializeComponent();
        }
        private void ButtonCloseApplication_Click_3(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddNewVehicle addNewVehicle = new AddNewVehicle(Main, currentClientId);
            addNewVehicle.Show();
            this.Close();
            
        }
    }
}
