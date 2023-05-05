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
using VehicleServiceManagement.AlertBoxes;
using VehicleServiceManagement.ReportsInteraction;

namespace VehicleServiceManagement
{
    public partial class VehicleOptions : Form
    {
        public static bool isOpened = false;

        private string currentLicensePlate;
        private Main mainPanel;
        private string currentMake;
        private string currentModel;

        public object AddEditVehicle { get; private set; }

        public VehicleOptions()
        {
            InitializeComponent();
            isOpened = true;
        }
        public VehicleOptions(string licensePlate, Main main)
        {
            InitializeComponent();
            mainPanel = main;
            currentLicensePlate = licensePlate;
            LabelTitle.Text = currentLicensePlate;
            isOpened = true;
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();
            string query = "SELECT * FROM Vehicles WHERE LicensePlate = N'" + currentLicensePlate + "';";


            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();

            int clientId = -1;

            while (read.Read())
            {
                clientId = int.Parse(read["ClientId"].ToString());

            }
            read.Close();
            connection.Close();

            if (!AddNewVehicle.isOpened)
            {
                AddNewVehicle addNewVehicle = new AddNewVehicle(this, mainPanel, clientId, currentLicensePlate, "EDIT");
                addNewVehicle.Show();
            }
            Exit();
        }

        private void ButtonCloseApplication_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();
            string query = "SELECT * FROM Vehicles WHERE LicensePlate = N'"+currentLicensePlate+"';";


            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();

            currentMake = String.Empty;
            currentModel = String.Empty;

            while (read.Read())
            {
                currentMake = read["Make"].ToString();
                currentModel = read["Model"].ToString();

            }
            read.Close();
            connection.Close();
            string text = $"Сигурни ли сте, че искате да изтриете автомобил:{Environment.NewLine}{currentMake} {currentModel} {currentLicensePlate}";



            AlertBoxDeleteVehicle alertBoxDeleteVehicle = new AlertBoxDeleteVehicle();
            alertBoxDeleteVehicle.ShowData(text, this);

            Exit();
        }
        public void DeleteVehicle()
        {
            try
            {
                SqlConnection connection = new SqlConnection(Main.currentConnectionString);
                connection.Open();

                string query = "DELETE FROM Vehicles WHERE LicensePlate = N'" + currentLicensePlate + "';";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                mainPanel.FillVehiclesTable();
                mainPanel.DeleteVehicleNotification($"Успешно изтрит автомобил: {currentMake} {currentModel} {currentLicensePlate}");
                Exit();
            }
            catch (Exception)
            {
                mainPanel.DeleteVehicleNotification2($"Автомобилът не може да бъде изтрит, защото има съществуващи ремонти!");
            }        
            
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            ReportsSearch reportsSearch = new ReportsSearch(mainPanel, currentLicensePlate);
            reportsSearch.ShowDialog();
            Exit();
        }

        private void Exit()
        {
            this.Close();
            isOpened = false;
        }
    }
}
