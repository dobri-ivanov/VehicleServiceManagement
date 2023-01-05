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

        private int currentClientId;
        public AddNewVehicle()
        {
            InitializeComponent();
        }

        public AddNewVehicle(Main main, int clientID)
        {
            InitializeComponent();
            currentClientId = clientID;
            FillClientData(clientID);
        }

        private void FillClientData(int clientID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataReader read = (null);
            string query = "SELECT * FROM Clients WHERE ID = '"+clientID+"'";

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
            string query = "SELECT * FROM Clients WHERE PhoneNumber = N'"+phoneNumber+"'";


            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();

            string name = String.Empty;
            string lastName = String.Empty;
            string nickname = String.Empty;

            while (read.Read())
            {
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
    }
}
