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
    public partial class SearchClients : Form
    {
        AddNewVehicle addNewVehiclePanel;

        public string connectionString = Main.currentConnectionString;

        public SearchClients()
        {
            InitializeComponent();

        }
        public SearchClients(AddNewVehicle anv)
        {
            InitializeComponent();
            addNewVehiclePanel = anv;
            FillTable();
        }

        private void ButtonCloseApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillTable()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataReader read = (null);
            string query = "SELECT * FROM Clients";

            SqlCommand command = new SqlCommand(query, connection);
            read = command.ExecuteReader();


            int id = -1;
            string name = String.Empty;
            string lastName = String.Empty;
            string phoneNumber = String.Empty;
            string nickname = String.Empty;

            while (read.Read())
            {
                id = int.Parse((read["ID"].ToString()));
                name = (read["FirstName"].ToString());
                lastName = (read["LastName"].ToString());
                phoneNumber = (read["PhoneNumber"].ToString());
                nickname = (read["Nickname"].ToString());
                Client client = new Client(id, name, lastName, phoneNumber, nickname);

                clientBindingSource.Add(client);

            }
            read.Close();
            connection.Close();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string text = TextBoxSearch.Text;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Clients WHERE FirstName LIKE N'%" + text + "%' OR LastName LIKE N'%" + text + "%' OR PhoneNumber LIKE N'%" + text + "%' OR Nickname LIKE N'%" + text + "%';";
            DataGridViewClients.Rows.Clear();


            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();


            int id = 0;
            string name = String.Empty;
            string lastName = String.Empty;
            string phoneNumber = String.Empty;
            string nickname = String.Empty;

            while (read.Read())
            {
                id = int.Parse((read["ID"].ToString()));
                name = (read["FirstName"].ToString());
                lastName = (read["LastName"].ToString());
                phoneNumber = (read["PhoneNumber"].ToString());
                nickname = (read["Nickname"].ToString());
                Client client = new Client(id, name, lastName, phoneNumber, nickname);

                clientBindingSource.Add(client);

            }
            read.Close();
            connection.Close();
        }

        private void DataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            string phoneNumber = string.Empty;
            if (DataGridViewClients.Columns[colIndex].Name == "Get")
            {
                phoneNumber = DataGridViewClients.Rows[rowIndex].Cells[2].Value.ToString();
            }
            addNewVehiclePanel.FillClientsData(phoneNumber);
            this.Close();
        }

        private void Panel_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxSearch_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
