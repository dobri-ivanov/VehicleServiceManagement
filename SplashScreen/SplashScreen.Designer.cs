
namespace VehicleServiceManagement
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.ProgressBarLoading = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LabelTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.PictureBoxLogo = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBarLoading
            // 
            this.ProgressBarLoading.AllowAnimations = false;
            this.ProgressBarLoading.Animation = 0;
            this.ProgressBarLoading.AnimationSpeed = 220;
            this.ProgressBarLoading.AnimationStep = 10;
            this.ProgressBarLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.ProgressBarLoading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProgressBarLoading.BackgroundImage")));
            this.ProgressBarLoading.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.ProgressBarLoading.BorderRadius = 9;
            this.ProgressBarLoading.BorderThickness = 1;
            this.ProgressBarLoading.Location = new System.Drawing.Point(-4, 421);
            this.ProgressBarLoading.Maximum = 200;
            this.ProgressBarLoading.MaximumValue = 200;
            this.ProgressBarLoading.Minimum = 0;
            this.ProgressBarLoading.MinimumValue = 0;
            this.ProgressBarLoading.Name = "ProgressBarLoading";
            this.ProgressBarLoading.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.ProgressBarLoading.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.ProgressBarLoading.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.ProgressBarLoading.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.ProgressBarLoading.Size = new System.Drawing.Size(809, 29);
            this.ProgressBarLoading.TabIndex = 0;
            this.ProgressBarLoading.Value = 0;
            this.ProgressBarLoading.ValueByTransition = 0;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 7;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AllowParentOverrides = false;
            this.LabelTitle.AutoEllipsis = false;
            this.LabelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 37F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(12, 54);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelTitle.Size = new System.Drawing.Size(770, 66);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "VEHICLE SERVICE MANAGEMENT";
            this.LabelTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.LabelTitle.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.AllowFocused = false;
            this.PictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBoxLogo.AutoSizeHeight = true;
            this.PictureBoxLogo.BorderRadius = 107;
            this.PictureBoxLogo.Image = global::VehicleServiceManagement.Properties.Resources.Logo_DjoniAuto;
            this.PictureBoxLogo.IsCircle = true;
            this.PictureBoxLogo.Location = new System.Drawing.Point(286, 138);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(215, 215);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogo.TabIndex = 2;
            this.PictureBoxLogo.TabStop = false;
            this.PictureBoxLogo.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureBoxLogo);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ProgressBarLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VSM";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuProgressBar ProgressBarLoading;
        private System.Windows.Forms.Timer Timer;
        private Bunifu.UI.WinForms.BunifuLabel LabelTitle;
        private Bunifu.UI.WinForms.BunifuPictureBox PictureBoxLogo;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
    }
}