namespace SVO_Management.Components
{
    partial class PanelPersonnelBrowse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPersonnelBrowse));
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.testButton = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.testButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(39, 34);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(144, 28);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "iBeacon search:";
            // 
            // testButton
            // 
            this.testButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testButton.BackColor = System.Drawing.Color.Transparent;
            this.testButton.Image = ((System.Drawing.Image)(resources.GetObject("testButton.Image")));
            this.testButton.ImageActive = null;
            this.testButton.Location = new System.Drawing.Point(44, 79);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(84, 81);
            this.testButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.testButton.TabIndex = 9;
            this.testButton.TabStop = false;
            this.testButton.Zoom = 10;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // PanelPersonnelBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Name = "PanelPersonnelBrowse";
            this.Size = new System.Drawing.Size(1070, 636);
            ((System.ComponentModel.ISupportInitialize)(this.testButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuImageButton testButton;
    }
}
