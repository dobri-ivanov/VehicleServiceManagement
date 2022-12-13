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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            ProgressBarLoading.Value += 1;
            if (ProgressBarLoading.Value == 200)
            {
                Timer.Enabled = false;
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
