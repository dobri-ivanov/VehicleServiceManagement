
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.ButtonCloseApplication = new Bunifu.UI.WinForms.BunifuImageButton();
            this.LabelTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.ButtonAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LabelClientData = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
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
            this.Panel.Controls.Add(this.ButtonCloseApplication);
            this.Panel.Controls.Add(this.LabelTitle);
            this.Panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.ShowBorders = true;
            this.Panel.Size = new System.Drawing.Size(950, 64);
            this.Panel.TabIndex = 0;
            this.Panel.Click += new System.EventHandler(this.Panel_Click);
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
            this.ButtonCloseApplication.ImageSize = new System.Drawing.Size(34, 34);
            this.ButtonCloseApplication.ImageZoomSize = new System.Drawing.Size(35, 35);
            this.ButtonCloseApplication.InitialImage = ((System.Drawing.Image)(resources.GetObject("ButtonCloseApplication.InitialImage")));
            this.ButtonCloseApplication.Location = new System.Drawing.Point(912, 3);
            this.ButtonCloseApplication.Name = "ButtonCloseApplication";
            this.ButtonCloseApplication.Rotation = 0;
            this.ButtonCloseApplication.ShowActiveImage = true;
            this.ButtonCloseApplication.ShowCursorChanges = true;
            this.ButtonCloseApplication.ShowImageBorders = true;
            this.ButtonCloseApplication.ShowSizeMarkers = false;
            this.ButtonCloseApplication.Size = new System.Drawing.Size(35, 35);
            this.ButtonCloseApplication.TabIndex = 1;
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
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(12, 12);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelTitle.Size = new System.Drawing.Size(168, 37);
            this.LabelTitle.TabIndex = 6;
            this.LabelTitle.Text = "Автомобили";
            this.LabelTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.AllowAnimations = true;
            this.ButtonAdd.AllowMouseEffects = true;
            this.ButtonAdd.AllowToggling = false;
            this.ButtonAdd.AnimationSpeed = 200;
            this.ButtonAdd.AutoGenerateColors = false;
            this.ButtonAdd.AutoRoundBorders = false;
            this.ButtonAdd.AutoSizeLeftIcon = true;
            this.ButtonAdd.AutoSizeRightIcon = true;
            this.ButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAdd.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.ButtonAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.BackgroundImage")));
            this.ButtonAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonAdd.ButtonText = "ДОБАВИ";
            this.ButtonAdd.ButtonTextMarginLeft = 0;
            this.ButtonAdd.ColorContrastOnClick = 45;
            this.ButtonAdd.ColorContrastOnHover = 45;
            this.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ButtonAdd.CustomizableEdges = borderEdges1;
            this.ButtonAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonAdd.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonAdd.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ButtonAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAdd.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ButtonAdd.IconMarginLeft = 11;
            this.ButtonAdd.IconPadding = 10;
            this.ButtonAdd.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAdd.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ButtonAdd.IconSize = 25;
            this.ButtonAdd.IdleBorderColor = System.Drawing.Color.Black;
            this.ButtonAdd.IdleBorderRadius = 30;
            this.ButtonAdd.IdleBorderThickness = 1;
            this.ButtonAdd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.ButtonAdd.IdleIconLeftImage = global::VehicleServiceManagement.Properties.Resources.plus;
            this.ButtonAdd.IdleIconRightImage = null;
            this.ButtonAdd.IndicateFocus = false;
            this.ButtonAdd.Location = new System.Drawing.Point(794, 70);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonAdd.OnDisabledState.BorderRadius = 30;
            this.ButtonAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonAdd.OnDisabledState.BorderThickness = 1;
            this.ButtonAdd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonAdd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ButtonAdd.OnDisabledState.IconLeftImage = null;
            this.ButtonAdd.OnDisabledState.IconRightImage = null;
            this.ButtonAdd.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.ButtonAdd.onHoverState.BorderRadius = 30;
            this.ButtonAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonAdd.onHoverState.BorderThickness = 1;
            this.ButtonAdd.onHoverState.FillColor = System.Drawing.Color.LimeGreen;
            this.ButtonAdd.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.onHoverState.IconLeftImage = null;
            this.ButtonAdd.onHoverState.IconRightImage = null;
            this.ButtonAdd.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.ButtonAdd.OnIdleState.BorderRadius = 30;
            this.ButtonAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonAdd.OnIdleState.BorderThickness = 1;
            this.ButtonAdd.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.ButtonAdd.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.OnIdleState.IconLeftImage = global::VehicleServiceManagement.Properties.Resources.plus;
            this.ButtonAdd.OnIdleState.IconRightImage = null;
            this.ButtonAdd.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.ButtonAdd.OnPressedState.BorderRadius = 30;
            this.ButtonAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonAdd.OnPressedState.BorderThickness = 1;
            this.ButtonAdd.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.ButtonAdd.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.OnPressedState.IconLeftImage = null;
            this.ButtonAdd.OnPressedState.IconRightImage = null;
            this.ButtonAdd.Size = new System.Drawing.Size(144, 44);
            this.ButtonAdd.TabIndex = 8;
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonAdd.TextMarginLeft = 0;
            this.ButtonAdd.TextPadding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonAdd.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Panel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // LabelClientData
            // 
            this.LabelClientData.AllowParentOverrides = false;
            this.LabelClientData.AutoEllipsis = false;
            this.LabelClientData.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelClientData.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelClientData.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.LabelClientData.ForeColor = System.Drawing.Color.White;
            this.LabelClientData.Location = new System.Drawing.Point(12, 84);
            this.LabelClientData.Name = "LabelClientData";
            this.LabelClientData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelClientData.Size = new System.Drawing.Size(276, 30);
            this.LabelClientData.TabIndex = 7;
            this.LabelClientData.Text = "Иван Иванов | 0885426587";
            this.LabelClientData.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelClientData.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(229, 238);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(240, 150);
            this.bunifuDataGridView1.TabIndex = 9;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // SearchVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(950, 480);
            this.Controls.Add(this.bunifuDataGridView1);
            this.Controls.Add(this.LabelClientData);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchVehicle";
            this.TopMost = true;
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel Panel;
        private Bunifu.UI.WinForms.BunifuImageButton ButtonCloseApplication;
        private Bunifu.UI.WinForms.BunifuLabel LabelTitle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ButtonAdd;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuLabel LabelClientData;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
    }
}