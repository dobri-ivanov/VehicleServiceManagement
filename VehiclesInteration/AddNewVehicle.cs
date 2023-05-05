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
        public static bool isOpened = false;

        public string connectionString = Main.currentConnectionString;

        string operation = string.Empty;

        private int currentClientId;
        private string currentlicensePlate;
        Main mainPanel;
        VehicleOptions vehicleOptionsPanel;
        public AddNewVehicle()
        {
            InitializeComponent();
            isOpened = true;
        }

        public AddNewVehicle(Main main, int clientID, string currentOperation)
        {
            InitializeComponent();
            operation = currentOperation;
            SetUp();
            currentClientId = clientID;
            mainPanel = main;
            FillClientData(clientID);
            isOpened = true;
        }

        public AddNewVehicle(VehicleOptions vo, Main main, int clientID, string licensePlate, string currentOperation)
        {
            InitializeComponent();
            operation = currentOperation;
            vehicleOptionsPanel = vo;
            currentClientId = clientID;
            currentlicensePlate = licensePlate;
            mainPanel = main;
            SetUp();
            FillVehicleData(licensePlate);
            FillClientData(clientID);
            isOpened = true;
        }



        public AddNewVehicle(Main main, string currentOperation)
        {
            InitializeComponent();
            operation = currentOperation;
            SetUp();
            mainPanel = main;
            isOpened = true;
        }
        private void FillVehicleData(string licensePlate)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Vehicles WHERE LicensePlate = N'" + licensePlate + "'";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();

            string horsePower = String.Empty;
            string capacity = String.Empty;
            string year = String.Empty;
            string fuel = String.Empty;
            string transmission = String.Empty;
            string make = String.Empty;
            string model = String.Empty;
            string vin = String.Empty;

            while (read.Read())
            {
                horsePower = read["HorsePower"].ToString();
                capacity = read["Capacity"].ToString();
                year = read["Year"].ToString();
                fuel = read["Fuel"].ToString();
                transmission = read["Transmission"].ToString();
                make = read["Make"].ToString();
                model = read["Model"].ToString();
                vin = read["Vin"].ToString();
            }
            read.Close();
            connection.Close();

            TextBoxMake.Text = make;
            TextBoxModel.Text = model;
            TextBoxYear.Text = year;
            TextBoxCapacity.Text = capacity;
            TextBoxFuel.Text = fuel;
            TextBoxHorsePower.Text = horsePower;
            TextBoxTransmission.Text = transmission;
            TextBoxLicensePlate.Text = currentlicensePlate;
            TextBoxVinNumber.Text = vin;
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

        private void SetUp()
        {
            if (operation == "ADD")
            {
                LabelTitle.Text = "ДОБАВЯНЕ НА АВТОМОБИЛ";
            }
            else if (operation == "EDIT")
            {
                LabelTitle.Text = "РЕДАКТИРАНЕ ДАННИ НА АВТОМОБИЛ";
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void ButtonSearchClients_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
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
                    string selectQuery = "SELECT * FROM Vehicles WHERE LicensePlate = N'" + currentLicensePlate + "'";
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
                        string vin = TextBoxVinNumber.Text;

                        string query = "INSERT INTO Vehicles(LicensePlate, HorsePower, Capacity, Year, Fuel, Transmission, ClientID, Make, Model, Vin) " +
                            "VALUES(N'" + licensePlate + "', '" + horsePower + "', '" + capacity + "', '" + year + "', N'" + fuel + "', N'" + transmission + "', '" + currentClientId + "', N'" + make + "', N'" + model + "', '" + vin + "')";

                        command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();

                        mainPanel.AddVehicleNotfication();
                        Exit();
                    }
                    else
                    {

                        Notification.Show(this, $"Вече същестува този автомобил!",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 5000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);

                    }
                    read.Close();
                    connection.Close();
                }
            }
            else if (operation == "EDIT")
            {
                string licensePlate = TextBoxLicensePlate.Text;
                string horsePower = TextBoxHorsePower.Text;
                string capacity = TextBoxCapacity.Text;
                string year = TextBoxYear.Text;
                string fuel = TextBoxFuel.Text;
                string transmission = TextBoxTransmission.Text;
                string make = TextBoxMake.Text;
                string model = TextBoxModel.Text;
                string vin = TextBoxVinNumber.Text;

                SqlConnection connection = new SqlConnection(Main.currentConnectionString);
                connection.Open();

                string query = "UPDATE Vehicles SET LicensePlate = N'" + licensePlate + "', HorsePower = '" + horsePower + "', Capacity = '" + capacity + "', Year = '" + year + "', Fuel = N'" + fuel + "', Transmission = N'" + transmission + "', ClientID = '" + currentClientId + "', Make = N'" + make + "', Model = N'" + model + "', Vin = '" + vin + "' WHERE LicensePlate = N'" + currentlicensePlate + "';";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                mainPanel.EditVehicleNotification($"Информацията е успешно обновена!");
                vehicleOptionsPanel.Close();
                Exit();
            }
        }

        private void Exit()
        {
            isOpened = false;
            this.Close();
        }
        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void LabelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
