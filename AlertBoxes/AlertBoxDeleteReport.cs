using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleServiceManagement.AlertBoxes
{
    public partial class AlertBoxDeleteReport : Form
    {
        public Main Main;
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

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            Main.DeleteReport();
            this.Close();
        }
    }
}
