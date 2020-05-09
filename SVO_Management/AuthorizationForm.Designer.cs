namespace SVO_Management
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.appName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.loginTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passwordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.logInButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.panelHeader;
            this.DragControl.Vertical = true;
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
            this.panelHeader.Size = new System.Drawing.Size(498, 60);
            this.panelHeader.TabIndex = 1;
            // 
            // appName
            // 
            this.appName.AutoSize = true;
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
            // loginTextBox
            // 
            this.loginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.loginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginTextBox.HintForeColor = System.Drawing.Color.White;
            this.loginTextBox.HintText = "Login";
            this.loginTextBox.isPassword = false;
            this.loginTextBox.LineFocusedColor = System.Drawing.Color.White;
            this.loginTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.loginTextBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.loginTextBox.LineThickness = 3;
            this.loginTextBox.Location = new System.Drawing.Point(58, 100);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(370, 44);
            this.loginTextBox.TabIndex = 2;
            this.loginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTextBox.HintForeColor = System.Drawing.Color.White;
            this.passwordTextBox.HintText = "Password";
            this.passwordTextBox.isPassword = false;
            this.passwordTextBox.LineFocusedColor = System.Drawing.Color.White;
            this.passwordTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.passwordTextBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.passwordTextBox.LineThickness = 3;
            this.passwordTextBox.Location = new System.Drawing.Point(58, 186);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(370, 44);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.logInButton.ButtonText = "Authorize";
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.ForeColor = System.Drawing.Color.White;
            this.logInButton.IdleBorderThickness = 1;
            this.logInButton.IdleCornerRadius = 7;
            this.logInButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.logInButton.IdleForecolor = System.Drawing.Color.White;
            this.logInButton.IdleLineColor = System.Drawing.Color.White;
            this.logInButton.Location = new System.Drawing.Point(58, 297);
            this.logInButton.Margin = new System.Windows.Forms.Padding(5);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(370, 59);
            this.logInButton.TabIndex = 4;
            this.logInButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(498, 403);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuCustomLabel appName;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox loginTextBox;
        private Bunifu.Framework.UI.BunifuThinButton2 logInButton;
    }
}