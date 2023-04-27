using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using VehicleServiceManagement.AlertBoxes;
using VehicleServiceManagement.ReportsInteraction;

namespace VehicleServiceManagement
{
    public partial class Main : Form
    {
        string oldName;
        string oldLastName;
        string oldPhoneNumber;
        string oldNickname;
        int currentReportId;

        private static string currentPhoneNumber = String.Empty;
        private bool isMaximized = false;
        private bool isMinimized = false;
        public static string currentConnectionString = "Data Source=(localdb)\\LocalHost;Initial Catalog=VehicleServiceManagement;Integrated Security=True";
        //public static string currentConnectionString = "Data Source=mssql-123097-0.cloudclusters.net,10126;Initial Catalog=VehicleServiceManagement;Persist Security Info=True;User ID=DobriIv;Password=Test123456";
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

            currentPoint = ButtonAdd.Location;
            currentPoint.X += 320;
            ButtonAdd.Location = currentPoint;

            currentPoint = ButtonEdit.Location;
            currentPoint.X += 320;
            ButtonEdit.Location = currentPoint;

            currentPoint = ShadowPanelCurrentClient.Location;
            currentPoint.X += 320;
            ShadowPanelCurrentClient.Location = currentPoint;
            ShadowPanelCurrentClient.Size = new Size(572, 926);

            currentPoint = ButtonCancel.Location;
            currentPoint.Y += 180;
            ButtonCancel.Location = currentPoint;

            currentPoint = ButtonSave.Location;
            currentPoint.Y += 180;
            ButtonSave.Location = currentPoint;

            currentPoint = ButtonRefreshClients.Location;
            currentPoint.X += 320;
            ButtonRefreshClients.Location = currentPoint;

            currentPoint = TextBoxSearch.Location;
            currentPoint.X += 320;
            TextBoxSearch.Location = currentPoint;

            DataGridViewVehicles.Size = new Size(1651, 917);
            DataGridViewClients.Size = new Size(1074, 923);

            currentPoint = ButtonAddVechicle.Location;
            currentPoint.X += 320;
            ButtonAddVechicle.Location = currentPoint;

            currentPoint = ButtonLogOut.Location;
            currentPoint.X += 320;
            ButtonLogOut.Location = currentPoint;

            ShadowPanelCurrentReport.Size = new Size(789, 936);

            currentPoint = ShadowPanelCurrentReport.Location;
            currentPoint.X += 320;
            ShadowPanelCurrentReport.Location = currentPoint;


            currentPoint = ButtonCreateReport.Location;
            currentPoint.X += 320;
            ButtonCreateReport.Location = currentPoint;

            DataGridViewRaports.Size = new Size(869, 917);

            currentPoint = TextBoxSearchReport.Location;
            currentPoint.X += 320;
            TextBoxSearchReport.Location = currentPoint;

            currentPoint = ImageButtonRefreshReports.Location;
            currentPoint.X += 320;
            ImageButtonRefreshReports.Location = currentPoint;

            DataGridViewCurerntReportContent.Size = new Size(774, 596);

            currentPoint = LabelWorkPrice.Location;
            currentPoint.Y += 180;
            LabelWorkPrice.Location = currentPoint;

            currentPoint = LabelTotalSum.Location;
            currentPoint.Y += 180;
            LabelTotalSum.Location = currentPoint;

            currentPoint = TextBoxWorkPrice.Location;
            currentPoint.Y += 180;
            TextBoxWorkPrice.Location = currentPoint;

            currentPoint = TextBoxTotalSum.Location;
            currentPoint.Y += 180;
            TextBoxTotalSum.Location = currentPoint;

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

            currentPoint = ShadowPanelCurrentClient.Location;
            currentPoint.X -= 320;
            ShadowPanelCurrentClient.Location = currentPoint;

            ShadowPanelCurrentClient.Size = new Size(572, 746);

            currentPoint = ButtonCancel.Location;
            currentPoint.Y -= 180;
            ButtonCancel.Location = currentPoint;

            currentPoint = ButtonSave.Location;
            currentPoint.Y -= 180;
            ButtonSave.Location = currentPoint;

            currentPoint = ButtonRefreshClients.Location;
            currentPoint.X -= 320;
            ButtonRefreshClients.Location = currentPoint;

            currentPoint = TextBoxSearch.Location;
            currentPoint.X -= 320;
            TextBoxSearch.Location = currentPoint;

            DataGridViewVehicles.Size = new Size(1331, 737);
            DataGridViewClients.Size = new Size(754, 743);

            currentPoint = ButtonAddVechicle.Location;
            currentPoint.X -= 320;
            ButtonAddVechicle.Location = currentPoint;

            currentPoint = ButtonLogOut.Location;
            currentPoint.X -= 320;
            ButtonLogOut.Location = currentPoint;

