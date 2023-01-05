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
    public partial class AddNewVehicle : Form
    {
        public string connectionString = "Data Source=(localdb)\\LocalHost;Initial Catalog=VehicleServiceManagement;Integrated Security=True";

        string operation = string.Empty;
        private int currentClientId;
        Main mainPanel;
        public AddNewVehicle()
        {
            InitializeComponent();
        }

        public AddNewVehicle(Main main, int clientID, string currentOperation)
        {
            InitializeComponent();
            currentClientId = clientID;
            mainPanel = main;
            operation = currentOperation;
            FillClientData(clientID);
        }

        public AddNewVehicle(Main main, string currentOperation)
        {
            InitializeComponent();
            operation = currentOperation;
            mainPanel = main;
        }

        private void FillClientData(int clientID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataReader read = (null);
            string query = "SELECT * FROM Clients WHERE ID = '" + clientID + "'";

            SqlCommand command = new SqlCommand(query, connection);
            read = command.ExecuteReader();

            string name = String.Empty;
            string lastName = String.Empty;
            string phoneNumber = String.Empty;
            string nickname = String.Empty;

            while (read.Read())
            {
                name = (read["FirstName"].ToString());
                lastName = (read["LastName"].ToString());
                phoneNumber = (read["PhoneNumber"].ToString());
                nickname = (read["Nickname"].ToString());

            }
            read.Close();
            connection.Close();

            TextBoxFirstName.Text = name;
            TextBoxLastName.Text = lastName;
            TextBoxPhoneNumber.Text = phoneNumber;
            TextBoxNickname.Text = nickname;
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSearchClients_Click(object sender, EventArgs e)
        {
            SearchClients searchClients = new SearchClients(this);
            searchClients.Show();
        }

        public void FillClientsData(string phoneNumber)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Clients WHERE PhoneNumber = N'" + phoneNumber + "'";


            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();

            string name = String.Empty;
            string lastName = String.Empty;
            string nickname = String.Empty;

            while (read.Read())
            {
                currentClientId = int.Parse(read["ID"].ToString());
                name = (read["FirstName"].ToString());
                lastName = (read["LastName"].ToString());
                nickname = (read["Nickname"].ToString());

            }
            read.Close();
            connection.Close();

            TextBoxFirstName.Text = name;
            TextBoxLastName.Text = lastName;
            TextBoxPhoneNumber.Text = phoneNumber;
            TextBoxNickname.Text = nickname;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (operation == "ADD")
            {
                bool requiredData = true;
                if (TextBoxFirstName.Text.Length == 0)
                {
                    Notification.Show(this, $"Не са въведени данни за собственик!",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 5000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                    requiredData = false;
                }

                if (TextBoxMake.Text.Length == 0 || TextBoxModel.Text.Length == 0 || TextBoxYear.Text.Length == 0 || TextBoxCapacity.Text.Length == 0 || TextBoxHorsePower.Text.Length == 0 || TextBoxFuel.Text.Length == 0 || TextBoxLicensePlate.Text.Length == 0)
                {
                    Notification.Show(this, $"Попълнете всички данни за автомобил!",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 5000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                    requiredData = false;
                }
                if (requiredData)
                {
                    string currentLicensePlate = TextBoxLicensePlate.Text;
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    string selectQuery = "SELECT * FROM Vehicles WHERE LicensePlate = '" + currentLicensePlate + "'";
                    SqlCommand command = new SqlCommand(selectQuery, connection);

                    SqlDataReader read = command.ExecuteReader();
                    if (!read.HasRows)
                    {
                        read.Close();
                        string make = TextBoxMake.Text;
                        string model = TextBoxModel.Text;
                        string transmission = TextBoxTransmission.Text;
                        string fuel = TextBoxFuel.Text;
                        string year = TextBoxYear.Text;
                        string capacity = TextBoxCapacity.Text;
                        string horsePower = TextBoxHorsePower.Text;
                        string licensePlate = TextBoxLicensePlate.Text;

                        connection.Open();
                        string query = "INSERT INTO Vehicles(LicensePlate, HorsePower, Capacity, Year, Fuel, Transmission, ClientID, Make, Model) " +
                            "VALUES(N'" + licensePlate + "', '" + horsePower + "', '" + capacity + "', '" + year + "', N'" + fuel + "', N'" + transmission + "', '" + currentClientId + "', '" + make + "', '" + model + "')";

                        command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();

                        connection.Close();
                        mainPanel.AddVehicleNotfication();
                        this.Close();
                    }
                    else
                    {
                        read.Close();
                        Notification.Show(this, $"Вече същестува този автомобил!",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 5000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);

                    }

                }
            }
        }
    }
}
