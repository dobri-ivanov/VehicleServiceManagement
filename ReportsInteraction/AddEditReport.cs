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
        public int currentVehicleId;
        public int currentReportId;
        private Main Main;
        public AddEditReport(string function, Main main)
        {
            Main = main;
            Function = function;
            InitializeComponent();
            Configure();
        }

        public AddEditReport(string function, Main main, int ReportId)
        {
            currentReportId = ReportId;
            Main = main;
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

                CreateNewReport();
            }
            else if (Function == "EDIT")
            {
                LabelHeader.Text = "РЕДАКТИРАНЕ НА РЕМОНТ";
                ButtonSave.Text = "ЗАПАЗИ";

                LoadReport();
            }
        }

        private void LoadReport()
        {

            SqlConnection connection;
            SqlCommand command;

            connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            string query =
                "SELECT * " +
                "FROM Reports " +
                "WHERE ID = '" + currentReportId + "'";

            command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            string title = string.Empty;
            DateTime date = new DateTime();
            int vehicleID = 0;
            decimal workPrice = 0;

            while (reader.Read())
            {
                title = reader["Title"].ToString();
                date = DateTime.Parse(reader["CreationDate"].ToString());
                vehicleID = int.Parse(reader["VehicleID"].ToString());
                workPrice = decimal.Parse(reader["WorkPrice"].ToString());
            }

            reader.Close();

            string query2 =
                "SELECT LicensePlate " +
                "FROM Vehicles " +
                "WHERE ID = '" + vehicleID + "'";

            command = new SqlCommand(query2, connection);
            reader = command.ExecuteReader();

            string licensePlate = string.Empty;

            while (reader.Read())
            {
                licensePlate = reader["LicensePlate"].ToString();
            }

            reader.Close();
            connection.Close();

            TextBoxTitle.Text = title;
            TextBoxWorkPrice.Text = workPrice.ToString();
            dateTimePicker1.Value = date;
            FillVehicleInformation(licensePlate);
            FillContentTable(currentReportId);
        }

        private void FillContentTable(int currentReportId)
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();
            SqlDataReader read = (null);
            string query = "SELECT * " +
                "FROM ReportContents " +
                "WHERE ReportID = '" + currentReportId + "'";

            SqlCommand command = new SqlCommand(query, connection);
            read = command.ExecuteReader();


            string title = String.Empty;
            decimal quantity = 0;
            decimal price = 0;

            DataGridViewCurerntReportContent.DataSource = null;
            DataGridViewCurerntReportContent.Rows.Clear();
            DataGridViewCurerntReportContent.DataSource = reportContentSource;

            while (read.Read())
            {
                title = (read["Title"].ToString());
                quantity = decimal.Parse(read["Quantity"].ToString());
                price = decimal.Parse(read["Price"].ToString());
                decimal totalPrice = decimal.Parse((quantity * price).ToString("f2"));
                ReportContent reportContent = new ReportContent(title, quantity, price, totalPrice);

                reportContentSource.Add(reportContent);
            }
            read.Close();
            connection.Close();
        }

        private void CreateNewReport()
        {
            SqlConnection connection;
            SqlCommand command;

            connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            string query =
                "INSERT Reports " +
                "DEFAULT VALUES";

            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            string query2 =
                "SELECT TOP(1) ID " +
                "FROM Reports " +
                "ORDER BY ID DESC";

            command = new SqlCommand(query2, connection);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            currentReportId = int.Parse(reader["ID"].ToString());
            connection.Close();
        }

        public void FillVehicleInformation(string licensePlate)
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();
            string query =
                "SELECT * " +
                "FROM Vehicles " +
                "WHERE LicensePlate = '" + licensePlate + "'";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();

            string make = String.Empty;
            string model = String.Empty;
            string year = String.Empty;
            string capacity = String.Empty;
            string horsePower = String.Empty;

            while (read.Read())
            {
                currentVehicleId = int.Parse(read["ID"].ToString());
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
            if (Function == "ADD")
            {
                DeleteCurrentReport();
            }
            this.Close();
        }

        private void DeleteCurrentReport()
        {
            SqlConnection connection;
            SqlCommand command;

            connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            string query =
                "DELETE FROM Reports " +
                "WHERE ID = '" + currentReportId + "'";

            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveReportChanges();
        }

        private void SaveReportChanges()
        {

            string notificationText = string.Empty;
            if (currentVehicleId == 0)
            {
                notificationText = "Моля изберете автомобил!";
            }
            else if (string.IsNullOrEmpty(TextBoxTitle.Text) || string.IsNullOrWhiteSpace(TextBoxTitle.Text))
            {
                notificationText = "Моля въведете заглавие!";
            }
            else if (string.IsNullOrEmpty(TextBoxWorkPrice.Text) || string.IsNullOrWhiteSpace(TextBoxWorkPrice.Text))
            {
                notificationText = "Моля въведете цена за труд!";
            }

            if (!string.IsNullOrEmpty(notificationText))
            {
                Notification.Show(this, $"{notificationText}",
                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 5000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                return;
            }

            string title = TextBoxTitle.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            decimal workPrice = decimal.Parse(TextBoxWorkPrice.Text.ToString());

            SqlConnection connection;
            SqlCommand command;

            connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            string query =
                "UPDATE Reports " +
                "SET " +
                "Title = N'" + title + "', " +
                "CreationDate = '" + date + "', " +
                "VehicleID = '" + currentVehicleId + "', " +
                "WorkPrice = '" + workPrice + "' " +
                "WHERE ID = '" + currentReportId + "'";

            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            string query2 =
                "SELECT LicensePlate " +
                "FROM Vehicles " +
                "WHERE ID = '" + currentVehicleId + "'";
            command = new SqlCommand(query2, connection);
            SqlDataReader reader = command.ExecuteReader();

            string licensePlate;
            reader.Read();
            licensePlate = reader["LicensePlate"].ToString();
            reader.Close();
            connection.Close();


            Main.ReportNotification(Function, currentReportId, title, licensePlate, date);
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void reportContentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void DataGridViewReportContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridViewCurerntReportContent_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            if (DataGridViewCurerntReportContent.Columns[colIndex].Name == "Get")
            {
                if (AreValidCoords(rowIndex, colIndex))
                {
                    DataGridViewCurerntReportContent.Rows[rowIndex].Cells[colIndex].Value = Properties.Resources.dots_new_hover;
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

        private void DataGridViewCurerntReportContent_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            if (DataGridViewCurerntReportContent.Columns[colIndex].Name == "Get")
            {
                if (AreValidCoords(rowIndex, colIndex))
                {
                    DataGridViewCurerntReportContent.Rows[rowIndex].Cells[colIndex].Value = Properties.Resources.dots_new;
                }
            }
        }
    }
}