            ShadowPanelCurrentReport.Size = new Size(789, 756);

            currentPoint = ShadowPanelCurrentReport.Location;
            currentPoint.X -= 320;
            ShadowPanelCurrentReport.Location = currentPoint;


            currentPoint = ButtonCreateReport.Location;
            currentPoint.X -= 320;
            ButtonCreateReport.Location = currentPoint;

            DataGridViewRaports.Size = new Size(549, 737);

            currentPoint = TextBoxSearchReport.Location;
            currentPoint.X -= 320;
            TextBoxSearchReport.Location = currentPoint;

            currentPoint = ImageButtonRefreshReports.Location;
            currentPoint.X -= 320;
            ImageButtonRefreshReports.Location = currentPoint;
            //
            DataGridViewCurerntReportContent.Size = new Size(774, 416);

            currentPoint = LabelWorkPrice.Location;
            currentPoint.Y -= 180;
            LabelWorkPrice.Location = currentPoint;

            currentPoint = LabelTotalSum.Location;
            currentPoint.Y -= 180;
            LabelTotalSum.Location = currentPoint;

            currentPoint = TextBoxWorkPrice.Location;
            currentPoint.Y -= 180;
            TextBoxWorkPrice.Location = currentPoint;

            currentPoint = TextBoxTotalSum.Location;
            currentPoint.Y -= 180;
            TextBoxTotalSum.Location = currentPoint;
        }

