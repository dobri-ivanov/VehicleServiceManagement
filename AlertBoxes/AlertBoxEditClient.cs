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
    public partial class AlertBoxEditClient : Form
    {
        private Main mainForm;
        public AlertBoxEditClient()
        {
            InitializeComponent();
            this.Hide();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void EditUser(string text, Main main)
        {
            mainForm = main;
            LabelText.Text = text;
            this.Show();
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.EditUser();
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
