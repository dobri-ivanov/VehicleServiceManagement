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
    public partial class ReportsSearch : Form
    {
        private Main Main;
        private VehicleOptions VO;
        private string CurrentLicensePlate;
        public ReportsSearch(Main main, VehicleOptions vo, string licensePlate)
        {
            VO = vo;
            Main = main;
            CurrentLicensePlate = licensePlate;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadTitle();
            FillTable();
        }

        private void LoadTitle()
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            string query =
                "SELECT Make, Model, Year, Capacity, HorsePower " +
                "FROM Vehicles " +
                "WHERE LicensePlate = N'" + CurrentLicensePlate + "' ";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            string make = String.Empty;
            string model = String.Empty;
            string year = String.Empty;
            string capacity = String.Empty;
            string horsePower = String.Empty;

            while (reader.Read())
            {
                make = reader["Make"].ToString();
                model = reader["Model"].ToString();
                year = reader["Year"].ToString();
                capacity = reader["Capacity"].ToString();
                horsePower = reader["HorsePower"].ToString();
            }
            reader.Close();
            connection.Close();

            string text = make + " " + model + " " + year + " " + capacity + " " + year + "hp (" + CurrentLicensePlate + ")";
            TextBoxTitle.Text = text;
        }

        private void FillTable()
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();
            RefreshTable();

            SqlDataReader read = (null);
            string query =
                "SELECT r.ID, r.Title, r.CreationDate, v.LicensePlate " +
                "FROM Reports AS r " +
                "JOIN Vehicles AS v ON r.VehicleID = v.ID " +
                "WHERE LicensePlate = N'" + CurrentLicensePlate + "' " +
                "ORDER BY CreationDate DESC";

            SqlCommand command = new SqlCommand(query, connection);
            read = command.ExecuteReader();

            int id = 0;
            string title = String.Empty;
            string creationDate = String.Empty;
            string licensePlate = String.Empty;

            while (read.Read())
            {
                id = int.Parse(read["ID"].ToString());
                title = read["Title"].ToString();
                string date = read["CreationDate"].ToString();
                creationDate = date.Substring(0, 10);
                licensePlate = read["LicensePlate"].ToString();

                Report report = new Report(id, title, creationDate, licensePlate);

                reportBindingSource.Add(report);
            }
            read.Close();
            connection.Close();
        }
        private void RefreshTable()
        {
            while (DataGridViewRaports.RowCount > 0)
            {
                DataGridViewRaports.Rows.RemoveAt(0);
            }
        }

        private void ButtonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxSearchReport_TextChanged(object sender, EventArgs e)
        {
            string text = TextBoxSearchReport.Text;
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();
            RefreshTable();

            SqlDataReader read = (null);
            string query =
                "SELECT r.ID, r.Title, r.CreationDate, v.LicensePlate " +
                "FROM Reports AS r " +
                "JOIN Vehicles AS v ON r.VehicleID = v.ID " +
                "WHERE LicensePlate = N'" + CurrentLicensePlate + "' AND " +
                "(r.Title LIKE N'%" + text + "%' " +
                "OR r.CreationDate LIKE N'%" + text + "%' " +
                "OR r.ID LIKE N'%" + text + "%' " +
                "OR r.WorkPrice LIKE N'%" + text + "%') " +
                "ORDER BY CreationDate DESC";

            SqlCommand command = new SqlCommand(query, connection);
            read = command.ExecuteReader();

            int id = 0;
            string title = String.Empty;
            string creationDate = String.Empty;
            string licensePlate = String.Empty;

            while (read.Read())
            {
                id = int.Parse(read["ID"].ToString());
                title = read["Title"].ToString();
                string date = read["CreationDate"].ToString();
                creationDate = date.Substring(0, 10);
                licensePlate = read["LicensePlate"].ToString();

                Report report = new Report(id, title, creationDate, licensePlate);

                reportBindingSource.Add(report);
            }
            read.Close();
            connection.Close();
        }

        private void DataGridViewRaports_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            if (DataGridViewRaports.Columns[colIndex].Name == "GetReport")
            {
                if (AreValidCoords(rowIndex, colIndex))
                {
                    DataGridViewRaports.Rows[rowIndex].Cells[colIndex].Value = Properties.Resources.select_new_hover;
                }
            }
        }

        private void DataGridViewRaports_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            if (DataGridViewRaports.Columns[colIndex].Name == "GetReport")
            {
                if (AreValidCoords(rowIndex, colIndex))
                {
                    DataGridViewRaports.Rows[rowIndex].Cells[colIndex].Value = Properties.Resources.select_new;
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

        private void DataGridViewRaports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            if (DataGridViewRaports.Columns[colIndex].Name == "GetReport")
            {
                int id = int.Parse(DataGridViewRaports.Rows[rowIndex].Cells[0].Value.ToString());
                string title = DataGridViewRaports.Rows[rowIndex].Cells[1].Value.ToString();
                string licensePlate = DataGridViewRaports.Rows[rowIndex].Cells[2].Value.ToString();
                string date = DataGridViewRaports.Rows[rowIndex].Cells[3].Value.ToString();

                VO.Close();
                this.Close();
                Main.LoadReport(id, title, licensePlate, date);
            }
        }

        private void ButtonCreateReport_Click(object sender, EventArgs e)
        {
            Main.CreateNewReport(CurrentLicensePlate);
            VO.Close();
            this.Close();
        }
    }
}