        internal void ReportNotification(string function, int id, string title, string licensePlate, string date)
        {
            if (function == "ADD")
            {
                Notification.Show(this, $"Създаден е нов ремонт!",
                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
            }
            else
            {
                Notification.Show(this, $"Текущият ремонт е редактиран успешно!",
                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
            }

            GenerateReport(id, title, licensePlate, date);
            FillRaportsTable();
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            PanelButtons.Dock = DockStyle.None;
            this.WindowState = FormWindowState.Minimized;
            isMinimized = true;
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
            FillRaportsTable();
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
                PanelButtons.Dock = DockStyle.Left;    // Re-dock
                PanelButtons.Visible = true;
                isMinimized = false;
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

                SqlConnection connection = new SqlConnection(Main.currentConnectionString);
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

        public void AddVehicleNotfication()
        {
            Notification.Show(this, $"Автомобилът е добавен успешно!",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);

        }
        private void FillClientsTable()
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
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

        public void FillRaportsTable()
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();
            DataGridViewRaports.Rows.Clear();

            SqlDataReader read = (null);
            string query =
                "SELECT r.ID, r.Title, r.CreationDate, v.LicensePlate " +
                "FROM Reports AS r " +
                "JOIN Vehicles AS v ON r.VehicleID = v.ID " +
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
        public void FillVehiclesTable()
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();
            DataGridViewVehicles.Rows.Clear();

            SqlDataReader read = (null);
            string query = "SELECT Vehicles.LicensePlate, Vehicles.HorsePower, Vehicles.Capacity, Vehicles.Year, Vehicles.Fuel, Vehicles.Transmission, Vehicles.Make, Vehicles.Model, Clients.FirstName, Clients.LastName FROM Vehicles INNER JOIN Clients ON Vehicles.ClientID = Clients.ID;";

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
                capacity = read["Capacity"].ToString();
                year = read["Year"].ToString();
                fuel = read["Fuel"].ToString();
                transmission = read["Transmission"].ToString();
                make = read["Make"].ToString();
                model = read["Model"].ToString();
                clientFirstName = read["FirstName"].ToString() + " " + read["LastName"].ToString();
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
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
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
            try
            {
                SqlConnection connection = new SqlConnection(Main.currentConnectionString);
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
            catch
            {
                Notification.Show(this, $"Изтриването не е успешно! Можете да премахнете само клиенти, които не притежават автомобили!",
                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 10000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);

            }
        }
        public void EditUser()
        {
            string currentName = TextBoxName.Text;
            string currentLastName = TextBoxLastName.Text;
            string currentPhoneNumber = TextBoxPhoneNumber.Text;
            string currentNickname = TextBoxNickname.Text;

            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            string query = "UPDATE Clients SET FirstName = N'" + currentName + "', LastName = N'" + currentLastName + "', PhoneNumber = '" + currentPhoneNumber + "', Nickname = N'" + currentNickname + "' WHERE PhoneNumber = '" + oldPhoneNumber + "';";
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

        private void ButtonCurrentClientVehicles_Click(object sender, EventArgs e)
        {
            int currentClientID = 0;

            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();
            string phoneNum = TextBoxPhoneNumber.Text;
            string query = "SELECT * FROM Clients WHERE PhoneNumber = '" + phoneNum + "'";

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

        public void ChangeVehicleSearchText(string text)
        {
            TextBoxSearchVehicles.Text = text;
        }
        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = TextBoxSearchVehicles.Text;
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();
            string query = "SELECT Vehicles.LicensePlate, Vehicles.HorsePower, Vehicles.Capacity, Vehicles.Year, Vehicles.Fuel, Vehicles.Transmission, Vehicles.Make, Vehicles.Model, Clients.FirstName, Clients.LastName FROM Vehicles INNER JOIN Clients ON Vehicles.ClientID = Clients.ID WHERE Clients.FirstName LIKE N'%" + text + "%' OR LicensePlate LIKE N'%" + text + "%' OR HorsePower LIKE '%" + text + "%' OR Capacity LIKE'%" + text + "%' OR Year LIKE '%" + text + "%' OR Make LIKE '%" + text + "%' OR Model LIKE '%" + text + "%' OR FirstName LIKE '%" + text + "%' OR LastName LIKE '%" + text + "%'; ";
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
                capacity = read["Capacity"].ToString();
                year = read["Year"].ToString();
                fuel = read["Fuel"].ToString();
                transmission = read["Transmission"].ToString();
                make = read["Make"].ToString();
                model = read["Model"].ToString();
                clientFirstName = read["FirstName"].ToString();
                clientLastName = read["LastName"].ToString();

                Vehicle vehicle = new Vehicle(licensePlate, horsePower, capacity, year, fuel, transmission, make, model, clientFirstName + " " + clientLastName, clientLastName);

                vehicleBindingSource.Add(vehicle);
            }
            read.Close();
            connection.Close();
        }
        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;

            if (DataGridViewVehicles.Columns[colIndex].Name == "GetVehicle")
            {
                string licensePlate = DataGridViewVehicles.Rows[rowIndex].Cells[8].Value.ToString();
                VehicleOptions vehicleOptions = new VehicleOptions(licensePlate, this);
                vehicleOptions.Show();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            FillVehiclesTable();
        }

        private void ImageButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxName.Text = string.Empty;
            TextBoxLastName.Text = string.Empty;
            TextBoxPhoneNumber.Text = string.Empty;
            TextBoxNickname.Text = string.Empty;

            TextBoxName.Enabled = true;
            TextBoxLastName.Enabled = true;
            TextBoxPhoneNumber.Enabled = true;
            TextBoxNickname.Enabled = true;
            ButtonCurrentClientVehicles.Enabled = false;
            ButtonEdit.Enabled = false;
            ButtonDelete.Enabled = false;
        }

        private void ButtonAddVechicle_Click(object sender, EventArgs e)
        {
            AddNewVehicle addNewVehicle = new AddNewVehicle(this, "ADD");
            addNewVehicle.Show();
        }

        public void DeleteVehicleNotification(string text)
        {
            Notification.Show(this, $"{text}",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);

        }
        public void EditVehicleNotification(string text)
        {
            FillVehiclesTable();
            Notification.Show(this, $"{text}",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);

        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            Main currentPanel = this;
            Login login = new Login();
            login.Show();
            currentPanel.Hide();

        }

        private void ImageButtonRefreshReports_Click(object sender, EventArgs e)
        {
            FillRaportsTable();
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

                GenerateReport(id, title, licensePlate, date);
            }
        }

        public void LoadReport(int id, string title, string licensePlate, string date)
        {
            GenerateReport(id, title, licensePlate, date);
            MainPages.SetPage("Raports");
            this.TopMost = true;
            this.TopMost = false;
        }
        private void GenerateReport(int id, string title, string licensePlate, string date)
        {
            ShadowPanelCurrentReport.Visible = true;

            currentReportId = id;
            TextBoxDate.Text = date;
            LabelReportTitle.Text = title;
            TextBoxVehicle.Text = GetVehicleInformation(licensePlate);
            TextBoxOwner.Text = GetOwnerInformation(licensePlate);
            TextBoxWorkPrice.Text = GetReportWorkPrice(id) + " лв.";
            TextBoxTotalSum.Text = (decimal.Parse(GetReportWorkPrice(id)) + GetContentTotalPrice(id)).ToString("f2") + " лв.";
            FillReportContentTable(id);
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

            return workPrice;
        }

        public void FillReportContentTable(int id)
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();
            DataGridViewCurerntReportContent.Rows.Clear();

            SqlDataReader read = (null);
            string query = "SELECT * " +
                "FROM ReportContents " +
                "WHERE ReportID = '" + id + "'";

            SqlCommand command = new SqlCommand(query, connection);
            read = command.ExecuteReader();


            string title = String.Empty;
            decimal quantity = 0;
            decimal price = 0;

            int row = 0;
            while (read.Read())
            {
                title = (read["Title"].ToString());
                quantity = decimal.Parse(read["Quantity"].ToString());
                price = decimal.Parse(read["Price"].ToString());
                ReportContent reportContent = new ReportContent(title, quantity, price);

                reportContentBindingSource.Add(reportContent);
                DataGridViewCurerntReportContent[3, row++].Value = (quantity * price).ToString("f2");
            }
            read.Close();
            connection.Close();
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
                "WHERE LicensePlate = '" + licensePlate + "'";

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

        private string GetVehicleInformation(string licensePlate)
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            SqlDataReader read = (null);
            string query =
                $"SELECT CONCAT(Make, ' ', Model, ' ', [Year], ' ', Capacity, ' ', HorsePower) AS result " +
                "FROM Vehicles " +
                "WHERE LicensePlate = '" + licensePlate + "'";

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

        private void ButtonDeleteReport_Click(object sender, EventArgs e)
        {

            AlertBoxDeleteReport alertBoxDeleteReport = new AlertBoxDeleteReport();
            alertBoxDeleteReport.ShowData("Сигурни ли сте, че искате да изтриете текущия ремонт?", this);
        }

        public void DeleteReport()
        {
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            string query =
                $"DELETE FROM ReportContents " +
                $"WHERE ReportID = '" + currentReportId + "'";

            string query2 =
              $"DELETE FROM Reports " +
              $"WHERE ID = '" + currentReportId + "'";

            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            command = new SqlCommand(query2, connection);
            command.ExecuteNonQuery();
            connection.Close();

            ShadowPanelCurrentReport.Visible = false;
            FillRaportsTable();

            Notification.Show(this, $"Текущият ремонт е успешно изтрит!",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "ЗАТВОРИ", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
        }

        private void TextBoxSearchReport_TextChanged(object sender, EventArgs e)
        {
            string text = TextBoxSearchReport.Text;
            SqlConnection connection = new SqlConnection(Main.currentConnectionString);
            connection.Open();

            string query =
                "SELECT r.ID, r.Title, r.CreationDate, v.LicensePlate " +
                "FROM Reports as r " +
                "JOIN Vehicles as v ON r.VehicleID = v.ID " +
                "WHERE r.Title LIKE N'%" + text + "%' " +
                "OR r.CreationDate LIKE N'%" + text + "%' " +
                "OR r.ID LIKE N'%" + text + "%' " +
                "OR v.LicensePlate LIKE N'%" + text + "%';";

            DataGridViewRaports.Rows.Clear();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();

            int id = 0;
            string title = String.Empty;
            string date = String.Empty;
            string licensePlate = String.Empty;

            while (read.Read())
            {
                id = int.Parse(read["ID"].ToString());
                title = read["Title"].ToString();
                date = DateTime.Parse(read["CreationDate"].ToString()).ToString("d");
                licensePlate = read["LicensePlate"].ToString();

                Report report = new Report(id, title, date, licensePlate);
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

        private bool AreValidCoords(int rowIndex, int colIndex)
        {
            if (rowIndex >= 0 && colIndex >= 0)
            {
                return true;
            }
            return false;
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

        private void DataGridViewClients_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            if (DataGridViewClients.Columns[colIndex].Name == "Get")
            {
                if (AreValidCoords(rowIndex, colIndex))
                {
                    DataGridViewClients.Rows[rowIndex].Cells[colIndex].Value = Properties.Resources.select_new_hover;
                }
            }
        }

        private void DataGridViewClients_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            if (DataGridViewClients.Columns[colIndex].Name == "Get")
            {
                if (AreValidCoords(rowIndex, colIndex))
                {
                    DataGridViewClients.Rows[rowIndex].Cells[colIndex].Value = Properties.Resources.select_new;
                }
            }
        }
        private void DataGridViewVehicles_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            if (DataGridViewVehicles.Columns[colIndex].Name == "GetVehicle")
            {
                if (AreValidCoords(rowIndex, colIndex))
                {
                    DataGridViewVehicles.Rows[rowIndex].Cells[colIndex].Value = Properties.Resources.select_new_hover;
                }
            }
        }

        private void DataGridViewVehicles_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            if (DataGridViewVehicles.Columns[colIndex].Name == "GetVehicle")
            {
                if (AreValidCoords(rowIndex, colIndex))
                {
                    DataGridViewVehicles.Rows[rowIndex].Cells[colIndex].Value = Properties.Resources.select_new;
                }
            }
        }
        public void CreateNewReport(string licensePlate)
        {
            MainPages.SetPage("Raports");
            AddEditReport addEditReport = new AddEditReport("ADD2", this, licensePlate);
            addEditReport.ShowDialog();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            AddEditReport addEditReport = new AddEditReport("ADD", this);
            addEditReport.Show();
        }

        private void ButtonEditReport_Click(object sender, EventArgs e)
        {
            AddEditReport addEditReport = new AddEditReport("EDIT", this, currentReportId);
            addEditReport.ShowDialog();
        }
    }
}
