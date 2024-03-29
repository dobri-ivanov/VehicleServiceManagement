﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleServiceManagement.ReportsInteraction;

namespace VehicleServiceManagement.AlertBoxes
{
    public partial class AlertBoxDeleteReport : Form
    {
        public Main Main;
        public ContentInteractionPanel CIP;
        public AlertBoxDeleteReport()
        {
            InitializeComponent();
            this.Hide();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowData(string text, Main main)
        {
            Main = main;
            LabelText.Text = text;
            this.Show();
        }

        public void ShowData(string text, ContentInteractionPanel cip)
        {
            CIP = cip;
            LabelText.Text = text;
            this.Show();
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            if (Main != null)
            {
                Main.DeleteReport();
            }
            else if (CIP != null)
            {
                CIP.DeleteItem();
            }
          
            this.Close();
        }
    }
}
