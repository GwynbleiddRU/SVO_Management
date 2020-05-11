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
            this.personeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.caseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.orderTitleTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.setLocationButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.coordsLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.orderSendButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.orderQueueButton = new Bunifu.Framework.UI.BunifuThinButton2();
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
            // personeTypeComboBox
            // 
            this.personeTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.personeTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personeTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.personeTypeComboBox.FormattingEnabled = true;
            this.personeTypeComboBox.Items.AddRange(new object[] {
            "Assistant",
            "Carrier",
            "Engineer",
            "Police"});
            this.personeTypeComboBox.Location = new System.Drawing.Point(202, 133);
            this.personeTypeComboBox.Name = "personeTypeComboBox";
            this.personeTypeComboBox.Size = new System.Drawing.Size(352, 28);
            this.personeTypeComboBox.TabIndex = 4;
            // 
            // caseTypeComboBox
            // 
            this.caseTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.caseTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caseTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.caseTypeComboBox.FormattingEnabled = true;
            this.caseTypeComboBox.Items.AddRange(new object[] {
            "Assistant",
            "Carrier",
            "Engineer",
            "Police"});
            this.caseTypeComboBox.Location = new System.Drawing.Point(202, 178);
            this.caseTypeComboBox.Name = "caseTypeComboBox";
            this.caseTypeComboBox.Size = new System.Drawing.Size(352, 28);
            this.caseTypeComboBox.TabIndex = 6;
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
            // orderTitleTextBox
            // 
            this.orderTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.orderTitleTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.orderTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderTitleTextBox.ForeColor = System.Drawing.Color.White;
            this.orderTitleTextBox.Location = new System.Drawing.Point(203, 89);
            this.orderTitleTextBox.Name = "orderTitleTextBox";
            this.orderTitleTextBox.Size = new System.Drawing.Size(327, 26);
            this.orderTitleTextBox.TabIndex = 8;
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
            // setLocationButton
            // 
            this.setLocationButton.Activecolor = System.Drawing.Color.Transparent;
            this.setLocationButton.BackColor = System.Drawing.Color.Transparent;
            this.setLocationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setLocationButton.BorderRadius = 0;
            this.setLocationButton.ButtonText = "Location";
            this.setLocationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setLocationButton.DisabledColor = System.Drawing.Color.Gray;
            this.setLocationButton.Iconcolor = System.Drawing.Color.Transparent;
            this.setLocationButton.Iconimage = global::SVO_Management.Properties.Resources.iconMap;
            this.setLocationButton.Iconimage_right = null;
            this.setLocationButton.Iconimage_right_Selected = null;
            this.setLocationButton.Iconimage_Selected = null;
            this.setLocationButton.IconMarginLeft = 0;
            this.setLocationButton.IconMarginRight = 0;
            this.setLocationButton.IconRightVisible = true;
            this.setLocationButton.IconRightZoom = 0D;
            this.setLocationButton.IconVisible = true;
            this.setLocationButton.IconZoom = 90D;
            this.setLocationButton.IsTab = false;
            this.setLocationButton.Location = new System.Drawing.Point(37, 531);
            this.setLocationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setLocationButton.Name = "setLocationButton";
            this.setLocationButton.Normalcolor = System.Drawing.Color.Transparent;
            this.setLocationButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.setLocationButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.setLocationButton.selected = false;
            this.setLocationButton.Size = new System.Drawing.Size(163, 41);
            this.setLocationButton.TabIndex = 11;
            this.setLocationButton.Text = "Location";
            this.setLocationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setLocationButton.Textcolor = System.Drawing.Color.White;
            this.setLocationButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // coordsLabel
            // 
            this.coordsLabel.AutoSize = true;
            this.coordsLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.coordsLabel.ForeColor = System.Drawing.Color.White;
            this.coordsLabel.Location = new System.Drawing.Point(218, 536);
            this.coordsLabel.Name = "coordsLabel";
            this.coordsLabel.Size = new System.Drawing.Size(217, 28);
            this.coordsLabel.TabIndex = 12;
            this.coordsLabel.Text = "58.019777° 56.344984°";
            // 
            // orderSendButton
            // 
            this.orderSendButton.ActiveBorderThickness = 1;
            this.orderSendButton.ActiveCornerRadius = 20;
            this.orderSendButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.orderSendButton.ActiveForecolor = System.Drawing.Color.White;
            this.orderSendButton.ActiveLineColor = System.Drawing.Color.White;
            this.orderSendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.orderSendButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("orderSendButton.BackgroundImage")));
            this.orderSendButton.ButtonText = "Send order";
            this.orderSendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderSendButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSendButton.ForeColor = System.Drawing.Color.White;
            this.orderSendButton.IdleBorderThickness = 1;
            this.orderSendButton.IdleCornerRadius = 7;
            this.orderSendButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.orderSendButton.IdleForecolor = System.Drawing.Color.White;
            this.orderSendButton.IdleLineColor = System.Drawing.Color.White;
            this.orderSendButton.Location = new System.Drawing.Point(37, 597);
            this.orderSendButton.Margin = new System.Windows.Forms.Padding(5);
            this.orderSendButton.Name = "orderSendButton";
            this.orderSendButton.Size = new System.Drawing.Size(240, 55);
            this.orderSendButton.TabIndex = 13;
            this.orderSendButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.orderSendButton.Click += new System.EventHandler(this.orderSendButton_Click);
            // 
            // orderQueueButton
            // 
            this.orderQueueButton.ActiveBorderThickness = 1;
            this.orderQueueButton.ActiveCornerRadius = 20;
            this.orderQueueButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.orderQueueButton.ActiveForecolor = System.Drawing.Color.White;
            this.orderQueueButton.ActiveLineColor = System.Drawing.Color.White;
            this.orderQueueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.orderQueueButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("orderQueueButton.BackgroundImage")));
            this.orderQueueButton.ButtonText = "Queue order";
            this.orderQueueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderQueueButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderQueueButton.ForeColor = System.Drawing.Color.White;
            this.orderQueueButton.IdleBorderThickness = 1;
            this.orderQueueButton.IdleCornerRadius = 7;
            this.orderQueueButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.orderQueueButton.IdleForecolor = System.Drawing.Color.White;
            this.orderQueueButton.IdleLineColor = System.Drawing.Color.White;
            this.orderQueueButton.Location = new System.Drawing.Point(314, 597);
            this.orderQueueButton.Margin = new System.Windows.Forms.Padding(5);
            this.orderQueueButton.Name = "orderQueueButton";
            this.orderQueueButton.Size = new System.Drawing.Size(240, 55);
            this.orderQueueButton.TabIndex = 14;
            this.orderQueueButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Controls.Add(this.orderQueueButton);
            this.Controls.Add(this.orderSendButton);
            this.Controls.Add(this.coordsLabel);
            this.Controls.Add(this.setLocationButton);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.caseTypeComboBox);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.personeTypeComboBox);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.orderTitleTextBox);
            this.Controls.Add(this.comboBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox commentTextBox;
        private Bunifu.Framework.UI.BunifuElipse TextBoxElipse;
        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuCustomLabel appName;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public System.Windows.Forms.ComboBox personeTypeComboBox;
        public System.Windows.Forms.ComboBox caseTypeComboBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox orderTitleTextBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton setLocationButton;
        private Bunifu.Framework.UI.BunifuCustomLabel coordsLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 orderSendButton;
        private Bunifu.Framework.UI.BunifuThinButton2 orderQueueButton;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}