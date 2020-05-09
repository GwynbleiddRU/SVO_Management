namespace SVO_Management
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.maximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.appName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuLogOutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuSchemeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuPersonnelButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuSettingsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.menuAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.testButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.orderButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.panelHeader.Controls.Add(this.maximizeButton);
            this.panelHeader.Controls.Add(this.appName);
            this.panelHeader.Controls.Add(this.exitButton);
            this.panelHeader.Controls.Add(this.minimizeButton);
            this.menuAnimator.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1140, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.menuAnimator.SetDecoration(this.maximizeButton, BunifuAnimatorNS.DecorationType.None);
            this.maximizeButton.Image = global::SVO_Management.Properties.Resources.iconMaximize;
            this.maximizeButton.ImageActive = null;
            this.maximizeButton.Location = new System.Drawing.Point(1051, 12);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(35, 35);
            this.maximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizeButton.TabIndex = 3;
            this.maximizeButton.TabStop = false;
            this.maximizeButton.Zoom = 10;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.menuAnimator.SetDecoration(this.appName, BunifuAnimatorNS.DecorationType.None);
            this.appName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(12, 12);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(224, 36);
            this.appName.TabIndex = 2;
            this.appName.Text = "SVO Management";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.menuAnimator.SetDecoration(this.exitButton, BunifuAnimatorNS.DecorationType.None);
            this.exitButton.Image = global::SVO_Management.Properties.Resources.iconClose;
            this.exitButton.ImageActive = null;
            this.exitButton.Location = new System.Drawing.Point(1093, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(35, 35);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 1;
            this.exitButton.TabStop = false;
            this.exitButton.Zoom = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.menuAnimator.SetDecoration(this.minimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.Location = new System.Drawing.Point(1010, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(35, 35);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelMenu.Controls.Add(this.menuLogOutButton);
            this.panelMenu.Controls.Add(this.menuSchemeButton);
            this.panelMenu.Controls.Add(this.menuPersonnelButton);
            this.panelMenu.Controls.Add(this.menuSettingsButton);
            this.panelMenu.Controls.Add(this.menuButton);
            this.menuAnimator.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 60);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(350, 636);
            this.panelMenu.TabIndex = 1;
            // 
            // menuLogOutButton
            // 
            this.menuLogOutButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.menuLogOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menuLogOutButton.BackColor = System.Drawing.Color.Transparent;
            this.menuLogOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuLogOutButton.BorderRadius = 0;
            this.menuLogOutButton.ButtonText = "Log Out";
            this.menuLogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAnimator.SetDecoration(this.menuLogOutButton, BunifuAnimatorNS.DecorationType.None);
            this.menuLogOutButton.DisabledColor = System.Drawing.Color.Gray;
            this.menuLogOutButton.Iconcolor = System.Drawing.Color.Transparent;
            this.menuLogOutButton.Iconimage = global::SVO_Management.Properties.Resources.iconLogOut;
            this.menuLogOutButton.Iconimage_right = null;
            this.menuLogOutButton.Iconimage_right_Selected = null;
            this.menuLogOutButton.Iconimage_Selected = null;
            this.menuLogOutButton.IconMarginLeft = 0;
            this.menuLogOutButton.IconMarginRight = 0;
            this.menuLogOutButton.IconRightVisible = true;
            this.menuLogOutButton.IconRightZoom = 0D;
            this.menuLogOutButton.IconVisible = true;
            this.menuLogOutButton.IconZoom = 90D;
            this.menuLogOutButton.IsTab = false;
            this.menuLogOutButton.Location = new System.Drawing.Point(0, 548);
            this.menuLogOutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuLogOutButton.Name = "menuLogOutButton";
            this.menuLogOutButton.Normalcolor = System.Drawing.Color.Transparent;
            this.menuLogOutButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.menuLogOutButton.OnHoverTextColor = System.Drawing.Color.White;
            this.menuLogOutButton.selected = false;
            this.menuLogOutButton.Size = new System.Drawing.Size(350, 74);
            this.menuLogOutButton.TabIndex = 5;
            this.menuLogOutButton.Text = "Log Out";
            this.menuLogOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuLogOutButton.Textcolor = System.Drawing.Color.White;
            this.menuLogOutButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // menuSchemeButton
            // 
            this.menuSchemeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.menuSchemeButton.BackColor = System.Drawing.Color.Transparent;
            this.menuSchemeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuSchemeButton.BorderRadius = 0;
            this.menuSchemeButton.ButtonText = "Scheme";
            this.menuSchemeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAnimator.SetDecoration(this.menuSchemeButton, BunifuAnimatorNS.DecorationType.None);
            this.menuSchemeButton.DisabledColor = System.Drawing.Color.Gray;
            this.menuSchemeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.menuSchemeButton.Iconimage = global::SVO_Management.Properties.Resources.iconMap;
            this.menuSchemeButton.Iconimage_right = null;
            this.menuSchemeButton.Iconimage_right_Selected = null;
            this.menuSchemeButton.Iconimage_Selected = null;
            this.menuSchemeButton.IconMarginLeft = 0;
            this.menuSchemeButton.IconMarginRight = 0;
            this.menuSchemeButton.IconRightVisible = true;
            this.menuSchemeButton.IconRightZoom = 0D;
            this.menuSchemeButton.IconVisible = true;
            this.menuSchemeButton.IconZoom = 90D;
            this.menuSchemeButton.IsTab = false;
            this.menuSchemeButton.Location = new System.Drawing.Point(-4, 136);
            this.menuSchemeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuSchemeButton.Name = "menuSchemeButton";
            this.menuSchemeButton.Normalcolor = System.Drawing.Color.Transparent;
            this.menuSchemeButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.menuSchemeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.menuSchemeButton.selected = false;
            this.menuSchemeButton.Size = new System.Drawing.Size(350, 74);
            this.menuSchemeButton.TabIndex = 4;
            this.menuSchemeButton.Text = "Scheme";
            this.menuSchemeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuSchemeButton.Textcolor = System.Drawing.Color.White;
            this.menuSchemeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // menuPersonnelButton
            // 
            this.menuPersonnelButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.menuPersonnelButton.BackColor = System.Drawing.Color.Transparent;
            this.menuPersonnelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuPersonnelButton.BorderRadius = 0;
            this.menuPersonnelButton.ButtonText = "Personnel";
            this.menuPersonnelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAnimator.SetDecoration(this.menuPersonnelButton, BunifuAnimatorNS.DecorationType.None);
            this.menuPersonnelButton.DisabledColor = System.Drawing.Color.Gray;
            this.menuPersonnelButton.Iconcolor = System.Drawing.Color.Transparent;
            this.menuPersonnelButton.Iconimage = global::SVO_Management.Properties.Resources.iconPersonnel;
            this.menuPersonnelButton.Iconimage_right = null;
            this.menuPersonnelButton.Iconimage_right_Selected = null;
            this.menuPersonnelButton.Iconimage_Selected = null;
            this.menuPersonnelButton.IconMarginLeft = 0;
            this.menuPersonnelButton.IconMarginRight = 0;
            this.menuPersonnelButton.IconRightVisible = true;
            this.menuPersonnelButton.IconRightZoom = 0D;
            this.menuPersonnelButton.IconVisible = true;
            this.menuPersonnelButton.IconZoom = 90D;
            this.menuPersonnelButton.IsTab = false;
            this.menuPersonnelButton.Location = new System.Drawing.Point(0, 220);
            this.menuPersonnelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuPersonnelButton.Name = "menuPersonnelButton";
            this.menuPersonnelButton.Normalcolor = System.Drawing.Color.Transparent;
            this.menuPersonnelButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.menuPersonnelButton.OnHoverTextColor = System.Drawing.Color.White;
            this.menuPersonnelButton.selected = false;
            this.menuPersonnelButton.Size = new System.Drawing.Size(350, 74);
            this.menuPersonnelButton.TabIndex = 3;
            this.menuPersonnelButton.Text = "Personnel";
            this.menuPersonnelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuPersonnelButton.Textcolor = System.Drawing.Color.White;
            this.menuPersonnelButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // menuSettingsButton
            // 
            this.menuSettingsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.menuSettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.menuSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuSettingsButton.BorderRadius = 0;
            this.menuSettingsButton.ButtonText = "Settings";
            this.menuSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAnimator.SetDecoration(this.menuSettingsButton, BunifuAnimatorNS.DecorationType.None);
            this.menuSettingsButton.DisabledColor = System.Drawing.Color.Gray;
            this.menuSettingsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.menuSettingsButton.Iconimage = global::SVO_Management.Properties.Resources.iconSettings;
            this.menuSettingsButton.Iconimage_right = null;
            this.menuSettingsButton.Iconimage_right_Selected = null;
            this.menuSettingsButton.Iconimage_Selected = null;
            this.menuSettingsButton.IconMarginLeft = 0;
            this.menuSettingsButton.IconMarginRight = 0;
            this.menuSettingsButton.IconRightVisible = true;
            this.menuSettingsButton.IconRightZoom = 0D;
            this.menuSettingsButton.IconVisible = true;
            this.menuSettingsButton.IconZoom = 90D;
            this.menuSettingsButton.IsTab = false;
            this.menuSettingsButton.Location = new System.Drawing.Point(0, 304);
            this.menuSettingsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuSettingsButton.Name = "menuSettingsButton";
            this.menuSettingsButton.Normalcolor = System.Drawing.Color.Transparent;
            this.menuSettingsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.menuSettingsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.menuSettingsButton.selected = false;
            this.menuSettingsButton.Size = new System.Drawing.Size(350, 74);
            this.menuSettingsButton.TabIndex = 2;
            this.menuSettingsButton.Text = "Settings";
            this.menuSettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuSettingsButton.Textcolor = System.Drawing.Color.White;
            this.menuSettingsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // menuButton
            // 
            this.menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuAnimator.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.menuButton.Image = global::SVO_Management.Properties.Resources.iconMenu;
            this.menuButton.ImageActive = null;
            this.menuButton.Location = new System.Drawing.Point(298, 17);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(35, 35);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 1;
            this.menuButton.TabStop = false;
            this.menuButton.Zoom = 10;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.panelHeader;
            this.DragControl.Vertical = true;
            // 
            // menuAnimator
            // 
            this.menuAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.menuAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.menuAnimator.DefaultAnimation = animation1;
            // 
            // testButton
            // 
            this.testButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testButton.BackColor = System.Drawing.Color.Transparent;
            this.menuAnimator.SetDecoration(this.testButton, BunifuAnimatorNS.DecorationType.None);
            this.testButton.Image = ((System.Drawing.Image)(resources.GetObject("testButton.Image")));
            this.testButton.ImageActive = null;
            this.testButton.Location = new System.Drawing.Point(600, 304);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(84, 81);
            this.testButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.testButton.TabIndex = 6;
            this.testButton.TabStop = false;
            this.testButton.Zoom = 10;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderButton.BackColor = System.Drawing.Color.Transparent;
            this.menuAnimator.SetDecoration(this.orderButton, BunifuAnimatorNS.DecorationType.None);
            this.orderButton.Image = ((System.Drawing.Image)(resources.GetObject("orderButton.Image")));
            this.orderButton.ImageActive = null;
            this.orderButton.Location = new System.Drawing.Point(749, 304);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(84, 81);
            this.orderButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.orderButton.TabIndex = 7;
            this.orderButton.TabStop = false;
            this.orderButton.Zoom = 10;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1140, 696);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.menuAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuImageButton menuButton;
        private Bunifu.Framework.UI.BunifuCustomLabel appName;
        private BunifuAnimatorNS.BunifuTransition menuAnimator;
        private Bunifu.Framework.UI.BunifuFlatButton menuSettingsButton;
        private Bunifu.Framework.UI.BunifuFlatButton menuLogOutButton;
        private Bunifu.Framework.UI.BunifuFlatButton menuSchemeButton;
        private Bunifu.Framework.UI.BunifuFlatButton menuPersonnelButton;
        private Bunifu.Framework.UI.BunifuImageButton maximizeButton;
        private Bunifu.Framework.UI.BunifuImageButton testButton;
        private Bunifu.Framework.UI.BunifuImageButton orderButton;
    }
}

