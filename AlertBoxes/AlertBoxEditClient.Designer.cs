
namespace VehicleServiceManagement
{
    partial class AlertBoxEditClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertBoxEditClient));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.AlerBoxDragPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.ButtonClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.LabelText = new Bunifu.UI.WinForms.BunifuLabel();
            this.ButtonNo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ButtonYes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1.SuspendLayout();
            this.AlerBoxDragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 0;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.AlerBoxDragPanel);
            this.bunifuPanel1.Controls.Add(this.LabelText);
            this.bunifuPanel1.Controls.Add(this.ButtonNo);
            this.bunifuPanel1.Controls.Add(this.ButtonYes);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(682, 265);
            this.bunifuPanel1.TabIndex = 3;
            // 
            // AlerBoxDragPanel
            // 
            this.AlerBoxDragPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.AlerBoxDragPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AlerBoxDragPanel.BackgroundImage")));
            this.AlerBoxDragPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlerBoxDragPanel.BorderColor = System.Drawing.Color.Transparent;
            this.AlerBoxDragPanel.BorderRadius = 0;
            this.AlerBoxDragPanel.BorderThickness = 0;
            this.AlerBoxDragPanel.Controls.Add(this.bunifuLabel1);
            this.AlerBoxDragPanel.Controls.Add(this.ButtonClose);
            this.AlerBoxDragPanel.Location = new System.Drawing.Point(3, 3);
            this.AlerBoxDragPanel.Name = "AlerBoxDragPanel";
            this.AlerBoxDragPanel.ShowBorders = false;
            this.AlerBoxDragPanel.Size = new System.Drawing.Size(676, 58);
            this.AlerBoxDragPanel.TabIndex = 11;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Orange;
            this.bunifuLabel1.Location = new System.Drawing.Point(252, 3);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(187, 49);
            this.bunifuLabel1.TabIndex = 12;
            this.bunifuLabel1.Text = "ВНИМАНИЕ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.ActiveImage = null;
            this.ButtonClose.AllowAnimations = true;
            this.ButtonClose.AllowBuffering = false;
            this.ButtonClose.AllowToggling = false;
            this.ButtonClose.AllowZooming = true;
            this.ButtonClose.AllowZoomingOnFocus = false;
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ButtonClose.ErrorImage")));
            this.ButtonClose.FadeWhenInactive = false;
            this.ButtonClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ButtonClose.Image = global::VehicleServiceManagement.Properties.Resources.close;
            this.ButtonClose.ImageActive = null;
            this.ButtonClose.ImageLocation = null;
            this.ButtonClose.ImageMargin = 0;
            this.ButtonClose.ImageSize = new System.Drawing.Size(39, 39);
            this.ButtonClose.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ButtonClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("ButtonClose.InitialImage")));
            this.ButtonClose.Location = new System.Drawing.Point(633, 9);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Rotation = 0;
            this.ButtonClose.ShowActiveImage = true;
            this.ButtonClose.ShowCursorChanges = true;
            this.ButtonClose.ShowImageBorders = true;
            this.ButtonClose.ShowSizeMarkers = false;
            this.ButtonClose.Size = new System.Drawing.Size(40, 40);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.ToolTipText = "";
            this.ButtonClose.WaitOnLoad = false;
            this.ButtonClose.Zoom = 0;
            this.ButtonClose.ZoomSpeed = 10;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LabelText
            // 
            this.LabelText.AllowParentOverrides = false;
            this.LabelText.AutoEllipsis = false;
            this.LabelText.AutoSize = false;
            this.LabelText.CausesValidation = false;
            this.LabelText.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelText.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelText.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.LabelText.ForeColor = System.Drawing.Color.White;
            this.LabelText.Location = new System.Drawing.Point(6, 47);
            this.LabelText.Name = "LabelText";
            this.LabelText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelText.Size = new System.Drawing.Size(673, 127);
            this.LabelText.TabIndex = 10;
            this.LabelText.Text = "Сигурни ли сте, че искате да изтриете клиент: Иван Иванов / 0887446787";
            this.LabelText.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelText.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.LabelText.Click += new System.EventHandler(this.LabelText_Click);
            // 
            // ButtonNo
            // 
            this.ButtonNo.AllowAnimations = true;
            this.ButtonNo.AllowMouseEffects = true;
            this.ButtonNo.AllowToggling = false;
            this.ButtonNo.AnimationSpeed = 200;
            this.ButtonNo.AutoGenerateColors = false;
            this.ButtonNo.AutoRoundBorders = false;
            this.ButtonNo.AutoSizeLeftIcon = true;
            this.ButtonNo.AutoSizeRightIcon = true;
            this.ButtonNo.BackColor = System.Drawing.Color.Transparent;
            this.ButtonNo.BackColor1 = System.Drawing.Color.Gray;
            this.ButtonNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonNo.BackgroundImage")));
            this.ButtonNo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonNo.ButtonText = "НЕ";
            this.ButtonNo.ButtonTextMarginLeft = 0;
            this.ButtonNo.ColorContrastOnClick = 45;
            this.ButtonNo.ColorContrastOnHover = 45;
            this.ButtonNo.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ButtonNo.CustomizableEdges = borderEdges1;
            this.ButtonNo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonNo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonNo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonNo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ButtonNo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ButtonNo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonNo.ForeColor = System.Drawing.Color.White;
            this.ButtonNo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonNo.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNo.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ButtonNo.IconMarginLeft = 11;
            this.ButtonNo.IconPadding = 10;
            this.ButtonNo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonNo.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ButtonNo.IconSize = 25;
            this.ButtonNo.IdleBorderColor = System.Drawing.Color.Black;
            this.ButtonNo.IdleBorderRadius = 40;
            this.ButtonNo.IdleBorderThickness = 1;
            this.ButtonNo.IdleFillColor = System.Drawing.Color.Gray;
            this.ButtonNo.IdleIconLeftImage = null;
            this.ButtonNo.IdleIconRightImage = null;
            this.ButtonNo.IndicateFocus = false;
            this.ButtonNo.Location = new System.Drawing.Point(226, 180);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonNo.OnDisabledState.BorderRadius = 40;
            this.ButtonNo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonNo.OnDisabledState.BorderThickness = 1;
            this.ButtonNo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonNo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ButtonNo.OnDisabledState.IconLeftImage = null;
            this.ButtonNo.OnDisabledState.IconRightImage = null;
            this.ButtonNo.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.ButtonNo.onHoverState.BorderRadius = 40;
            this.ButtonNo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonNo.onHoverState.BorderThickness = 1;
            this.ButtonNo.onHoverState.FillColor = System.Drawing.Color.Red;
            this.ButtonNo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonNo.onHoverState.IconLeftImage = null;
            this.ButtonNo.onHoverState.IconRightImage = null;
            this.ButtonNo.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.ButtonNo.OnIdleState.BorderRadius = 40;
            this.ButtonNo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonNo.OnIdleState.BorderThickness = 1;
            this.ButtonNo.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.ButtonNo.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ButtonNo.OnIdleState.IconLeftImage = null;
            this.ButtonNo.OnIdleState.IconRightImage = null;
            this.ButtonNo.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.ButtonNo.OnPressedState.BorderRadius = 40;
            this.ButtonNo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonNo.OnPressedState.BorderThickness = 1;
            this.ButtonNo.OnPressedState.FillColor = System.Drawing.Color.Gray;
            this.ButtonNo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ButtonNo.OnPressedState.IconLeftImage = null;
            this.ButtonNo.OnPressedState.IconRightImage = null;
            this.ButtonNo.Size = new System.Drawing.Size(85, 54);
            this.ButtonNo.TabIndex = 8;
            this.ButtonNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonNo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonNo.TextMarginLeft = 0;
            this.ButtonNo.TextPadding = new System.Windows.Forms.Padding(0);
            this.ButtonNo.UseDefaultRadiusAndThickness = true;
            this.ButtonNo.Click += new System.EventHandler(this.ButtonNo_Click);
            // 
            // ButtonYes
            // 
            this.ButtonYes.AllowAnimations = true;
            this.ButtonYes.AllowMouseEffects = true;
            this.ButtonYes.AllowToggling = false;
            this.ButtonYes.AnimationSpeed = 200;
            this.ButtonYes.AutoGenerateColors = false;
            this.ButtonYes.AutoRoundBorders = false;
            this.ButtonYes.AutoSizeLeftIcon = true;
            this.ButtonYes.AutoSizeRightIcon = true;
            this.ButtonYes.BackColor = System.Drawing.Color.Transparent;
            this.ButtonYes.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.ButtonYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonYes.BackgroundImage")));
            this.ButtonYes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonYes.ButtonText = "ДА";
            this.ButtonYes.ButtonTextMarginLeft = 0;
            this.ButtonYes.ColorContrastOnClick = 45;
            this.ButtonYes.ColorContrastOnHover = 45;
            this.ButtonYes.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.ButtonYes.CustomizableEdges = borderEdges2;
            this.ButtonYes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonYes.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonYes.DisabledFillColor = System.Drawing.Color.White;
            this.ButtonYes.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.ButtonYes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.ButtonYes.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonYes.ForeColor = System.Drawing.Color.White;
            this.ButtonYes.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonYes.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonYes.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ButtonYes.IconMarginLeft = 11;
            this.ButtonYes.IconPadding = 10;
            this.ButtonYes.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonYes.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonYes.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ButtonYes.IconSize = 25;
            this.ButtonYes.IdleBorderColor = System.Drawing.Color.Black;
            this.ButtonYes.IdleBorderRadius = 40;
            this.ButtonYes.IdleBorderThickness = 1;
            this.ButtonYes.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.ButtonYes.IdleIconLeftImage = null;
            this.ButtonYes.IdleIconRightImage = null;
            this.ButtonYes.IndicateFocus = false;
            this.ButtonYes.Location = new System.Drawing.Point(402, 180);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonYes.OnDisabledState.BorderRadius = 40;
            this.ButtonYes.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonYes.OnDisabledState.BorderThickness = 1;
            this.ButtonYes.OnDisabledState.FillColor = System.Drawing.Color.White;
            this.ButtonYes.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.ButtonYes.OnDisabledState.IconLeftImage = null;
            this.ButtonYes.OnDisabledState.IconRightImage = null;
            this.ButtonYes.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.ButtonYes.onHoverState.BorderRadius = 40;
            this.ButtonYes.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonYes.onHoverState.BorderThickness = 1;
            this.ButtonYes.onHoverState.FillColor = System.Drawing.Color.LimeGreen;
            this.ButtonYes.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonYes.onHoverState.IconLeftImage = null;
            this.ButtonYes.onHoverState.IconRightImage = null;
            this.ButtonYes.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.ButtonYes.OnIdleState.BorderRadius = 40;
            this.ButtonYes.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonYes.OnIdleState.BorderThickness = 1;
            this.ButtonYes.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(216)))), ((int)(((byte)(172)))));
            this.ButtonYes.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ButtonYes.OnIdleState.IconLeftImage = null;
            this.ButtonYes.OnIdleState.IconRightImage = null;
            this.ButtonYes.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.ButtonYes.OnPressedState.BorderRadius = 40;
            this.ButtonYes.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonYes.OnPressedState.BorderThickness = 1;
            this.ButtonYes.OnPressedState.FillColor = System.Drawing.Color.Gray;
            this.ButtonYes.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ButtonYes.OnPressedState.IconLeftImage = null;
            this.ButtonYes.OnPressedState.IconRightImage = null;
            this.ButtonYes.Size = new System.Drawing.Size(85, 54);
            this.ButtonYes.TabIndex = 7;
            this.ButtonYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonYes.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonYes.TextMarginLeft = 0;
            this.ButtonYes.TextPadding = new System.Windows.Forms.Padding(0);
            this.ButtonYes.UseDefaultRadiusAndThickness = true;
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // AlertBoxEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 265);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlertBoxEditClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlertBoxEditClient";
            this.TopMost = true;
            this.bunifuPanel1.ResumeLayout(false);
            this.AlerBoxDragPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel AlerBoxDragPanel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuImageButton ButtonClose;
        private Bunifu.UI.WinForms.BunifuLabel LabelText;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ButtonNo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ButtonYes;
    }
}