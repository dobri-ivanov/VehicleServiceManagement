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
            AER = aer;
            CurrentTitle = title;
            CurrentQuantity = quantity;
            CurrentPrice = price;
            Function = function;
            CurrentReportId = reportId;
            InitializeComponent();
            Configure();
        }

        internal void DeleteItem()
        {
            AER.DeleteItem(CurrentTitle, CurrentQuantity, CurrentPrice);
            this.Close();
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
                ButtonDelete.Visible = true;
                TextBoxQuantity.PlaceholderText = string.Empty;
                TextBoxPrice.PlaceholderText = string.Empty;

                LoadItem();

            }
        }

        private void LoadItem()
        {
            TextBoxTitle.Text = CurrentTitle;
            TextBoxQuantity.Text = CurrentQuantity.ToString();
            TextBoxPrice.Text = CurrentPrice.ToString();

            RefreshTotalSum();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (Function == "ADD")
            {
                AddNewItem();
            }
            else if (Function == "EDIT")
            {
                UpdateCurrentItem();
            }
        }

        private void UpdateCurrentItem()
        {
            string titleNewValue = TextBoxTitle.Text;
            decimal quantityNewValue = decimal.Parse(TextBoxQuantity.Text);
            decimal priceNewValue = decimal.Parse(TextBoxPrice.Text);

            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            string query =
                "UPDATE ReportContents " +
                "SET " +
                "Title = N'"+ titleNewValue + "', " +
                "Quantity = '" + quantityNewValue + "', " +
                "Price = '" + priceNewValue + "' " +
                "WHERE " +
                "Title = N'" + CurrentTitle + "' AND " +
                "Quantity = '" + CurrentQuantity + "' AND " +
                "Price = '" + CurrentPrice + "' AND " +
                "ReportID = '" + CurrentReportId + "';";

            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();

            AER.FillContentTable(CurrentReportId);
            this.Close();

        }

        private void AddNewItem()
        {
            string title = TextBoxTitle.Text;
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

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            AlertBoxDeleteReport alertBoxDeleteReport = new AlertBoxDeleteReport();
            alertBoxDeleteReport.ShowData("Сигурни ли сте, че искате да изтриете текущия артикул?", this);
        }

        private void TextBoxPrice_TextChanged_1(object sender, EventArgs e)
        {
            RefreshTotalSum();
        }
    }
}
