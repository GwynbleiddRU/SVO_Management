namespace SVO_Management
{
    partial class BluetoothForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BluetoothForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.appName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.deviceList = new System.Windows.Forms.ListView();
            this.listViewElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.stopButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.startButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            this.SuspendLayout();
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
            this.panelHeader.Size = new System.Drawing.Size(504, 60);
            this.panelHeader.TabIndex = 2;
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(12, 12);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(128, 36);
            this.appName.TabIndex = 2;
            this.appName.Text = "Bluetooth";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Image = global::SVO_Management.Properties.Resources.iconClose;
            this.exitButton.ImageActive = null;
            this.exitButton.Location = new System.Drawing.Point(451, 12);
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
            this.minimizeButton.Location = new System.Drawing.Point(400, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(35, 35);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
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
            // deviceList
            // 
            this.deviceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deviceList.HideSelection = false;
            this.deviceList.Location = new System.Drawing.Point(34, 95);
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(337, 242);
            this.deviceList.TabIndex = 3;
            this.deviceList.UseCompatibleStateImageBehavior = false;
            this.deviceList.View = System.Windows.Forms.View.List;
            // 
            // listViewElipse
            // 
            this.listViewElipse.ElipseRadius = 5;
            this.listViewElipse.TargetControl = this.deviceList;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Transparent;
            this.stopButton.color = System.Drawing.Color.Transparent;
            this.stopButton.colorActive = System.Drawing.Color.Transparent;
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Image = global::SVO_Management.Properties.Resources.bluetoothOffIcon;
            this.stopButton.ImagePosition = 12;
            this.stopButton.ImageZoom = 50;
            this.stopButton.LabelPosition = 24;
            this.stopButton.LabelText = "Stop";
            this.stopButton.Location = new System.Drawing.Point(396, 237);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(88, 85);
            this.stopButton.TabIndex = 5;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.color = System.Drawing.Color.Transparent;
            this.startButton.colorActive = System.Drawing.Color.Transparent;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Image = global::SVO_Management.Properties.Resources.bluetoothOnIcon;
            this.startButton.ImagePosition = 12;
            this.startButton.ImageZoom = 50;
            this.startButton.LabelPosition = 24;
            this.startButton.LabelText = "Search";
            this.startButton.Location = new System.Drawing.Point(396, 95);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(88, 85);
            this.startButton.TabIndex = 4;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
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
            this.bunifuThinButton21.ButtonText = "Connect";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 7;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(34, 361);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(337, 55);
            this.bunifuThinButton21.TabIndex = 15;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BluetoothForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(504, 450);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.deviceList);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BluetoothForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BluetoothForm";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuCustomLabel appName;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.Framework.UI.BunifuTileButton stopButton;
        private Bunifu.Framework.UI.BunifuTileButton startButton;
        private System.Windows.Forms.ListView deviceList;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuElipse listViewElipse;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}