namespace SVO_Management
{
    partial class PanelPersonnel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPersonnel));
            this.personnelList = new System.Windows.Forms.ListView();
            this.PersonnelColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personnelIcons = new System.Windows.Forms.ImageList(this.components);
            this.mapControl1 = new SVO_Management.MapControl();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.personnelYCordLabel = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.personnelXCordLabel = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.requestButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.personnelTypeLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.personnelNameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // personnelList
            // 
            this.personnelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.personnelList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personnelList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PersonnelColumn});
            this.personnelList.Dock = System.Windows.Forms.DockStyle.Right;
            this.personnelList.ForeColor = System.Drawing.Color.White;
            this.personnelList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.personnelList.HideSelection = false;
            this.personnelList.Location = new System.Drawing.Point(786, 0);
            this.personnelList.Name = "personnelList";
            this.personnelList.Size = new System.Drawing.Size(284, 636);
            this.personnelList.SmallImageList = this.personnelIcons;
            this.personnelList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.personnelList.TabIndex = 1;
            this.personnelList.UseCompatibleStateImageBehavior = false;
            this.personnelList.View = System.Windows.Forms.View.Details;
            this.personnelList.SelectedIndexChanged += new System.EventHandler(this.personnelList_SelectedIndexChanged);
            // 
            // PersonnelColumn
            // 
            this.PersonnelColumn.Text = "Personnel online";
            this.PersonnelColumn.Width = 260;
            // 
            // personnelIcons
            // 
            this.personnelIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("personnelIcons.ImageStream")));
            this.personnelIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.personnelIcons.Images.SetKeyName(0, "personnelAssistantIcon.png");
            this.personnelIcons.Images.SetKeyName(1, "personnelCarrierIcon.png");
            this.personnelIcons.Images.SetKeyName(2, "personnelEngineerIcon.png");
            this.personnelIcons.Images.SetKeyName(3, "personnelPoliceIcon.png");
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(786, 536);
            this.mapControl1.TabIndex = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.panelInfo.Controls.Add(this.personnelYCordLabel);
            this.panelInfo.Controls.Add(this.personnelXCordLabel);
            this.panelInfo.Controls.Add(this.requestButton);
            this.panelInfo.Controls.Add(this.personnelTypeLabel);
            this.panelInfo.Controls.Add(this.personnelNameLabel);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 536);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(786, 100);
            this.panelInfo.TabIndex = 2;
            // 
            // personnelYCordLabel
            // 
            this.personnelYCordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.personnelYCordLabel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.personnelYCordLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personnelYCordLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.personnelYCordLabel.ForeColor = System.Drawing.Color.White;
            this.personnelYCordLabel.Location = new System.Drawing.Point(38, 61);
            this.personnelYCordLabel.Name = "personnelYCordLabel";
            this.personnelYCordLabel.ReadOnly = true;
            this.personnelYCordLabel.Size = new System.Drawing.Size(270, 24);
            this.personnelYCordLabel.TabIndex = 16;
            // 
            // personnelXCordLabel
            // 
            this.personnelXCordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.personnelXCordLabel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.personnelXCordLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personnelXCordLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.personnelXCordLabel.ForeColor = System.Drawing.Color.White;
            this.personnelXCordLabel.Location = new System.Drawing.Point(38, 22);
            this.personnelXCordLabel.Name = "personnelXCordLabel";
            this.personnelXCordLabel.ReadOnly = true;
            this.personnelXCordLabel.Size = new System.Drawing.Size(270, 24);
            this.personnelXCordLabel.TabIndex = 15;
            // 
            // requestButton
            // 
            this.requestButton.ActiveBorderThickness = 1;
            this.requestButton.ActiveCornerRadius = 20;
            this.requestButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.requestButton.ActiveForecolor = System.Drawing.Color.White;
            this.requestButton.ActiveLineColor = System.Drawing.Color.White;
            this.requestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.requestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.requestButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("requestButton.BackgroundImage")));
            this.requestButton.ButtonText = "Ask to move";
            this.requestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.requestButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestButton.ForeColor = System.Drawing.Color.White;
            this.requestButton.IdleBorderThickness = 1;
            this.requestButton.IdleCornerRadius = 7;
            this.requestButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.requestButton.IdleForecolor = System.Drawing.Color.White;
            this.requestButton.IdleLineColor = System.Drawing.Color.White;
            this.requestButton.Location = new System.Drawing.Point(591, 15);
            this.requestButton.Margin = new System.Windows.Forms.Padding(5);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(174, 67);
            this.requestButton.TabIndex = 14;
            this.requestButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // personnelTypeLabel
            // 
            this.personnelTypeLabel.AutoSize = true;
            this.personnelTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.personnelTypeLabel.ForeColor = System.Drawing.Color.White;
            this.personnelTypeLabel.Location = new System.Drawing.Point(337, 61);
            this.personnelTypeLabel.Name = "personnelTypeLabel";
            this.personnelTypeLabel.Size = new System.Drawing.Size(0, 25);
            this.personnelTypeLabel.TabIndex = 7;
            // 
            // personnelNameLabel
            // 
            this.personnelNameLabel.AutoSize = true;
            this.personnelNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.personnelNameLabel.ForeColor = System.Drawing.Color.White;
            this.personnelNameLabel.Location = new System.Drawing.Point(337, 22);
            this.personnelNameLabel.Name = "personnelNameLabel";
            this.personnelNameLabel.Size = new System.Drawing.Size(0, 25);
            this.personnelNameLabel.TabIndex = 6;
            // 
            // PanelPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mapControl1);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.personnelList);
            this.Name = "PanelPersonnel";
            this.Size = new System.Drawing.Size(1070, 636);
            this.Load += new System.EventHandler(this.PanelPersonnel_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MapControl mapControl1;
        private System.Windows.Forms.ListView personnelList;
        private System.Windows.Forms.ImageList personnelIcons;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.ColumnHeader PersonnelColumn;
        private Bunifu.Framework.UI.BunifuThinButton2 requestButton;
        public Bunifu.Framework.UI.BunifuCustomLabel personnelTypeLabel;
        public Bunifu.Framework.UI.BunifuCustomLabel personnelNameLabel;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox personnelXCordLabel;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox personnelYCordLabel;
    }
}
