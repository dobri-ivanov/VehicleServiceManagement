
namespace VehicleServiceManagement
{
    partial class SearchVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchVehicle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.LabelCurrentClientData = new Bunifu.UI.WinForms.BunifuLabel();
            this.LabelTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.DataGridViewVehicles = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Get = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ButtonCloseApplication = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horsePowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensePlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.DimGray;
            this.bunifuPanel1.BorderRadius = 27;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.LabelCurrentClientData);
            this.bunifuPanel1.Controls.Add(this.LabelTitle);
            this.bunifuPanel1.Controls.Add(this.DataGridViewVehicles);
            this.bunifuPanel1.Controls.Add(this.ButtonCloseApplication);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1024, 479);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // LabelCurrentClientData
            // 
            this.LabelCurrentClientData.AllowParentOverrides = false;
            this.LabelCurrentClientData.AutoEllipsis = false;
            this.LabelCurrentClientData.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelCurrentClientData.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelCurrentClientData.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.LabelCurrentClientData.ForeColor = System.Drawing.Color.White;
            this.LabelCurrentClientData.Location = new System.Drawing.Point(12, 102);
            this.LabelCurrentClientData.Name = "LabelCurrentClientData";
            this.LabelCurrentClientData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelCurrentClientData.Size = new System.Drawing.Size(361, 37);
            this.LabelCurrentClientData.TabIndex = 13;
            this.LabelCurrentClientData.Text = "Иван Иванов | 0885452635";
            this.LabelCurrentClientData.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelCurrentClientData.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AllowParentOverrides = false;
            this.LabelTitle.AutoEllipsis = false;
            this.LabelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(381, 12);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelTitle.Size = new System.Drawing.Size(246, 54);
            this.LabelTitle.TabIndex = 12;
            this.LabelTitle.Text = "Автомобили";
            this.LabelTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DataGridViewVehicles
            // 
            this.DataGridViewVehicles.AllowCustomTheming = true;
            this.DataGridViewVehicles.AllowUserToAddRows = false;
            this.DataGridViewVehicles.AllowUserToDeleteRows = false;
            this.DataGridViewVehicles.AllowUserToOrderColumns = true;
            this.DataGridViewVehicles.AllowUserToResizeColumns = false;
            this.DataGridViewVehicles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewVehicles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewVehicles.AutoGenerateColumns = false;
            this.DataGridViewVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewVehicles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.DataGridViewVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewVehicles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.DataGridViewVehicles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.DataGridViewVehicles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewVehicles.ColumnHeadersHeight = 40;
            this.DataGridViewVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.horsePowerDataGridViewTextBoxColumn,
            this.licensePlateDataGridViewTextBoxColumn,
            this.Get});
            this.DataGridViewVehicles.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.DataGridViewVehicles.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DataGridViewVehicles.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewVehicles.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.DataGridViewVehicles.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewVehicles.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.DataGridViewVehicles.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.DataGridViewVehicles.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.DataGridViewVehicles.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DataGridViewVehicles.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewVehicles.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.DataGridViewVehicles.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewVehicles.CurrentTheme.Name = null;
            this.DataGridViewVehicles.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.DataGridViewVehicles.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DataGridViewVehicles.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewVehicles.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.DataGridViewVehicles.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewVehicles.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DataGridViewVehicles.DataSource = this.vehicleBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewVehicles.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewVehicles.EnableHeadersVisualStyles = false;
            this.DataGridViewVehicles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.DataGridViewVehicles.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.DataGridViewVehicles.HeaderBgColor = System.Drawing.Color.Empty;
            this.DataGridViewVehicles.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridViewVehicles.Location = new System.Drawing.Point(12, 145);
            this.DataGridViewVehicles.MaximumSize = new System.Drawing.Size(1000, 322);
            this.DataGridViewVehicles.MultiSelect = false;
            this.DataGridViewVehicles.Name = "DataGridViewVehicles";
            this.DataGridViewVehicles.ReadOnly = true;
            this.DataGridViewVehicles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridViewVehicles.RowHeadersVisible = false;
            this.DataGridViewVehicles.RowHeadersWidth = 50;
            this.DataGridViewVehicles.RowTemplate.Height = 40;
            this.DataGridViewVehicles.RowTemplate.ReadOnly = true;
            this.DataGridViewVehicles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewVehicles.Size = new System.Drawing.Size(1000, 322);
            this.DataGridViewVehicles.TabIndex = 11;
            this.DataGridViewVehicles.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Get
            // 
            this.Get.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Get.FillWeight = 25.38071F;
            this.Get.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Get.HeaderText = "";
            this.Get.Name = "Get";
            this.Get.ReadOnly = true;
            this.Get.Text = "➕";
            this.Get.ToolTipText = "Избери клиент";
            this.Get.UseColumnTextForButtonValue = true;
            this.Get.Width = 50;
            // 
            // ButtonCloseApplication
            // 
            this.ButtonCloseApplication.ActiveImage = null;
            this.ButtonCloseApplication.AllowAnimations = true;
            this.ButtonCloseApplication.AllowBuffering = false;
            this.ButtonCloseApplication.AllowToggling = false;
            this.ButtonCloseApplication.AllowZooming = true;
            this.ButtonCloseApplication.AllowZoomingOnFocus = false;
            this.ButtonCloseApplication.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCloseApplication.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonCloseApplication.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ButtonCloseApplication.ErrorImage")));
            this.ButtonCloseApplication.FadeWhenInactive = false;
            this.ButtonCloseApplication.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ButtonCloseApplication.Image = global::VehicleServiceManagement.Properties.Resources.close;
            this.ButtonCloseApplication.ImageActive = null;
            this.ButtonCloseApplication.ImageLocation = null;
            this.ButtonCloseApplication.ImageMargin = 0;
            this.ButtonCloseApplication.ImageSize = new System.Drawing.Size(34, 33);
            this.ButtonCloseApplication.ImageZoomSize = new System.Drawing.Size(35, 34);
            this.ButtonCloseApplication.InitialImage = ((System.Drawing.Image)(resources.GetObject("ButtonCloseApplication.InitialImage")));
            this.ButtonCloseApplication.Location = new System.Drawing.Point(977, 12);
            this.ButtonCloseApplication.Name = "ButtonCloseApplication";
            this.ButtonCloseApplication.Rotation = 0;
            this.ButtonCloseApplication.ShowActiveImage = true;
            this.ButtonCloseApplication.ShowCursorChanges = true;
            this.ButtonCloseApplication.ShowImageBorders = true;
            this.ButtonCloseApplication.ShowSizeMarkers = false;
            this.ButtonCloseApplication.Size = new System.Drawing.Size(35, 34);
            this.ButtonCloseApplication.TabIndex = 10;
            this.ButtonCloseApplication.ToolTipText = "";
            this.ButtonCloseApplication.WaitOnLoad = false;
            this.ButtonCloseApplication.Zoom = 0;
            this.ButtonCloseApplication.ZoomSpeed = 10;
            this.ButtonCloseApplication.Click += new System.EventHandler(this.ButtonCloseApplication_Click_3);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            this.makeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модел";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Година";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Кубатура";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horsePowerDataGridViewTextBoxColumn
            // 
            this.horsePowerDataGridViewTextBoxColumn.DataPropertyName = "HorsePower";
            this.horsePowerDataGridViewTextBoxColumn.HeaderText = "Конски сили";
            this.horsePowerDataGridViewTextBoxColumn.Name = "horsePowerDataGridViewTextBoxColumn";
            this.horsePowerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licensePlateDataGridViewTextBoxColumn
            // 
            this.licensePlateDataGridViewTextBoxColumn.DataPropertyName = "LicensePlate";
            this.licensePlateDataGridViewTextBoxColumn.HeaderText = "Рег. Номер";
            this.licensePlateDataGridViewTextBoxColumn.Name = "licensePlateDataGridViewTextBoxColumn";
            this.licensePlateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(VehicleServiceManagement.Vehicle);
            // 
            // SearchVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1024, 479);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchVehicle";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel LabelCurrentClientData;
        private Bunifu.UI.WinForms.BunifuLabel LabelTitle;
        private Bunifu.UI.WinForms.BunifuDataGridView DataGridViewVehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horsePowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Get;
        private Bunifu.UI.WinForms.BunifuImageButton ButtonCloseApplication;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}