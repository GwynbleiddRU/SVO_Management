﻿namespace SVO_Management
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
            this.personnelIcons = new System.Windows.Forms.ImageList(this.components);
            this.mapControl1 = new SVO_Management.MapControl();
            this.SuspendLayout();
            // 
            // personnelList
            // 
            this.personnelList.HideSelection = false;
            this.personnelList.Location = new System.Drawing.Point(480, 35);
            this.personnelList.Name = "personnelList";
            this.personnelList.Size = new System.Drawing.Size(274, 562);
            this.personnelList.SmallImageList = this.personnelIcons;
            this.personnelList.TabIndex = 1;
            this.personnelList.UseCompatibleStateImageBehavior = false;
            this.personnelList.View = System.Windows.Forms.View.List;
            // 
            // personnelIcons
            // 
            this.personnelIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("personnelIcons.ImageStream")));
            this.personnelIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.personnelIcons.Images.SetKeyName(0, "staffEngineerIcon.png");
            this.personnelIcons.Images.SetKeyName(1, "staffLuggageIcon.png");
            // 
            // mapControl1
            // 
            this.mapControl1.Location = new System.Drawing.Point(33, 35);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(441, 562);
            this.mapControl1.TabIndex = 0;
            // 
            // PanelPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.personnelList);
            this.Controls.Add(this.mapControl1);
            this.Name = "PanelPersonnel";
            this.Size = new System.Drawing.Size(1070, 636);
            this.Load += new System.EventHandler(this.PanelPersonnel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MapControl mapControl1;
        private System.Windows.Forms.ListView personnelList;
        private System.Windows.Forms.ImageList personnelIcons;
    }
}