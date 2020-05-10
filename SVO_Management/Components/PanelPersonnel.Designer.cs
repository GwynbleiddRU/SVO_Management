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
            this.panelInfo = new System.Windows.Forms.Panel();
            this.personnelYCordLabel = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.personnelXCordLabel = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.personnelTypeLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.personnelNameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.personnelAreaLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.mapControl1 = new SVO_Management.MapControl();
            this.locationTitleLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
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
            this.personnelList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.personnelList_MouseClick);
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
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.panelInfo.Controls.Add(this.locationTitleLabel);
            this.panelInfo.Controls.Add(this.personnelAreaLabel);
            this.panelInfo.Controls.Add(this.bunifuImageButton1);
            this.panelInfo.Controls.Add(this.personnelYCordLabel);
            this.panelInfo.Controls.Add(this.personnelXCordLabel);
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
            this.personnelYCordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.personnelXCordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            // personnelTypeLabel
            // 
            this.personnelTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.personnelNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.personnelNameLabel.AutoSize = true;
            this.personnelNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.personnelNameLabel.ForeColor = System.Drawing.Color.White;
            this.personnelNameLabel.Location = new System.Drawing.Point(337, 22);
            this.personnelNameLabel.Name = "personnelNameLabel";
            this.personnelNameLabel.Size = new System.Drawing.Size(0, 25);
            this.personnelNameLabel.TabIndex = 6;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(696, 14);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 17;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // personnelAreaLabel
            // 
            this.personnelAreaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.personnelAreaLabel.AutoSize = true;
            this.personnelAreaLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.personnelAreaLabel.ForeColor = System.Drawing.Color.White;
            this.personnelAreaLabel.Location = new System.Drawing.Point(680, 61);
            this.personnelAreaLabel.Name = "personnelAreaLabel";
            this.personnelAreaLabel.Size = new System.Drawing.Size(0, 25);
            this.personnelAreaLabel.TabIndex = 18;
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(786, 536);
            this.mapControl1.TabIndex = 0;
            // 
            // locationTitleLabel
            // 
            this.locationTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.locationTitleLabel.AutoSize = true;
            this.locationTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.locationTitleLabel.ForeColor = System.Drawing.Color.White;
            this.locationTitleLabel.Location = new System.Drawing.Point(680, 22);
            this.locationTitleLabel.Name = "locationTitleLabel";
            this.locationTitleLabel.Size = new System.Drawing.Size(0, 25);
            this.locationTitleLabel.TabIndex = 19;
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
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MapControl mapControl1;
        public System.Windows.Forms.ListView personnelList;
        private System.Windows.Forms.ImageList personnelIcons;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.ColumnHeader PersonnelColumn;
        public Bunifu.Framework.UI.BunifuCustomLabel personnelTypeLabel;
        public Bunifu.Framework.UI.BunifuCustomLabel personnelNameLabel;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox personnelXCordLabel;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox personnelYCordLabel;
        public Bunifu.Framework.UI.BunifuCustomLabel personnelAreaLabel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public Bunifu.Framework.UI.BunifuCustomLabel locationTitleLabel;
    }
}
