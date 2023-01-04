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
    public partial class Main : Form
    {
        string oldName;
        string oldLastName;
        string oldPhoneNumber;
        string oldNickname;

        private static string currentPhoneNumber = String.Empty;
        public static string currentConnectionString = "Data Source=(localdb)\\LocalHost;Initial Catalog=VehicleServiceManagement;Integrated Security=True";

        private bool isMaximized = false;
        private bool isMinimized = false;
        public string connectionString = "Data Source=(localdb)\\LocalHost;Initial Catalog=VehicleServiceManagement;Integrated Security=True";
        public Main()
        {
            InitializeComponent();
        }
        public Main(string name)
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            LabelUserName.Text = name;
            LabelCurrentDate.Text = today.Day.ToString();
        }


        private void ButtonCalendar_MouseHover(object sender, EventArgs e)
        {

            Color colour = new Color();
            colour = Color.FromArgb(30, 216, 172);
            LabelCurrentDate.BackColor = colour;
        }

        private void ButtonCalendar_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.FromArgb(41, 61, 81);
            LabelCurrentDate.BackColor = colour;


        }

        private void ButtonCloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ButtonMaximize_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                ButtonMaximize.Image = VehicleServiceManagement.Properties.Resources.maximize_1;
                this.WindowState = FormWindowState.Normal;
                ReturnControlsPosition();


            }
            else
            {
                ButtonMaximize.Image = VehicleServiceManagement.Properties.Resources.maximize_2;
                this.WindowState = FormWindowState.Maximized;
                ChangeControlsPosition();

            }
            isMaximized = !isMaximized;
        }

        private void ChangeControlsPosition()
        {
            Point currentPoint = ButtonCloseApplication.Location;
            currentPoint.X += 320;
            ButtonCloseApplication.Location = currentPoint;

            currentPoint = ButtonMaximize.Location;
            currentPoint.X += 320;
            ButtonMaximize.Location = currentPoint;

            currentPoint = ButtonMinimize.Location;
            currentPoint.X += 320;
            ButtonMinimize.Location = currentPoint;

            currentPoint = ButtonSettings.Location;
            currentPoint.Y += 180;
            ButtonSettings.Location = currentPoint;

            currentPoint = PanelButtons.Location;
            currentPoint.X += 320;
            PanelButtons.Location = currentPoint;

            currentPoint = ButtonDelete.Location;
            currentPoint.X += 320;
            ButtonDelete.Location = currentPoint;

            currentPoint = ButtonEdit.Location;
            currentPoint.X += 320;
            ButtonEdit.Location = currentPoint;
        }
        private void ReturnControlsPosition()
        {
            Point currentPoint = ButtonCloseApplication.Location;
            currentPoint.X -= 320;
            ButtonCloseApplication.Location = currentPoint;

            currentPoint = ButtonMaximize.Location;
            currentPoint.X -= 320;
            ButtonMaximize.Location = currentPoint;

            currentPoint = ButtonMinimize.Location;
            currentPoint.X -= 320;
            ButtonMinimize.Location = currentPoint;

            currentPoint = ButtonSettings.Location;
            currentPoint.Y -= 180;
            ButtonSettings.Location = currentPoint;

            currentPoint = ButtonAdd.Location;
            currentPoint.X -= 320;
            ButtonAdd.Location = currentPoint;

            currentPoint = ButtonDelete.Location;
            currentPoint.X -= 320;
            ButtonDelete.Location = currentPoint;

            currentPoint = ButtonEdit.Location;
            currentPoint.X -= 320;
            ButtonEdit.Location = currentPoint;
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            //ControlPanel.Dock = DockStyle.None; // Un-dock
            //ControlPanel.Visible = false;
            this.WindowState = FormWindowState.Minimized;
            //isMinimized = true;
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            MainPages.SetPage("Home");
        }

        private void ButtonClients_Click(object sender, EventArgs e)
        {
            MainPages.SetPage("Clients");
            FillClientsTable();
        }
        private void ButtonVehicles_Click(object sender, EventArgs e)
        {
            MainPages.SetPage("Vehicles");
            FillVehiclesTable();
        }

        private void ButtonReports_Click(object sender, EventArgs e)
        {
            MainPages.SetPage("Raports");
        }
        private void ButtonCalendar_Click(object sender, EventArgs e)
        {
            MainPages.SetPage("Calendar");
        }
        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            MainPages.SetPage("Settings");
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (isMinimized == true)
            {
                //ControlPanel.Dock = DockStyle.Top;    // Re-dock
                //ControlPanel.Width = MainPages.Width; // maintain desired width
                //ControlPanel.Visible = true;
                //isMinimized = false;
            }

        }

        private void ButtonEdit_Click_1(object sender, EventArgs e)
        {
            TextBoxName.Enabled = true;
            TextBoxLastName.Enabled = true;
            TextBoxPhoneNumber.Enabled = true;
            ButtonSave.Enabled = true;
            ButtonCancel.Enabled = true;
            TextBoxNickname.Enabled = true;

            oldName = TextBoxName.Text;
            oldLastName = TextBoxLastName.Text;
            oldPhoneNumber = TextBoxPhoneNumber.Text;
            oldNickname = TextBoxNickname.Text;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            TextBoxName.Enabled = false;
            TextBoxLastName.Enabled = false;
            TextBoxPhoneNumber.Enabled = false;
            TextBoxNickname.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonCancel.Enabled = false;

            TextBoxName.Text = oldName;
            TextBoxLastName.Text = oldLastName;
            TextBoxPhoneNumber.Text = oldPhoneNumber;
            TextBoxNickname.Text = oldNickname;
        }

        private void Clear()
        {
            TextBoxPhoneNumber.Text = string.Empty;
            TextBoxName.Text = string.Empty;
            TextBoxLastName.Text = string.Empty;
            TextBoxNickname.Text = string.Empty;
        }

        public void SetVehiclePage()
        {
            MainPages.SetPage("Vehicles");
            FillVehiclesTable();
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (TextBoxName.Text.Length > 0 && TextBoxLastName.Text.Length > 0 && TextBoxPhoneNumber.Text.Length > 0)
            {
                string name = TextBoxName.Text;
                string lastName = TextBoxLastName.Text;
                string phoneNumber = TextBoxPhoneNumber.Text;
                string query;
                SqlCommand command;

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string selectQuery = "SELECT * FROM Clients WHERE PhoneNumber = '" + phoneNumber + "'";
                command = new SqlCommand(selectQuery, connection);

                SqlDataReader read = command.ExecuteReader();
                if (!read.HasRows)
                {
                    read.Close();
                    query = "INSERT INTO Clients(FirstName, LastName, PhoneNumber) VALUES(N'" + name + "', N'" + lastName + "', '" + phoneNumber + "')";
                    if (TextBoxNickname.Text.Length > 0)
                    {
                        string nickname = TextBoxNickname.Text;
                        query = "INSERT INTO Clients(FirstName, LastName, PhoneNumber, Nickname) VALUES(N'" + name + "', N'" + lastName + "', '" + phoneNumber + "', N'" + nickname + "')";
                    }

                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    if (TextBoxNickname.Text.Length > 0)
                    {
                        string nickname = TextBoxNickname.Text;
                        Notification.Show(this, $"Успешно добавен клиент: {name} {lastName} ({nickname}) | {phoneNumber}",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                    }
                    else
                    {
                        Notification.Show(this, $"Успешно добавен клиент: {name} {lastName} | {phoneNumber}",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                    }

                    connection.Close();
                    Clear();
                    TextBoxName.Enabled = true;
                    TextBoxLastName.Enabled = true;
                    TextBoxPhoneNumber.Enabled = true;
                    TextBoxNickname.Enabled = true;
                    FillClientsTable();
                }
                else
                {
                    Notification.Show(this, "Вече съществува клиент с тези данни!",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 3000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                    Clear();
                    TextBoxName.Enabled = true;
                    TextBoxLastName.Enabled = true;
                    TextBoxPhoneNumber.Enabled = true;
                    TextBoxNickname.Enabled = true;
                }
                read.Close();
                connection.Close();
            }
            else
            {
                Notification.Show(this, "Моля попълнете всички данни!",
                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 3000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);

            }
        }

        private void ButtonRefreshClients_Click(object sender, EventArgs e)
        {
            FillClientsTable();
        }

        private void FillClientsTable()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataGridViewClients.Rows.Clear();

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
        private void FillVehiclesTable()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataGridViewVehicles.Rows.Clear();

            SqlDataReader read = (null);
            string query = "SELECT Vehicles.LicensePlate, Vehicles.HorsePower, Vehicles.Capаcity, Vehicles.Year, Vehicles.Fuel, Vehicles.Transmission, Vehicles.Make, Vehicles.Model, Clients.FirstName, Clients.LastName FROM Vehicles INNER JOIN Clients ON Vehicles.ClientID = Clients.ID;";

            SqlCommand command = new SqlCommand(query, connection);
            read = command.ExecuteReader();


            string licensePlate = String.Empty;
            string horsePower = String.Empty;
            string capacity = String.Empty;
            string year = String.Empty;
            string fuel = String.Empty;
            string transmission = String.Empty;
            string make = String.Empty;
            string model = String.Empty;
            string clientFirstName = String.Empty;
            string clientLastName = String.Empty;

            while (read.Read())
            {
                licensePlate = read["LicensePlate"].ToString();
                horsePower = read["HorsePower"].ToString();
                capacity = read["Capаcity"].ToString();
                year = read["Year"].ToString();
                fuel = read["Fuel"].ToString();
                transmission = read["Transmission"].ToString();
                make = read["Make"].ToString();
                model = read["Model"].ToString();
                clientFirstName = read["FirstName"].ToString();
                clientLastName = read["LastName"].ToString();

                Vehicle vehicle = new Vehicle(licensePlate, horsePower, capacity, year, fuel, transmission, make, model, clientFirstName, clientLastName);

                vehicleBindingSource.Add(vehicle);
            }
            read.Close();
            connection.Close();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string text = TextBoxSearch.Text;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Clients WHERE FirstName LIKE'%" + text + "%' OR LastName LIKE '%" + text + "%' OR PhoneNumber LIKE'%" + text + "%' OR Nickname LIKE '%" + text + "%';";
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
            if (DataGridViewClients.Columns[colIndex].Name == "Get")
            {
                TextBoxName.Enabled = false;
                TextBoxLastName.Enabled = false;
                TextBoxPhoneNumber.Enabled = false;
                TextBoxNickname.Enabled = false;
                ButtonEdit.Enabled = true;
                ButtonDelete.Enabled = true;
                ButtonCurrentClientVehicles.Enabled = true;

                string name = DataGridViewClients.Rows[rowIndex].Cells[0].Value.ToString();
                string fullName = DataGridViewClients.Rows[rowIndex].Cells[1].Value.ToString();
                string nickname = DataGridViewClients.Rows[rowIndex].Cells[2].Value.ToString();
                string phoneNumber = DataGridViewClients.Rows[rowIndex].Cells[3].Value.ToString();

                TextBoxName.Text = name;
                TextBoxLastName.Text = fullName;
                TextBoxPhoneNumber.Text = phoneNumber;
                TextBoxNickname.Text = nickname;
                currentPhoneNumber = phoneNumber;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string lastName = TextBoxLastName.Text;
            string phoneNumber = TextBoxPhoneNumber.Text;

            AlertBox alertBox = new AlertBox();
            string text = $"Сигурни ли сте, че искате да изтриете клиент:{Environment.NewLine}{name} {lastName} {phoneNumber}";
            alertBox.DeleteUser(text, this);

        }
        public void DeleteUser()
        {
            SqlConnection connection = new SqlConnection(currentConnectionString);
            connection.Open();
            string query = "DELETE FROM Clients WHERE PhoneNumber = '" + currentPhoneNumber + "';";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            FillClientsTable();

            ButtonDelete.Enabled = false;
            ButtonEdit.Enabled = false;
            TextBoxName.Enabled = true;
            TextBoxLastName.Enabled = true;
            TextBoxPhoneNumber.Enabled = true;
            TextBoxNickname.Enabled = true;

            string name = TextBoxName.Text;
            string lastName = TextBoxLastName.Text;
            string phoneNumber = TextBoxPhoneNumber.Text;

            Clear();
            Notification.Show(this, $"Успешно изтрит клиент: {name} {lastName} | {phoneNumber}",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);

        }
        public void EditUser()
        {
            string currentName = TextBoxName.Text;
            string currentLastName = TextBoxLastName.Text;
            string currentPhoneNumber = TextBoxPhoneNumber.Text;
            string currentNickname = TextBoxNickname.Text;

            SqlConnection connection = new SqlConnection(currentConnectionString);
            connection.Open();

            string query = "UPDATE Clients SET FirstName = N'"+currentName+"', LastName = N'"+currentLastName+"', PhoneNumber = '"+currentPhoneNumber+"', Nickname = N'"+currentNickname+"' WHERE PhoneNumber = '"+oldPhoneNumber+"';";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            FillClientsTable();

            TextBoxName.Enabled = false;
            TextBoxLastName.Enabled = false;
            TextBoxPhoneNumber.Enabled = false;
            TextBoxNickname.Enabled = false;

            Notification.Show(this, $"Данните са успешно променени!",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 4000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (TextBoxName.Text.Length > 0 && TextBoxLastName.Text.Length > 0 && TextBoxPhoneNumber.Text.Length > 0)
            {
                string currentName = TextBoxName.Text;
                string currentLastName = TextBoxLastName.Text;
                string currentPhoneNumber = TextBoxPhoneNumber.Text;
                string currentNickname = TextBoxNickname.Text;
                string text = String.Empty;

                AlertBoxEditClient box = new AlertBoxEditClient();
                if (oldNickname.Length > 0)
                {
                    if (currentNickname.Length > 0)
                    {
                        text = $"Искате ли да приложите следните промени:{Environment.NewLine}Текущи данни:   {oldName} {oldLastName} {oldNickname} {oldPhoneNumber}{Environment.NewLine}Променени данни: {currentName} {currentLastName} {currentNickname} {currentPhoneNumber}";
                    }
                    else
                    {
                        text = $"Искате ли да приложите следните промени:{Environment.NewLine}Текущи данни:   {oldName} {oldLastName} {oldNickname} {oldPhoneNumber}{Environment.NewLine}Променени данни: {currentName} {currentLastName} {currentPhoneNumber}";

                    }
                }
                else
                {
                    if (currentNickname.Length > 0)
                    {
                        text = $"Искате ли да приложите следните промени:{Environment.NewLine}Текущи данни:   {oldName} {oldLastName} {oldPhoneNumber}{Environment.NewLine}Променени данни: {currentName} {currentLastName} {currentNickname} {currentPhoneNumber}";
                    }
                    else
                    {

                        text = $"Искате ли да приложите следните промени:{Environment.NewLine}Текущи данни: {oldName} {oldLastName} {oldPhoneNumber}{Environment.NewLine}Променени данни: {currentName} {currentLastName} {currentPhoneNumber}";

                    }
                }
                box.EditUser(text, this);


            }
            else
            {
                Notification.Show(this, "Моля попълнете всички данни!",
               Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 3000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
            }
        }

        private void ТextBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCurrentClientVehicles_Click(object sender, EventArgs e)
        {
            int currentClientID = 0;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string phoneNum = TextBoxPhoneNumber.Text;
            string query = "SELECT * FROM Clients WHERE PhoneNumber = '"+phoneNum+"'";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                currentClientID = int.Parse((read["ID"].ToString()));
            }
            read.Close();
            connection.Close();

            SearchVehicle sv = new SearchVehicle(currentClientID, this);
            sv.Show();
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = TextBoxSearchVehicles.Text;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT Vehicles.LicensePlate, Vehicles.HorsePower, Vehicles.Capаcity, Vehicles.Year, Vehicles.Fuel, Vehicles.Transmission, Vehicles.Make, Vehicles.Model, Clients.FirstName, Clients.LastName FROM Vehicles INNER JOIN Clients ON Vehicles.ClientID = Clients.ID WHERE LicensePlate LIKE'%" + text + "%' OR HorsePower LIKE '%" + text + "%' OR Capаcity LIKE'%" + text + "%' OR Year LIKE '%" + text + "%' OR Make LIKE '%" + text + "%' OR Model LIKE '%" + text + "%' OR FirstName LIKE '%" + text + "%' OR LastName LIKE '%" + text + "%'; ";
            DataGridViewVehicles.Rows.Clear();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();


            string licensePlate = String.Empty;
            string horsePower = String.Empty;
            string capacity = String.Empty;
            string year = String.Empty;
            string fuel = String.Empty;
            string transmission = String.Empty;
            string make = String.Empty;
            string model = String.Empty;
            string clientFirstName = String.Empty;
            string clientLastName = String.Empty;

            while (read.Read())
            {
                licensePlate = read["LicensePlate"].ToString();
                horsePower = read["HorsePower"].ToString();
                capacity = read["Capаcity"].ToString();
                year = read["Year"].ToString();
                fuel = read["Fuel"].ToString();
                transmission = read["Transmission"].ToString();
                make = read["Make"].ToString();
                model = read["Model"].ToString();
                clientFirstName = read["FirstName"].ToString();
                clientLastName = read["LastName"].ToString();

                Vehicle vehicle = new Vehicle(licensePlate, horsePower, capacity, year, fuel, transmission, make, model, clientFirstName, clientLastName);

                vehicleBindingSource.Add(vehicle);
            }
            read.Close();
            connection.Close();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            FillVehiclesTable();
        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void ImageButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxName.Text = string.Empty;
            TextBoxLastName.Text = string.Empty;
            TextBoxPhoneNumber.Text = string.Empty;
            TextBoxNickname.Text = string.Empty;

            TextBoxName.Enabled = false;
            TextBoxLastName.Enabled = false;
            TextBoxPhoneNumber.Enabled = false;
            TextBoxNickname.Enabled = false;
            ButtonCurrentClientVehicles.Enabled = false;
        }

        private void ControlPanel_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAddVechicle_Click(object sender, EventArgs e)
        {
            AddNewVehicle addNewVehicle = new AddNewVehicle();
            addNewVehicle.Show();
        }
    }
}
