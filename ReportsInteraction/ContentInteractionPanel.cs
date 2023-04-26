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
    public partial class ContentInteractionPanel : Form
    {
        //Main
        private string Function;
        private int CurrentReportId;
        private AddEditReport AER;
        private decimal totalSum;

        //Needed for edit function
        private string CurrentTitle;
        private decimal CurrentQuantity;
        private decimal CurrentPrice;

        public ContentInteractionPanel(AddEditReport aer, string function, int reportId)
        {
            AER = aer;
            Function = function;
            CurrentReportId = reportId;
            InitializeComponent();
            Configure();

        }
        public ContentInteractionPanel(AddEditReport aer, string function, int reportId, string title, decimal quantity, decimal price)
        {
            CurrentTitle = title;
            CurrentQuantity = quantity;
            CurrentPrice = price;
            Function = function;
            CurrentReportId = reportId;
            InitializeComponent();
            Configure();
        }

        private void Configure()
        {
            if (Function == "ADD")
            {
                LabelHeader.Text = "ДОБАВЯНЕ НА НОВ АРТИКУЛ";
                ButtonSave.Text = "ДОБАВИ";
            }
            else if (Function == "EDIT")
            {
                LabelHeader.Text = "РЕДАКТИРАНЕ НА АРТИКУЛ";
                ButtonSave.Text = "ЗАПАЗИ";

                LoadItem();

            }
        }

        //Shoud be implemented
        private void LoadItem()
        {

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string title = TextBoxTitle.Text;
            //Validation rule
            decimal quantity = decimal.Parse(TextBoxQuantity.Text);
            decimal price = decimal.Parse(TextBoxPrice.Text);

            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            string query =
                "SELECT Count(*) as Result " +
                "FROM ReportContents " +
                "WHERE " +
                "ReportID = '" + CurrentReportId + "' AND " +
                "Title = N'" + title + "' AND " +
                "Quantity = '" + quantity + "' AND " +
                "Price = '" + price + "';";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();


            reader.Read();

            int count = int.Parse(reader["Result"].ToString());

            if (count > 0)
            {
                Notification.Show(this, $"Вече има създаден подобен артикул!",
                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 5000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                return;
            }

            string query2 =
                "INSERT INTO ReportContents (Title, Quantity, Price, ReportID)" +
                "VALUES (N'" + title + "', '" + quantity + "', '" + price + "', '" + CurrentReportId + "')";
            reader.Close();

            command = new SqlCommand(query2, connection);
            command.ExecuteNonQuery();

            AER.FillContentTable(CurrentReportId);

            connection.Close();
            this.Close();
        }

        private void TextBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            RefreshTotalSum();
        }

        private void RefreshTotalSum()
        {
            if (!string.IsNullOrEmpty(TextBoxQuantity.Text) && !string.IsNullOrEmpty(TextBoxPrice.Text))
            {
                try
                {
                    totalSum = decimal.Parse(TextBoxQuantity.Text.ToString()) * decimal.Parse(TextBoxPrice.Text.ToString());
                }
                catch (Exception)
                {

                }      
            }
            TextBoxTotalSum.Text = totalSum.ToString("f2") + " лв.";
        }

        private void TextBoxPrice_TextChanged(object sender, EventArgs e)
        {
            RefreshTotalSum();
        }
    }
}
