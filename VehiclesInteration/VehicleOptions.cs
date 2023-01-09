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

namespace VehicleServiceManagement
{
    public partial class VehicleOptions : Form
    {
        private string currentLicensePlate;
        private Main mainPanel;

        public object AddEditVehicle { get; private set; }

        public VehicleOptions()
        {
            InitializeComponent();
        }
        public VehicleOptions(string licensePlate, Main main)
        {
            InitializeComponent();
            mainPanel = main;
            currentLicensePlate = licensePlate;
            LabelTitle.Text = currentLicensePlate;
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
        }

        private void Panel_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCloseApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();
            string query = "SELECT * FROM Vehicles WHERE LicensePlate = '"+currentLicensePlate+"';";


            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();

            string make = String.Empty;
            string model = String.Empty;

            while (read.Read())
            {
                make = read["Make"].ToString();
                model = read["Model"].ToString();

            }
            read.Close();
            connection.Close();
            string text = $"Сигурни ли сте, че искате да изтриете автомобил:{Environment.NewLine}{make} {model} {currentLicensePlate}";



            AlertBoxDeleteVehicle alertBoxDeleteVehicle = new AlertBoxDeleteVehicle();
            
            alertBoxDeleteVehicle.ShowData(text, this);
        }
        public void DeleteVehicle()
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();
            string query = "DELETE FROM Vehicles WHERE LicensePlate = '" + currentLicensePlate + "';";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            mainPanel.FillVehiclesTable();
            this.Close();
        }
    }
}
