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
    public partial class AlertBoxDeleteVehicle : Form
    {
        private VehicleOptions VehicleOptionsPanel;
        public AlertBoxDeleteVehicle()
        {
            InitializeComponent();
            this.Hide();
        }

        private void AlertBoxDeleteVehicle_Load(object sender, EventArgs e)
        {

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ShowData(string text, VehicleOptions vehicleOptions)
        {
            VehicleOptionsPanel = vehicleOptions;
            LabelText.Text = text;
            this.Show();
        }
        private void LabelText_Click(object sender, EventArgs e)
        {

        }

        private void AlerBoxDragPanel_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            VehicleOptionsPanel.DeleteVehicle();
            this.Close();
        }
    }
}
