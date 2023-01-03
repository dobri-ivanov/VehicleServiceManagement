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
        public string connectionString = "Data Source=(localdb)\\LocalHost;Initial Catalog=VehicleServiceManagement;Integrated Security=True";
        public SearchVehicle(int id)
        {
            InitializeComponent();
            currentClientId = id;
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
            LabelClientData.Text = currentText;
        }

        public SearchVehicle()
        {
            InitializeComponent();
        }

        private void ButtonCloseApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel_Click(object sender, EventArgs e)
        {

        }

        private void TestLabel_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
