﻿using System;
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
        private bool isMaximized = false;
        private bool isMinimized = false;
        public string connectionString = "Data Source=(localdb)\\LocalHost;Initial Catalog=VehicleServiceManagement;Integrated Security=True";
        SqlConnection connection;
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
        }

        private void ButtonReports_Click(object sender, EventArgs e)
        {
            MainPages.SetPage("Reports");
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
            ТextBoxFamily.Enabled = true;
            TextBoxPhoneNumber.Enabled = true;
            ButtonSave.Enabled = true;
            ButtonCancel.Enabled = true;
            TextBoxNickname.Enabled = true;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            TextBoxName.Enabled = false;
            ТextBoxFamily.Enabled = false;
            TextBoxPhoneNumber.Enabled = false;
            TextBoxNickname.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonCancel.Enabled = false;

            Clear();
        }

        private void Clear()
        {
            TextBoxPhoneNumber.Text = string.Empty;
            TextBoxName.Text = string.Empty;
            ТextBoxFamily.Text = string.Empty;
            TextBoxNickname.Text = string.Empty;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (TextBoxName.Text.Length > 0 && ТextBoxFamily.Text.Length > 0 && TextBoxPhoneNumber.Text.Length > 0)
            {
                string name = TextBoxName.Text;
                string lastName = ТextBoxFamily.Text;
                string phoneNumber = TextBoxPhoneNumber.Text;
                string query;
                SqlCommand command;

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string selectQuery = "SELECT * FROM Clients WHERE PhoneNumber = '"+phoneNumber+"'";
                command = new SqlCommand(selectQuery, connection);

                SqlDataReader read = command.ExecuteReader();
                if (!read.HasRows)
                {
                    read.Close();
                    query = "INSERT INTO Clients(FirstName, LastName, PhoneNumber) VALUES('" + name + "', '" + lastName + "', '" + phoneNumber + "')";
                    if (TextBoxNickname.Text.Length > 0)
                    {
                        string nickname = TextBoxNickname.Text;
                        query = "INSERT INTO Clients(FirstName, LastName, PhoneNumber, Nickname) VALUES('" + name + "', '" + lastName + "', '" + phoneNumber + "', '" + nickname + "')";
                    }

                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    FillClientsTable();
                }
                else
                {
                    //Already has client with that phone number
                    //Shoud be implemented
                }

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
                ТextBoxFamily.Enabled = false;
                TextBoxPhoneNumber.Enabled = false;
                TextBoxNickname.Enabled = false;
                ButtonEdit.Enabled = true;
                ButtonDelete.Enabled = true;

                string name = DataGridViewClients.Rows[rowIndex].Cells[0].Value.ToString();
                string fullName = DataGridViewClients.Rows[rowIndex].Cells[1].Value.ToString();
                string phoneNumber = DataGridViewClients.Rows[rowIndex].Cells[2].Value.ToString();
                string nickname = DataGridViewClients.Rows[rowIndex].Cells[3].Value.ToString();

                TextBoxName.Text = name;
                ТextBoxFamily.Text = fullName;
                TextBoxPhoneNumber.Text = phoneNumber;
                TextBoxNickname.Text = nickname;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (TextBoxName.Text.Length > 0 && ТextBoxFamily.Text.Length > 0 && TextBoxPhoneNumber.Text.Length > 0)
            {
                string name = TextBoxName.Text;
                string lastName = ТextBoxFamily.Text;
                string phoneNumber = TextBoxPhoneNumber.Text;

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "DELETE FROM Clients WHERE PhoneNumber = '" + phoneNumber + "';";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();

                FillClientsTable();
            }


        }

        private void DataGridViewClients_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
    }
}