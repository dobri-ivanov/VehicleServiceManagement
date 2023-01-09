
namespace VehicleServiceManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.Panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.PictureBoxLogo = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.TextBoxUsername = new Bunifu.UI.WinForms.BunifuTextBox();
            this.LabelUsername = new Bunifu.UI.WinForms.BunifuLabel();
            this.ButtonExit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TextBoxPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.LabelPassword = new Bunifu.UI.WinForms.BunifuLabel();
            this.ButtonLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CheckBoxShowPassword = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.DragPanel2 = new System.Windows.Forms.Panel();
            this.Notification = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel.BackgroundImage")));
            this.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel.BorderColor = System.Drawing.Color.Transparent;
            this.Panel.BorderRadius = 3;
            this.Panel.BorderThickness = 1;
            this.Panel.Controls.Add(this.DragPanel);
            this.Panel.Controls.Add(this.bunifuPanel1);
            this.Panel.Controls.Add(this.PictureBoxLogo);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.ShowBorders = true;
            this.Panel.Size = new System.Drawing.Size(573, 619);
            this.Panel.TabIndex = 0;
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.Transparent;
            this.DragPanel.Location = new System.Drawing.Point(3, 3);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(574, 93);
            this.DragPanel.TabIndex = 11;
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Location = new System.Drawing.Point(576, 3);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(463, 93);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.AllowFocused = false;
            this.PictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBoxLogo.AutoSizeHeight = true;
            this.PictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.PictureBoxLogo.BorderRadius = 208;
            this.PictureBoxLogo.Image = global::VehicleServiceManagement.Properties.Resources.Logo_DjoniAuto;
            this.PictureBoxLogo.IsCircle = true;
            this.PictureBoxLogo.Location = new System.Drawing.Point(77, 99);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(417, 417);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            this.PictureBoxLogo.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.AcceptsReturn = false;
            this.TextBoxUsername.AcceptsTab = false;
            this.TextBoxUsername.AnimationSpeed = 200;
            this.TextBoxUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.TextBoxUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBoxUsername.BackgroundImage")));
            this.TextBoxUsername.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.TextBoxUsername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TextBoxUsername.BorderColorHover = System.Drawing.Color.White;
            this.TextBoxUsername.BorderColorIdle = System.Drawing.Color.Silver;
            this.TextBoxUsername.BorderRadius = 5;
            this.TextBoxUsername.BorderThickness = 2;
            this.TextBoxUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUsername.DefaultFont = new System.Drawing.Font("Segoe UI", 20F);
            this.TextBoxUsername.DefaultText = "";
            this.TextBoxUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.TextBoxUsername.ForeColor = System.Drawing.Color.White;
            this.TextBoxUsername.HideSelection = true;
            this.TextBoxUsername.IconLeft = null;
            this.TextBoxUsername.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUsername.IconPadding = 10;
            this.TextBoxUsername.IconRight = null;
            this.TextBoxUsername.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUsername.Lines = new string[0];
            this.TextBoxUsername.Location = new System.Drawing.Point(620, 168);
            this.TextBoxUsername.MaxLength = 32767;
            this.TextBoxUsername.MinimumSize = new System.Drawing.Size(1, 1);
            this.TextBoxUsername.Modified = false;
            this.TextBoxUsername.Multiline = false;
            this.TextBoxUsername.Name = "TextBoxUsername";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxUsername.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextBoxUsername.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.White;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxUsername.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxUsername.OnIdleState = stateProperties4;
            this.TextBoxUsername.Padding = new System.Windows.Forms.Padding(3);
            this.TextBoxUsername.PasswordChar = '\0';
            this.TextBoxUsername.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextBoxUsername.PlaceholderText = "Въведете потребител";
            this.TextBoxUsername.ReadOnly = false;
            this.TextBoxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxUsername.SelectedText = "";
            this.TextBoxUsername.SelectionLength = 0;
            this.TextBoxUsername.SelectionStart = 0;
            this.TextBoxUsername.ShortcutsEnabled = true;
            this.TextBoxUsername.Size = new System.Drawing.Size(419, 64);
            this.TextBoxUsername.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.TextBoxUsername.TabIndex = 1;
            this.TextBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxUsername.TextMarginBottom = 0;
            this.TextBoxUsername.TextMarginLeft = 3;
            this.TextBoxUsername.TextMarginTop = 0;
            this.TextBoxUsername.TextPlaceholder = "Въведете потребител";
            this.TextBoxUsername.UseSystemPasswordChar = false;
            this.TextBoxUsername.WordWrap = true;
            this.TextBoxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUsername_KeyPress);
            // 
            // LabelUsername
            // 
            this.LabelUsername.AllowParentOverrides = false;
            this.LabelUsername.AutoEllipsis = false;
            this.LabelUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelUsername.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.LabelUsername.ForeColor = System.Drawing.Color.White;
            this.LabelUsername.Location = new System.Drawing.Point(620, 137);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelUsername.Size = new System.Drawing.Size(124, 25);
            this.LabelUsername.TabIndex = 3;
            this.LabelUsername.Text = "ПОТРЕБИТЕЛ";
            this.LabelUsername.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelUsername.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ButtonExit
            // 
            this.ButtonExit.ActiveImage = null;
            this.ButtonExit.AllowAnimations = true;
            this.ButtonExit.AllowBuffering = false;
            this.ButtonExit.AllowToggling = false;
            this.ButtonExit.AllowZooming = true;
            this.ButtonExit.AllowZoomingOnFocus = false;
            this.ButtonExit.BackColor = System.Drawing.Color.Transparent;
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonExit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ButtonExit.ErrorImage")));
            this.ButtonExit.FadeWhenInactive = false;
            this.ButtonExit.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ButtonExit.Image = global::VehicleServiceManagement.Properties.Resources.exit_icon;
            this.ButtonExit.ImageActive = null;
            this.ButtonExit.ImageLocation = null;
            this.ButtonExit.ImageMargin = 12;
            this.ButtonExit.ImageSize = new System.Drawing.Size(43, 39);
            this.ButtonExit.ImageZoomSize = new System.Drawing.Size(55, 51);
            this.ButtonExit.InitialImage = ((System.Drawing.Image)(resources.GetObject("ButtonExit.InitialImage")));
            this.ButtonExit.Location = new System.Drawing.Point(1033, 12);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Rotation = 0;
            this.ButtonExit.ShowActiveImage = true;
            this.ButtonExit.ShowCursorChanges = true;
            this.ButtonExit.ShowImageBorders = true;
            this.ButtonExit.ShowSizeMarkers = false;
            this.ButtonExit.Size = new System.Drawing.Size(55, 51);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.ToolTipText = "";
            this.ButtonExit.WaitOnLoad = false;
            this.ButtonExit.Zoom = 12;
            this.ButtonExit.ZoomSpeed = 10;
            this.ButtonExit.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 15;
            this.Elipse.TargetControl = this;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.AcceptsReturn = false;
            this.TextBoxPassword.AcceptsTab = false;
            this.TextBoxPassword.AnimationSpeed = 200;
            this.TextBoxPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.TextBoxPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBoxPassword.BackgroundImage")));
            this.TextBoxPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.TextBoxPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TextBoxPassword.BorderColorHover = System.Drawing.Color.White;
            this.TextBoxPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.TextBoxPassword.BorderRadius = 5;
            this.TextBoxPassword.BorderThickness = 2;
            this.TextBoxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 20F);
            this.TextBoxPassword.DefaultText = "";
            this.TextBoxPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.TextBoxPassword.ForeColor = System.Drawing.Color.White;
            this.TextBoxPassword.HideSelection = true;
            this.TextBoxPassword.IconLeft = null;
            this.TextBoxPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.IconPadding = 10;
            this.TextBoxPassword.IconRight = null;
            this.TextBoxPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.Lines = new string[0];
            this.TextBoxPassword.Location = new System.Drawing.Point(620, 330);
            this.TextBoxPassword.MaxLength = 32767;
            this.TextBoxPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.TextBoxPassword.Modified = false;
            this.TextBoxPassword.Multiline = false;
            this.TextBoxPassword.Name = "TextBoxPassword";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxPassword.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextBoxPassword.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.White;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxPassword.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxPassword.OnIdleState = stateProperties8;
            this.TextBoxPassword.Padding = new System.Windows.Forms.Padding(3);
            this.TextBoxPassword.PasswordChar = '\0';
            this.TextBoxPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextBoxPassword.PlaceholderText = "Въведете парола";
            this.TextBoxPassword.ReadOnly = false;
            this.TextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxPassword.SelectedText = "";
            this.TextBoxPassword.SelectionLength = 0;
            this.TextBoxPassword.SelectionStart = 0;
            this.TextBoxPassword.ShortcutsEnabled = true;
            this.TextBoxPassword.Size = new System.Drawing.Size(419, 64);
            this.TextBoxPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.TextBoxPassword.TabIndex = 5;
            this.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxPassword.TextMarginBottom = 0;
            this.TextBoxPassword.TextMarginLeft = 3;
            this.TextBoxPassword.TextMarginTop = 0;
            this.TextBoxPassword.TextPlaceholder = "Въведете парола";
            this.TextBoxPassword.UseSystemPasswordChar = false;
            this.TextBoxPassword.WordWrap = true;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            this.TextBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AllowParentOverrides = false;
            this.LabelPassword.AutoEllipsis = false;
            this.LabelPassword.CursorType = null;
            this.LabelPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.LabelPassword.ForeColor = System.Drawing.Color.White;
            this.LabelPassword.Location = new System.Drawing.Point(620, 299);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelPassword.Size = new System.Drawing.Size(81, 25);
            this.LabelPassword.TabIndex = 6;
            this.LabelPassword.Text = "ПАРОЛА";
            this.LabelPassword.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelPassword.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.ActiveBorderThickness = 1;
            this.ButtonLogin.ActiveCornerRadius = 20;
            this.ButtonLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.ButtonLogin.ActiveForecolor = System.Drawing.Color.Black;
            this.ButtonLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.ButtonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonLogin.BackgroundImage")));
            this.ButtonLogin.ButtonText = "ВХОД";
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.Gray;
            this.ButtonLogin.IdleBorderThickness = 2;
            this.ButtonLogin.IdleCornerRadius = 20;
            this.ButtonLogin.IdleFillColor = System.Drawing.Color.Transparent;
            this.ButtonLogin.IdleForecolor = System.Drawing.Color.White;
            this.ButtonLogin.IdleLineColor = System.Drawing.Color.Silver;
            this.ButtonLogin.Location = new System.Drawing.Point(858, 524);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(181, 49);
            this.ButtonLogin.TabIndex = 7;
            this.ButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // CheckBoxShowPassword
            // 
            this.CheckBoxShowPassword.AllowBindingControlAnimation = true;
            this.CheckBoxShowPassword.AllowBindingControlColorChanges = false;
            this.CheckBoxShowPassword.AllowBindingControlLocation = true;
            this.CheckBoxShowPassword.AllowCheckBoxAnimation = false;
            this.CheckBoxShowPassword.AllowCheckmarkAnimation = true;
            this.CheckBoxShowPassword.AllowOnHoverStates = true;
            this.CheckBoxShowPassword.AutoCheck = true;
            this.CheckBoxShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxShowPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckBoxShowPassword.BackgroundImage")));
            this.CheckBoxShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckBoxShowPassword.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.CheckBoxShowPassword.BorderRadius = 12;
            this.CheckBoxShowPassword.Checked = false;
            this.CheckBoxShowPassword.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.CheckBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckBoxShowPassword.CustomCheckmarkImage = null;
            this.CheckBoxShowPassword.Enabled = false;
            this.CheckBoxShowPassword.Location = new System.Drawing.Point(629, 400);
            this.CheckBoxShowPassword.MinimumSize = new System.Drawing.Size(17, 17);
            this.CheckBoxShowPassword.Name = "CheckBoxShowPassword";
            this.CheckBoxShowPassword.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.CheckBoxShowPassword.OnCheck.BorderRadius = 12;
            this.CheckBoxShowPassword.OnCheck.BorderThickness = 2;
            this.CheckBoxShowPassword.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.CheckBoxShowPassword.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.CheckBoxShowPassword.OnCheck.CheckmarkThickness = 2;
            this.CheckBoxShowPassword.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.CheckBoxShowPassword.OnDisable.BorderRadius = 12;
            this.CheckBoxShowPassword.OnDisable.BorderThickness = 2;
            this.CheckBoxShowPassword.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckBoxShowPassword.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.CheckBoxShowPassword.OnDisable.CheckmarkThickness = 2;
            this.CheckBoxShowPassword.OnHoverChecked.BorderColor = System.Drawing.Color.Silver;
            this.CheckBoxShowPassword.OnHoverChecked.BorderRadius = 12;
            this.CheckBoxShowPassword.OnHoverChecked.BorderThickness = 2;
            this.CheckBoxShowPassword.OnHoverChecked.CheckBoxColor = System.Drawing.Color.Silver;
            this.CheckBoxShowPassword.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.CheckBoxShowPassword.OnHoverChecked.CheckmarkThickness = 2;
            this.CheckBoxShowPassword.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.CheckBoxShowPassword.OnHoverUnchecked.BorderRadius = 12;
            this.CheckBoxShowPassword.OnHoverUnchecked.BorderThickness = 2;
            this.CheckBoxShowPassword.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckBoxShowPassword.OnUncheck.BorderColor = System.Drawing.Color.Silver;
            this.CheckBoxShowPassword.OnUncheck.BorderRadius = 12;
            this.CheckBoxShowPassword.OnUncheck.BorderThickness = 2;
            this.CheckBoxShowPassword.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckBoxShowPassword.Size = new System.Drawing.Size(29, 29);
            this.CheckBoxShowPassword.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.CheckBoxShowPassword.TabIndex = 8;
            this.CheckBoxShowPassword.ThreeState = false;
            this.CheckBoxShowPassword.ToolTipText = null;
            this.CheckBoxShowPassword.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.bunifuCheckBox1_CheckedChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(664, 402);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(148, 25);
            this.bunifuLabel1.TabIndex = 9;
            this.bunifuLabel1.Text = "Покажи парола";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DragPanel2
            // 
            this.DragPanel2.BackColor = System.Drawing.Color.Transparent;
            this.DragPanel2.Location = new System.Drawing.Point(576, 3);
            this.DragPanel2.Name = "DragPanel2";
            this.DragPanel2.Size = new System.Drawing.Size(460, 93);
            this.DragPanel2.TabIndex = 12;
            this.DragPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.DragPanel2_Paint);
            this.DragPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // Notification
            // 
            this.Notification.AllowDragging = false;
            this.Notification.AllowMultipleViews = true;
            this.Notification.ClickToClose = true;
            this.Notification.DoubleClickToClose = true;
            this.Notification.DurationAfterIdle = 3000;
            this.Notification.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notification.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notification.ErrorOptions.ActionBorderRadius = 1;
            this.Notification.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Notification.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Notification.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.Notification.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.Notification.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.Notification.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Notification.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.Notification.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.Notification.ErrorOptions.IconLeftMargin = 12;
            this.Notification.FadeCloseIcon = false;
            this.Notification.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.Notification.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.Notification.InformationOptions.ActionBorderColor = System.Drawing.Color.White;
            this.Notification.InformationOptions.ActionBorderRadius = 25;
            this.Notification.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Notification.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Notification.InformationOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.Notification.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.Notification.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.Notification.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Notification.InformationOptions.ForeColor = System.Drawing.Color.White;
            this.Notification.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.Notification.InformationOptions.IconLeftMargin = 12;
            this.Notification.Margin = 62;
            this.Notification.MaximumSize = new System.Drawing.Size(0, 0);
            this.Notification.MaximumViews = 7;
            this.Notification.MessageRightMargin = 10;
            this.Notification.MinimumSize = new System.Drawing.Size(0, 0);
            this.Notification.ShowBorders = true;
            this.Notification.ShowCloseIcon = false;
            this.Notification.ShowIcon = true;
            this.Notification.ShowShadows = true;
            this.Notification.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notification.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notification.SuccessOptions.ActionBorderRadius = 1;
            this.Notification.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Notification.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Notification.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.Notification.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.Notification.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.Notification.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Notification.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.Notification.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.Notification.SuccessOptions.IconLeftMargin = 12;
            this.Notification.ViewsMargin = 7;
            this.Notification.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Notification.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notification.WarningOptions.ActionBorderRadius = 1;
            this.Notification.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Notification.WarningOptions.ActionForeColor = System.Drawing.Color.White;
            this.Notification.WarningOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Notification.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.Notification.WarningOptions.CloseIconColor = System.Drawing.Color.White;
            this.Notification.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Notification.WarningOptions.ForeColor = System.Drawing.Color.White;
            this.Notification.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.Notification.WarningOptions.IconLeftMargin = 12;
            this.Notification.ZoomCloseIcon = true;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.DragPanel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.CheckBoxShowPassword);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.Panel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel Panel;
        private Bunifu.UI.WinForms.BunifuPictureBox PictureBoxLogo;
        private Bunifu.UI.WinForms.BunifuTextBox TextBoxUsername;
        private Bunifu.UI.WinForms.BunifuLabel LabelUsername;
        private Bunifu.UI.WinForms.BunifuImageButton ButtonExit;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuTextBox TextBoxPassword;
        private Bunifu.UI.WinForms.BunifuLabel LabelPassword;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonLogin;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuCheckBox CheckBoxShowPassword;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.Panel DragPanel2;
        private Bunifu.UI.WinForms.BunifuSnackbar Notification;
    }
}