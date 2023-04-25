
namespace VehicleServiceManagement.ReportsInteraction
{
    partial class SearchVehicleForReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchVehicleForReport));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.ButtonRefreshVehicles = new Bunifu.UI.WinForms.BunifuImageButton();
            this.TextBoxSearchVehicles = new Bunifu.UI.WinForms.BunifuTextBox();
            this.LabelTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.DataGridViewVehicles = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horsePowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensePlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetVehicle = new System.Windows.Forms.DataGridViewImageColumn();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonCloseApplication = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuPanel1.BorderRadius = 28;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.ButtonRefreshVehicles);
            this.bunifuPanel1.Controls.Add(this.TextBoxSearchVehicles);
            this.bunifuPanel1.Controls.Add(this.LabelTitle);
            this.bunifuPanel1.Controls.Add(this.DataGridViewVehicles);
            this.bunifuPanel1.Controls.Add(this.ButtonCloseApplication);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1008, 440);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // ButtonRefreshVehicles
            // 
            this.ButtonRefreshVehicles.ActiveImage = null;
            this.ButtonRefreshVehicles.AllowAnimations = true;
            this.ButtonRefreshVehicles.AllowBuffering = false;
            this.ButtonRefreshVehicles.AllowToggling = false;
            this.ButtonRefreshVehicles.AllowZooming = true;
            this.ButtonRefreshVehicles.AllowZoomingOnFocus = false;
            this.ButtonRefreshVehicles.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRefreshVehicles.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonRefreshVehicles.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ButtonRefreshVehicles.ErrorImage")));
            this.ButtonRefreshVehicles.FadeWhenInactive = false;
            this.ButtonRefreshVehicles.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ButtonRefreshVehicles.Image = global::VehicleServiceManagement.Properties.Resources.refresh;
            this.ButtonRefreshVehicles.ImageActive = null;
            this.ButtonRefreshVehicles.ImageLocation = null;
            this.ButtonRefreshVehicles.ImageMargin = 10;
            this.ButtonRefreshVehicles.ImageSize = new System.Drawing.Size(41, 41);
            this.ButtonRefreshVehicles.ImageZoomSize = new System.Drawing.Size(51, 51);
            this.ButtonRefreshVehicles.InitialImage = ((System.Drawing.Image)(resources.GetObject("ButtonRefreshVehicles.InitialImage")));
            this.ButtonRefreshVehicles.Location = new System.Drawing.Point(420, 72);
            this.ButtonRefreshVehicles.Name = "ButtonRefreshVehicles";
            this.ButtonRefreshVehicles.Rotation = 0;
            this.ButtonRefreshVehicles.ShowActiveImage = true;
            this.ButtonRefreshVehicles.ShowCursorChanges = true;
            this.ButtonRefreshVehicles.ShowImageBorders = true;
            this.ButtonRefreshVehicles.ShowSizeMarkers = false;
            this.ButtonRefreshVehicles.Size = new System.Drawing.Size(51, 51);
            this.ButtonRefreshVehicles.TabIndex = 17;
            this.ButtonRefreshVehicles.Tag = "";
            this.ButtonRefreshVehicles.ToolTipText = " ";
            this.ButtonRefreshVehicles.WaitOnLoad = false;
            this.ButtonRefreshVehicles.Zoom = 10;
            this.ButtonRefreshVehicles.ZoomSpeed = 10;
            this.ButtonRefreshVehicles.Click += new System.EventHandler(this.ButtonRefreshVehicles_Click);
            // 
            // TextBoxSearchVehicles
            // 
            this.TextBoxSearchVehicles.AcceptsReturn = false;
            this.TextBoxSearchVehicles.AcceptsTab = false;
            this.TextBoxSearchVehicles.AnimationSpeed = 200;
            this.TextBoxSearchVehicles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxSearchVehicles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxSearchVehicles.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxSearchVehicles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBoxSearchVehicles.BackgroundImage")));
            this.TextBoxSearchVehicles.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TextBoxSearchVehicles.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TextBoxSearchVehicles.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TextBoxSearchVehicles.BorderColorIdle = System.Drawing.Color.White;
            this.TextBoxSearchVehicles.BorderRadius = 35;
            this.TextBoxSearchVehicles.BorderThickness = 1;
            this.TextBoxSearchVehicles.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxSearchVehicles.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearchVehicles.DefaultFont = new System.Drawing.Font("Segoe UI", 13F);
            this.TextBoxSearchVehicles.DefaultText = "";
            this.TextBoxSearchVehicles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.TextBoxSearchVehicles.ForeColor = System.Drawing.Color.White;
            this.TextBoxSearchVehicles.HideSelection = true;
            this.TextBoxSearchVehicles.IconLeft = null;
            this.TextBoxSearchVehicles.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearchVehicles.IconPadding = 10;
            this.TextBoxSearchVehicles.IconRight = null;
            this.TextBoxSearchVehicles.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearchVehicles.Lines = new string[0];
            this.TextBoxSearchVehicles.Location = new System.Drawing.Point(5, 72);
            this.TextBoxSearchVehicles.MaxLength = 32767;
            this.TextBoxSearchVehicles.MinimumSize = new System.Drawing.Size(1, 1);
            this.TextBoxSearchVehicles.Modified = false;
            this.TextBoxSearchVehicles.Multiline = false;
            this.TextBoxSearchVehicles.Name = "TextBoxSearchVehicles";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxSearchVehicles.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextBoxSearchVehicles.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxSearchVehicles.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxSearchVehicles.OnIdleState = stateProperties4;
            this.TextBoxSearchVehicles.Padding = new System.Windows.Forms.Padding(3);
            this.TextBoxSearchVehicles.PasswordChar = '\0';
            this.TextBoxSearchVehicles.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextBoxSearchVehicles.PlaceholderText = "Търсене на автомобили";
            this.TextBoxSearchVehicles.ReadOnly = false;
            this.TextBoxSearchVehicles.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxSearchVehicles.SelectedText = "";
            this.TextBoxSearchVehicles.SelectionLength = 0;
            this.TextBoxSearchVehicles.SelectionStart = 0;
            this.TextBoxSearchVehicles.ShortcutsEnabled = true;
            this.TextBoxSearchVehicles.Size = new System.Drawing.Size(409, 44);
            this.TextBoxSearchVehicles.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TextBoxSearchVehicles.TabIndex = 13;
            this.TextBoxSearchVehicles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxSearchVehicles.TextMarginBottom = 0;
            this.TextBoxSearchVehicles.TextMarginLeft = 3;
            this.TextBoxSearchVehicles.TextMarginTop = 0;
            this.TextBoxSearchVehicles.TextPlaceholder = "Търсене на автомобили";
            this.TextBoxSearchVehicles.UseSystemPasswordChar = false;
            this.TextBoxSearchVehicles.WordWrap = true;
            this.TextBoxSearchVehicles.TextChanged += new System.EventHandler(this.TextBoxSearchVehicles_TextChanged);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AllowParentOverrides = false;
            this.LabelTitle.AutoEllipsis = false;
            this.LabelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(390, 3);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelTitle.Size = new System.Drawing.Size(230, 50);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewVehicles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewVehicles.AutoGenerateColumns = false;
            this.DataGridViewVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewVehicles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.DataGridViewVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewVehicles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
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
            this.Owner,
            this.makeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.horsePowerDataGridViewTextBoxColumn,
            this.licensePlateDataGridViewTextBoxColumn,
            this.GetVehicle});
            this.DataGridViewVehicles.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
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
            this.DataGridViewVehicles.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.DataGridViewVehicles.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewVehicles.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DataGridViewVehicles.DataSource = this.vehicleBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewVehicles.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewVehicles.EnableHeadersVisualStyles = false;
            this.DataGridViewVehicles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.DataGridViewVehicles.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.DataGridViewVehicles.HeaderBgColor = System.Drawing.Color.Empty;
            this.DataGridViewVehicles.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridViewVehicles.Location = new System.Drawing.Point(5, 122);
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
            this.DataGridViewVehicles.Size = new System.Drawing.Size(1000, 306);
            this.DataGridViewVehicles.TabIndex = 11;
            this.DataGridViewVehicles.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.DataGridViewVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVehicles_CellContentClick);
            this.DataGridViewVehicles.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVehicles_CellMouseEnter);
            this.DataGridViewVehicles.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVehicles_CellMouseLeave);
            // 
            // Owner
            // 
            this.Owner.DataPropertyName = "FirstName";
            this.Owner.HeaderText = "Собственик";
            this.Owner.Name = "Owner";
            this.Owner.ReadOnly = true;
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
            this.licensePlateDataGridViewTextBoxColumn.HeaderText = "Рег.Номер";
            this.licensePlateDataGridViewTextBoxColumn.Name = "licensePlateDataGridViewTextBoxColumn";
            this.licensePlateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GetVehicle
            // 
            this.GetVehicle.FillWeight = 28.4264F;
            this.GetVehicle.HeaderText = "";
            this.GetVehicle.Image = global::VehicleServiceManagement.Properties.Resources.select_new;
            this.GetVehicle.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.GetVehicle.Name = "GetVehicle";
            this.GetVehicle.ReadOnly = true;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(VehicleServiceManagement.Vehicle);
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
            this.ButtonCloseApplication.Location = new System.Drawing.Point(961, 12);
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
            this.ButtonCloseApplication.Click += new System.EventHandler(this.ButtonCloseApplication_Click);
            // 
            // SearchVehicleForReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1008, 440);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchVehicleForReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchVehicleForReport";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel LabelTitle;
        private Bunifu.UI.WinForms.BunifuDataGridView DataGridViewVehicles;
        private Bunifu.UI.WinForms.BunifuImageButton ButtonCloseApplication;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private Bunifu.UI.WinForms.BunifuTextBox TextBoxSearchVehicles;
        private Bunifu.UI.WinForms.BunifuImageButton ButtonRefreshVehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horsePowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn GetVehicle;
    }
}