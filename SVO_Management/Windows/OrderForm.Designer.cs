namespace SVO_Management
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.commentTextBox = new System.Windows.Forms.RichTextBox();
            this.TextBoxElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.appName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.menuSettingsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.logInButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // commentTextBox
            // 
            this.commentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentTextBox.BulletIndent = 3;
            this.commentTextBox.Location = new System.Drawing.Point(37, 271);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(517, 237);
            this.commentTextBox.TabIndex = 0;
            this.commentTextBox.Text = "";
            // 
            // TextBoxElipse
            // 
            this.TextBoxElipse.ElipseRadius = 7;
            this.TextBoxElipse.TargetControl = this.commentTextBox;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.panelHeader.Controls.Add(this.appName);
            this.panelHeader.Controls.Add(this.exitButton);
            this.panelHeader.Controls.Add(this.minimizeButton);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(591, 60);
            this.panelHeader.TabIndex = 2;
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(12, 12);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(136, 36);
            this.appName.TabIndex = 2;
            this.appName.Text = "New order";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Image = global::SVO_Management.Properties.Resources.iconClose;
            this.exitButton.ImageActive = null;
            this.exitButton.Location = new System.Drawing.Point(537, 12);
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
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.Location = new System.Drawing.Point(486, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(35, 35);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(32, 133);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(96, 28);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Personnel";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(202, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(352, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(202, 178);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(352, 28);
            this.comboBox2.TabIndex = 6;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 178);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(96, 28);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Case type";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(32, 88);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(91, 28);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Case title";
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.bunifuCustomTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCustomTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(203, 89);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(327, 26);
            this.bunifuCustomTextbox1.TabIndex = 8;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(32, 228);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(155, 28);
            this.bunifuCustomLabel4.TabIndex = 9;
            this.bunifuCustomLabel4.Text = "Case description";
            // 
            // menuSettingsButton
            // 
            this.menuSettingsButton.Activecolor = System.Drawing.Color.Transparent;
            this.menuSettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.menuSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuSettingsButton.BorderRadius = 0;
            this.menuSettingsButton.ButtonText = "Location";
            this.menuSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuSettingsButton.DisabledColor = System.Drawing.Color.Gray;
            this.menuSettingsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.menuSettingsButton.Iconimage = global::SVO_Management.Properties.Resources.iconMap;
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
            this.menuSettingsButton.Location = new System.Drawing.Point(37, 531);
            this.menuSettingsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuSettingsButton.Name = "menuSettingsButton";
            this.menuSettingsButton.Normalcolor = System.Drawing.Color.Transparent;
            this.menuSettingsButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.menuSettingsButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.menuSettingsButton.selected = false;
            this.menuSettingsButton.Size = new System.Drawing.Size(163, 41);
            this.menuSettingsButton.TabIndex = 11;
            this.menuSettingsButton.Text = "Location";
            this.menuSettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuSettingsButton.Textcolor = System.Drawing.Color.White;
            this.menuSettingsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(218, 536);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(217, 28);
            this.bunifuCustomLabel5.TabIndex = 12;
            this.bunifuCustomLabel5.Text = "58.019777° 56.344984°";
            // 
            // logInButton
            // 
            this.logInButton.ActiveBorderThickness = 1;
            this.logInButton.ActiveCornerRadius = 20;
            this.logInButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.logInButton.ActiveForecolor = System.Drawing.Color.White;
            this.logInButton.ActiveLineColor = System.Drawing.Color.White;
            this.logInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.logInButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logInButton.BackgroundImage")));
            this.logInButton.ButtonText = "Send order";
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.ForeColor = System.Drawing.Color.White;
            this.logInButton.IdleBorderThickness = 1;
            this.logInButton.IdleCornerRadius = 7;
            this.logInButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.logInButton.IdleForecolor = System.Drawing.Color.White;
            this.logInButton.IdleLineColor = System.Drawing.Color.White;
            this.logInButton.Location = new System.Drawing.Point(37, 597);
            this.logInButton.Margin = new System.Windows.Forms.Padding(5);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(240, 55);
            this.logInButton.TabIndex = 13;
            this.logInButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Queue order";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 7;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(314, 597);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(240, 55);
            this.bunifuThinButton21.TabIndex = 14;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.ForeColor = System.Drawing.Color.White;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(202, 88);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(329, 28);
            this.comboBox3.TabIndex = 15;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(591, 682);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.menuSettingsButton);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.bunifuCustomTextbox1);
            this.Controls.Add(this.comboBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox commentTextBox;
        private Bunifu.Framework.UI.BunifuElipse TextBoxElipse;
        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuCustomLabel appName;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton menuSettingsButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 logInButton;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}