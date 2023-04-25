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

namespace VehicleServiceManagement.ReportsInteraction
{
    public partial class AddEditReport : Form
    {
        public string Function;
        public string currentLicensePlate;
        public AddEditReport(string function)
        {
            Function = function;
            InitializeComponent();
            Configure();
        }

        private void Configure()
        {
            if (Function == "ADD")
            {
                LabelHeader.Text = "СЪЗДАВАНЕ НА РЕМОНТ";
                ButtonSave.Text = "СЪЗДАЙ";
            }
        }

        public void FillVehicleInformation(string licensePlate)
        {
            currentLicensePlate = licensePlate;

            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();
            string query = 
                "SELECT * " +
                "FROM Vehicles " +
                "WHERE LicensePlate = '"+ licensePlate + "'";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();

            string make = String.Empty;
            string model = String.Empty;
            string year = String.Empty;
            string capacity = String.Empty;
            string horsePower = String.Empty;

            while (read.Read())
            {
                licensePlate = read["LicensePlate"].ToString();
                horsePower = read["HorsePower"].ToString();
                capacity = read["Capacity"].ToString();
                year = read["Year"].ToString();
                make = read["Make"].ToString();
                model = read["Model"].ToString();
            }
            read.Close();
            connection.Close();

            string vehicle = make + " " + model + " " + year;
            string modification = capacity + " " + horsePower + " hp";

            TextBoxVehicle.Text = vehicle;
            TextBoxModification.Text = modification;
        }

        private void ButtonSearchClients_Click(object sender, EventArgs e)
        {
            SearchVehicleForReport searchVehicleForReport = new SearchVehicleForReport(this);
            searchVehicleForReport.ShowDialog();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxWorkPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridViewCurerntReportContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
