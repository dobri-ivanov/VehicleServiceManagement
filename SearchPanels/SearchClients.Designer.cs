
namespace VehicleServiceManagement
{
    partial class SearchClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchClients));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.TextBoxSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.ButtonCloseApplication = new Bunifu.UI.WinForms.BunifuImageButton();
            this.LabelTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.DataGridViewClients = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Get = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackgroundColor = System.Drawing.Color.Transparent;
            this.Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel.BackgroundImage")));
            this.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel.BorderColor = System.Drawing.Color.Silver;
            this.Panel.BorderRadius = 3;
            this.Panel.BorderThickness = 1;
            this.Panel.Controls.Add(this.TextBoxSearch);
            this.Panel.Controls.Add(this.ButtonCloseApplication);
            this.Panel.Controls.Add(this.LabelTitle);
            this.Panel.Controls.Add(this.DataGridViewClients);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.ShowBorders = true;
            this.Panel.Size = new System.Drawing.Size(844, 531);
            this.Panel.TabIndex = 0;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.AcceptsReturn = false;
            this.TextBoxSearch.AcceptsTab = false;
            this.TextBoxSearch.AnimationSpeed = 200;
            this.TextBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBoxSearch.BackgroundImage")));
            this.TextBoxSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TextBoxSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TextBoxSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TextBoxSearch.BorderColorIdle = System.Drawing.Color.White;
            this.TextBoxSearch.BorderRadius = 35;
            this.TextBoxSearch.BorderThickness = 1;
            this.TextBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 13F);
            this.TextBoxSearch.DefaultText = "";
            this.TextBoxSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.TextBoxSearch.ForeColor = System.Drawing.Color.White;
            this.TextBoxSearch.HideSelection = true;
            this.TextBoxSearch.IconLeft = null;
            this.TextBoxSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.IconPadding = 10;
            this.TextBoxSearch.IconRight = null;
            this.TextBoxSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.Lines = new string[0];
            this.TextBoxSearch.Location = new System.Drawing.Point(12, 72);
            this.TextBoxSearch.MaxLength = 32767;
            this.TextBoxSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.TextBoxSearch.Modified = false;
            this.TextBoxSearch.Multiline = false;
            this.TextBoxSearch.Name = "TextBoxSearch";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextBoxSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxSearch.OnIdleState = stateProperties4;
            this.TextBoxSearch.Padding = new System.Windows.Forms.Padding(3);
            this.TextBoxSearch.PasswordChar = '\0';
            this.TextBoxSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextBoxSearch.PlaceholderText = "Търсене на клиенти";
            this.TextBoxSearch.ReadOnly = false;
            this.TextBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxSearch.SelectedText = "";
            this.TextBoxSearch.SelectionLength = 0;
            this.TextBoxSearch.SelectionStart = 0;
            this.TextBoxSearch.ShortcutsEnabled = true;
            this.TextBoxSearch.Size = new System.Drawing.Size(409, 44);
            this.TextBoxSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TextBoxSearch.TabIndex = 8;
            this.TextBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxSearch.TextMarginBottom = 0;
            this.TextBoxSearch.TextMarginLeft = 3;
            this.TextBoxSearch.TextMarginTop = 0;
            this.TextBoxSearch.TextPlaceholder = "Търсене на клиенти";
            this.TextBoxSearch.UseSystemPasswordChar = false;
            this.TextBoxSearch.WordWrap = true;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
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
            this.ButtonCloseApplication.ImageSize = new System.Drawing.Size(39, 39);
            this.ButtonCloseApplication.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ButtonCloseApplication.InitialImage = ((System.Drawing.Image)(resources.GetObject("ButtonCloseApplication.InitialImage")));
            this.ButtonCloseApplication.Location = new System.Drawing.Point(792, 12);
            this.ButtonCloseApplication.Name = "ButtonCloseApplication";
            this.ButtonCloseApplication.Rotation = 0;
            this.ButtonCloseApplication.ShowActiveImage = true;
            this.ButtonCloseApplication.ShowCursorChanges = true;
            this.ButtonCloseApplication.ShowImageBorders = true;
            this.ButtonCloseApplication.ShowSizeMarkers = false;
            this.ButtonCloseApplication.Size = new System.Drawing.Size(40, 40);
            this.ButtonCloseApplication.TabIndex = 7;
            this.ButtonCloseApplication.ToolTipText = "";
            this.ButtonCloseApplication.WaitOnLoad = false;
            this.ButtonCloseApplication.Zoom = 0;
            this.ButtonCloseApplication.ZoomSpeed = 10;
            this.ButtonCloseApplication.Click += new System.EventHandler(this.ButtonCloseApplication_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AllowParentOverrides = false;
            this.LabelTitle.AutoEllipsis = false;
            this.LabelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(345, 12);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelTitle.Size = new System.Drawing.Size(164, 54);
            this.LabelTitle.TabIndex = 6;
            this.LabelTitle.Text = "Клиенти";
            this.LabelTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DataGridViewClients
            // 
            this.DataGridViewClients.AllowCustomTheming = true;
            this.DataGridViewClients.AllowUserToAddRows = false;
            this.DataGridViewClients.AllowUserToDeleteRows = false;
            this.DataGridViewClients.AllowUserToOrderColumns = true;
            this.DataGridViewClients.AllowUserToResizeColumns = false;
            this.DataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewClients.AutoGenerateColumns = false;
            this.DataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.DataGridViewClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.DataGridViewClients.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.DataGridViewClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewClients.ColumnHeadersHeight = 40;
            this.DataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.nicknameDataGridViewTextBoxColumn,
            this.Get});
            this.DataGridViewClients.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.DataGridViewClients.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DataGridViewClients.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewClients.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.DataGridViewClients.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewClients.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.DataGridViewClients.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.DataGridViewClients.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.DataGridViewClients.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DataGridViewClients.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewClients.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.DataGridViewClients.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewClients.CurrentTheme.Name = null;
            this.DataGridViewClients.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.DataGridViewClients.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DataGridViewClients.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewClients.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.DataGridViewClients.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewClients.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridViewClients.DataSource = this.clientBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewClients.EnableHeadersVisualStyles = false;
            this.DataGridViewClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.DataGridViewClients.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.DataGridViewClients.HeaderBgColor = System.Drawing.Color.Empty;
            this.DataGridViewClients.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridViewClients.Location = new System.Drawing.Point(12, 122);
            this.DataGridViewClients.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.DataGridViewClients.MultiSelect = false;
            this.DataGridViewClients.Name = "DataGridViewClients";
            this.DataGridViewClients.ReadOnly = true;
            this.DataGridViewClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridViewClients.RowHeadersVisible = false;
            this.DataGridViewClients.RowHeadersWidth = 50;
            this.DataGridViewClients.RowTemplate.Height = 40;
            this.DataGridViewClients.RowTemplate.ReadOnly = true;
            this.DataGridViewClients.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewClients.Size = new System.Drawing.Size(820, 397);
            this.DataGridViewClients.TabIndex = 5;
            this.DataGridViewClients.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.DataGridViewClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewClients_CellContentClick);
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Име";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Телефонен номер";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            this.nicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.HeaderText = "Прякор";
            this.nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
            this.nicknameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(VehicleServiceManagement.Client);
            // 
            // SearchClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(844, 531);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchClients";
            this.TopMost = true;
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel Panel;
        private Bunifu.UI.WinForms.BunifuDataGridView DataGridViewClients;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private Bunifu.UI.WinForms.BunifuLabel LabelTitle;
        private Bunifu.UI.WinForms.BunifuImageButton ButtonCloseApplication;
        private Bunifu.UI.WinForms.BunifuTextBox TextBoxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Get;
    }
}