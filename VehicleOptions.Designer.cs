
namespace VehicleServiceManagement
{
    partial class VehicleOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleOptions));
            this.Panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackgroundColor = System.Drawing.Color.Transparent;
            this.Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel.BackgroundImage")));
            this.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel.BorderColor = System.Drawing.Color.Transparent;
            this.Panel.BorderRadius = 3;
            this.Panel.BorderThickness = 1;
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.ShowBorders = true;
            this.Panel.Size = new System.Drawing.Size(283, 260);
            this.Panel.TabIndex = 0;
            // 
            // VehicleOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(283, 260);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VehicleOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehicleOptions";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel Panel;
    }
}