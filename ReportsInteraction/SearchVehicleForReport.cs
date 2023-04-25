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
    public partial class SearchVehicleForReport : Form
    {
        private AddEditReport AddEditReport;
        public SearchVehicleForReport(AddEditReport addEditReport)
        {
            InitializeComponent();
            FillVehiclesTable(true);
            AddEditReport = addEditReport;
        }

        private void TextBoxSearchVehicles_TextChanged(object sender, EventArgs e)
        {
            string text = TextBoxSearchVehicles.Text;
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();
            string query = "SELECT Vehicles.LicensePlate, Vehicles.HorsePower, Vehicles.Capacity, Vehicles.Year, Vehicles.Fuel, Vehicles.Transmission, Vehicles.Make, Vehicles.Model, Clients.FirstName, Clients.LastName FROM Vehicles INNER JOIN Clients ON Vehicles.ClientID = Clients.ID WHERE LicensePlate LIKE N'%" + text + "%' OR HorsePower LIKE '%" + text + "%' OR Capacity LIKE'%" + text + "%' OR Year LIKE '%" + text + "%' OR Make LIKE '%" + text + "%' OR Model LIKE '%" + text + "%' OR FirstName LIKE N'%" + text + "%' OR LastName LIKE N'%" + text + "%'; ";
            DataGridViewVehicles.Rows.Clear();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();


            string licensePlate = String.Empty;
            string horsePower = String.Empty;
            string capacity = String.Empty;
            string year = String.Empty;
            string fuel = String.Empty;
            string transmission = String.Empty;
            string make = String.Empty;
            string model = String.Empty;
            string clientFirstName = String.Empty;
            string clientLastName = String.Empty;

            while (read.Read())
            {
                licensePlate = read["LicensePlate"].ToString();
                horsePower = read["HorsePower"].ToString();
                capacity = read["Capacity"].ToString();
                year = read["Year"].ToString();
                fuel = read["Fuel"].ToString();
                transmission = read["Transmission"].ToString();
                make = read["Make"].ToString();
                model = read["Model"].ToString();
                clientFirstName = read["FirstName"].ToString() + " " + read["LastName"].ToString();
                clientLastName = read["LastName"].ToString();

                Vehicle vehicle = new Vehicle(licensePlate, horsePower, capacity, year, fuel, transmission, make, model, clientFirstName, clientLastName);

                vehicleBindingSource.Add(vehicle);
            }
            read.Close();
            connection.Close();
        }

        public void FillVehiclesTable(bool isFirst)
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();
            if (!isFirst)
            {
            DataGridViewVehicles.Rows.Clear();
            }

            SqlDataReader read = (null);
            string query = "SELECT Vehicles.LicensePlate, Vehicles.HorsePower, Vehicles.Capacity, Vehicles.Year, Vehicles.Fuel, Vehicles.Transmission, Vehicles.Make, Vehicles.Model, Clients.FirstName, Clients.LastName FROM Vehicles INNER JOIN Clients ON Vehicles.ClientID = Clients.ID;";

            SqlCommand command = new SqlCommand(query, connection);
            read = command.ExecuteReader();


            string licensePlate = String.Empty;
            string horsePower = String.Empty;
            string capacity = String.Empty;
            string year = String.Empty;
            string fuel = String.Empty;
            string transmission = String.Empty;
            string make = String.Empty;
            string model = String.Empty;
            string clientFirstName = String.Empty;
            string clientLastName = String.Empty;

            while (read.Read())
            {
                licensePlate = read["LicensePlate"].ToString();
                horsePower = read["HorsePower"].ToString();
                capacity = read["Capacity"].ToString();
                year = read["Year"].ToString();
                fuel = read["Fuel"].ToString();
                transmission = read["Transmission"].ToString();
                make = read["Make"].ToString();
                model = read["Model"].ToString();
                clientFirstName = read["FirstName"].ToString() + " " + read["LastName"].ToString();
                clientLastName = read["LastName"].ToString();

                Vehicle vehicle = new Vehicle(licensePlate, horsePower, capacity, year, fuel, transmission, make, model, clientFirstName, clientLastName);

                vehicleBindingSource.Add(vehicle);
            }
            read.Close();
            connection.Close();
        }

        private void ButtonRefreshVehicles_Click(object sender, EventArgs e)
        {
            FillVehiclesTable(false);
        }

        private void ButtonCloseApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewVehicles_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            if (DataGridViewVehicles.Columns[colIndex].Name == "GetVehicle")
            {
                if (AreValidCoords(rowIndex, colIndex))
                {
                    DataGridViewVehicles.Rows[rowIndex].Cells[colIndex].Value = Properties.Resources.select_new_hover;
                }

            }
        }

        private bool AreValidCoords(int rowIndex, int colIndex)
        {
            if (rowIndex >= 0 && colIndex >= 0)
            {
                return true;
            }
            return false;
        }

        private void DataGridViewVehicles_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            if (DataGridViewVehicles.Columns[colIndex].Name == "GetVehicle")
            {
                if (AreValidCoords(rowIndex, colIndex))
                {
                    DataGridViewVehicles.Rows[rowIndex].Cells[colIndex].Value = Properties.Resources.select_new;
                }

            }
        }

        private void DataGridViewVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            if (DataGridViewVehicles.Columns[colIndex].Name == "GetVehicle")
            {
                string licensePlate = DataGridViewVehicles[6, rowIndex].Value.ToString();
                AddEditReport.FillVehicleInformation(licensePlate);
                this.Close();
            }
        }
    }
}
