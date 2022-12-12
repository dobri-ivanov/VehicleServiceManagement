﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace VehicleServiceManagement
{
    public partial class Login : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Login()
        {
            InitializeComponent();
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text.Length > 0)
            {
                CheckBoxShowPassword.Enabled = true;
            }
            else
            {
                CheckBoxShowPassword.Checked = false;
                CheckBoxShowPassword.Enabled = false;
            }

            if (TextBoxPassword.Text.Length == 0)
            {

                TextBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                if (CheckBoxShowPassword.Checked == false)
                {
                    TextBoxPassword.UseSystemPasswordChar = true;
                }
            }
        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (CheckBoxShowPassword.Checked == true)
            {
                TextBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TextBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void DragPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TextBoxUsername.Text == "1" && TextBoxPassword.Text == "1")
            {
                Form1 fomm = new Form1();
                fomm.Show();
                this.Hide();     
            }
            else
            {
                MessageBox.Show("Data incorect!");
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ButtonLogin_Click(sender, e);
            }
        }

        private void TextBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ButtonLogin_Click(sender, e);
            }
        }
        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ButtonLogin_Click(sender, e);
            }
        }
    }
}