using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleServiceManagement.Print
{
    public partial class ReportPreview : Form
    {
        private int currentReportID;
        private string currentLicensePlate;
        public ReportPreview(int reportID)
        {
            currentReportID = reportID;
            InitializeComponent();
            LoadReport();
        }

        private void LoadReport()
        {
            GetVehicleLicensePlate();
            TextBoxOwner.Text = GetOwnerInformation(currentLicensePlate);
            TextBoxVehicle.Text = GetVehicleInformation(currentLicensePlate);
            TextBoxWorkPrice.Text = GetReportWorkPrice(currentReportID) + " лв.";
            TextBoxTotalSum.Text = (decimal.Parse(GetReportWorkPrice(currentReportID)) + GetContentTotalPrice(currentReportID)).ToString("f2") + " лв.";
            TextBoxDate.Text = GetDate(currentReportID);
            FillTable();
        }

        private string GetDate(int currentReportID)
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            string query =
                $"SELECT CreationDate " +
                "FROM Reports " +
                "WHERE ID = '" + currentReportID + "'";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();

            DateTime dateTime = new DateTime();
            while (read.Read())
            {
                dateTime = DateTime.Parse(read["CreationDate"].ToString());
            }
            read.Close();
            connection.Close();

            return dateTime.ToString("d");
        }

        private void FillTable()
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            SqlDataReader read = (null);
            string query = "SELECT * " +
                "FROM ReportContents " +
                "WHERE ReportID = '" + currentReportID + "'";

            SqlCommand command = new SqlCommand(query, connection);
            read = command.ExecuteReader();


            string title = String.Empty;
            decimal quantity = 0;
            decimal price = 0;

            while (read.Read())
            {
                title = (read["Title"].ToString());
                quantity = decimal.Parse(read["Quantity"].ToString());
                price = decimal.Parse(read["Price"].ToString());
                ReportContent reportContent = new ReportContent(title, quantity, price, decimal.Parse((quantity * price).ToString("f2")));

                reportContentBindingSource.Add(reportContent);
            }
            read.Close();
            connection.Close();
        }

        private void GetVehicleLicensePlate()
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            string query =
                $"SELECT LicensePlate " +
                "FROM Reports as r " +
                "JOIN Vehicles AS v ON r.VehicleID = v.ID " +
                "WHERE r.ID = '" + currentReportID + "'";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                currentLicensePlate = read["LicensePlate"].ToString();
            }
            read.Close();
            connection.Close();
        }
        private string GetVehicleInformation(string licensePlate)
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            SqlDataReader read = (null);
            string query =
                $"SELECT CONCAT(Make, ' ', Model, ' ', [Year], ' ', Capacity, ' ', HorsePower) AS result " +
                "FROM Vehicles " +
                "WHERE LicensePlate = N'" + licensePlate + "'";

            SqlCommand command = new SqlCommand(query, connection);
            read = command.ExecuteReader();

            string result = String.Empty;

            while (read.Read())
            {
                result = read["result"].ToString();
            }
            read.Close();
            connection.Close();

            return result + "hp";
        }

        private string GetOwnerInformation(string licensePlate)
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            SqlDataReader read = (null);
            string query =
                $"SELECT CONCAT(c.FirstName, ' ', c.LastName, ' | ', c.PhoneNumber) AS result " +
                "FROM Clients as c " +
                "JOIN Vehicles as v ON c.ID = v.ClientID " +
                "WHERE LicensePlate = N'" + licensePlate + "'";

            SqlCommand command = new SqlCommand(query, connection);
            read = command.ExecuteReader();

            string result = String.Empty;

            while (read.Read())
            {
                result = read["result"].ToString();
            }
            read.Close();
            connection.Close();

            return result;
        }

        private string GetReportWorkPrice(int id)
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            SqlDataReader read = (null);
            string query =
                "SELECT WorkPrice " +
                "FROM Reports " +
                "WHERE ID = '" + id + "'";

            SqlCommand command = new SqlCommand(query, connection);
            read = command.ExecuteReader();


            string workPrice = String.Empty;

            while (read.Read())
            {
                workPrice = (read["WorkPrice"].ToString());
            }
            read.Close();
            connection.Close();

            return decimal.Parse(workPrice).ToString("f2");
        }
        private decimal GetContentTotalPrice(int id)
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            SqlDataReader read = (null);
            string query =
                "SELECT Price, Quantity " +
                "FROM ReportContents " +
                "WHERE ReportID = '" + id + "'";

            SqlCommand command = new SqlCommand(query, connection);
            read = command.ExecuteReader();


            decimal totalPrice = 0;

            while (read.Read())
            {
                totalPrice += decimal.Parse(read["Price"].ToString()) * decimal.Parse(read["Quantity"].ToString());
            }
            read.Close();
            connection.Close();

            return totalPrice;
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            ButtonPrint.Visible = false;

            System.Drawing.Bitmap b = new System.Drawing.Bitmap(this.Width, this.Height);
            this.DrawToBitmap(b, new Rectangle(0, 0, this.Width, this.Height));

            b.Save(@"report.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            Process.Start(@"report.jpeg");

            this.Close();
        }

        private void ReportPreview_Load(object sender, EventArgs e)
        {

        }
        private void LabelWorkPrice_Click(object sender, EventArgs e)
        {

        }

        private void LabelTotalSum_Click(object sender, EventArgs e)
        {

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
