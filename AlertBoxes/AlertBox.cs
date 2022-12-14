using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleServiceManagement
{
    public partial class AlertBox : Form
    {
        public Main mainForm;
        public AlertBox()
        {
            InitializeComponent();
            this.Hide();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            mainForm.DeleteUser();
            this.Hide();
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void DeleteUser(string text, Main main)
        {
            mainForm = main;
            LabelText.Text = text;
            this.Show();
        }

        private void LabelText_Click(object sender, EventArgs e)
        {

        }
    }
}
