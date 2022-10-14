
namespace Ip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxInputIP = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelInfoIP = new System.Windows.Forms.Label();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.panelControl = new System.Windows.Forms.Panel();
            this.labelCreatorName = new System.Windows.Forms.Label();
            this.checkBoxAvtoStart = new System.Windows.Forms.CheckBox();
            this.pictureBoxControlUp = new System.Windows.Forms.PictureBox();
            this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
            this.panelLanguage = new System.Windows.Forms.Panel();
            this.pictureBoxControlRight = new System.Windows.Forms.PictureBox();
            this.checkBoxRUS = new System.Windows.Forms.CheckBox();
            this.checkBoxENG = new System.Windows.Forms.CheckBox();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxControlUp)).BeginInit();
            this.panelLanguage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxControlRight)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInputIP
            // 
            this.textBoxInputIP.Location = new System.Drawing.Point(12, 467);
            this.textBoxInputIP.Name = "textBoxInputIP";
            this.textBoxInputIP.Size = new System.Drawing.Size(383, 22);
            this.textBoxInputIP.TabIndex = 0;
            this.textBoxInputIP.TextChanged += new System.EventHandler(this.textBoxInputIP_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 495);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(383, 46);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // labelInfoIP
            // 
            this.labelInfoIP.Location = new System.Drawing.Point(12, 309);
            this.labelInfoIP.Name = "labelInfoIP";
            this.labelInfoIP.Size = new System.Drawing.Size(383, 155);
            this.labelInfoIP.TabIndex = 2;
            this.labelInfoIP.Text = "IP V4";
            this.labelInfoIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemory = 5;
            this.gMapControl.Location = new System.Drawing.Point(12, 12);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 2;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(383, 294);
            this.gMapControl.TabIndex = 3;
            this.gMapControl.Zoom = 0D;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.SystemColors.Menu;
            this.panelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControl.Controls.Add(this.labelCreatorName);
            this.panelControl.Controls.Add(this.checkBoxAvtoStart);
            this.panelControl.Controls.Add(this.pictureBoxControlUp);
            this.panelControl.Controls.Add(this.checkBoxTopMost);
            this.panelControl.Location = new System.Drawing.Point(12, 312);
            this.panelControl.MaximumSize = new System.Drawing.Size(92, 152);
            this.panelControl.MinimumSize = new System.Drawing.Size(92, 20);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(92, 150);
            this.panelControl.TabIndex = 4;
            // 
            // labelCreatorName
            // 
            this.labelCreatorName.AutoSize = true;
            this.labelCreatorName.Location = new System.Drawing.Point(3, 131);
            this.labelCreatorName.Name = "labelCreatorName";
            this.labelCreatorName.Size = new System.Drawing.Size(77, 17);
            this.labelCreatorName.TabIndex = 4;
            this.labelCreatorName.Text = "by MilkRen";
            // 
            // checkBoxAvtoStart
            // 
            this.checkBoxAvtoStart.Location = new System.Drawing.Point(2, 74);
            this.checkBoxAvtoStart.Name = "checkBoxAvtoStart";
            this.checkBoxAvtoStart.Size = new System.Drawing.Size(86, 45);
            this.checkBoxAvtoStart.TabIndex = 3;
            this.checkBoxAvtoStart.Text = "AvtoRun";
            this.checkBoxAvtoStart.UseVisualStyleBackColor = true;
            // 
            // pictureBoxControlUp
            // 
            this.pictureBoxControlUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxControlUp.Image = global::Ip.Properties.Resources.Up_;
            this.pictureBoxControlUp.Location = new System.Drawing.Point(22, 2);
            this.pictureBoxControlUp.Name = "pictureBoxControlUp";
            this.pictureBoxControlUp.Size = new System.Drawing.Size(46, 15);
            this.pictureBoxControlUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxControlUp.TabIndex = 0;
            this.pictureBoxControlUp.TabStop = false;
            // 
            // checkBoxTopMost
            // 
            this.checkBoxTopMost.Location = new System.Drawing.Point(2, 23);
            this.checkBoxTopMost.Name = "checkBoxTopMost";
            this.checkBoxTopMost.Size = new System.Drawing.Size(86, 45);
            this.checkBoxTopMost.TabIndex = 2;
            this.checkBoxTopMost.Text = "TopMost";
            this.checkBoxTopMost.UseVisualStyleBackColor = true;
            // 
            // panelLanguage
            // 
            this.panelLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLanguage.Controls.Add(this.pictureBoxControlRight);
            this.panelLanguage.Controls.Add(this.checkBoxRUS);
            this.panelLanguage.Controls.Add(this.checkBoxENG);
            this.panelLanguage.Location = new System.Drawing.Point(110, 405);
            this.panelLanguage.MaximumSize = new System.Drawing.Size(111, 56);
            this.panelLanguage.MinimumSize = new System.Drawing.Size(20, 56);
            this.panelLanguage.Name = "panelLanguage";
            this.panelLanguage.Size = new System.Drawing.Size(111, 56);
            this.panelLanguage.TabIndex = 5;
            // 
            // pictureBoxControlRight
            // 
            this.pictureBoxControlRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxControlRight.Image = global::Ip.Properties.Resources.Right;
            this.pictureBoxControlRight.Location = new System.Drawing.Point(86, 12);
            this.pictureBoxControlRight.Name = "pictureBoxControlRight";
            this.pictureBoxControlRight.Size = new System.Drawing.Size(14, 28);
            this.pictureBoxControlRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxControlRight.TabIndex = 4;
            this.pictureBoxControlRight.TabStop = false;
            // 
            // checkBoxRUS
            // 
            this.checkBoxRUS.AutoSize = true;
            this.checkBoxRUS.Location = new System.Drawing.Point(20, 3);
            this.checkBoxRUS.Name = "checkBoxRUS";
            this.checkBoxRUS.Size = new System.Drawing.Size(59, 21);
            this.checkBoxRUS.TabIndex = 1;
            this.checkBoxRUS.Text = "RUS";
            this.checkBoxRUS.UseVisualStyleBackColor = true;
            // 
            // checkBoxENG
            // 
            this.checkBoxENG.AutoSize = true;
            this.checkBoxENG.Location = new System.Drawing.Point(20, 30);
            this.checkBoxENG.Name = "checkBoxENG";
            this.checkBoxENG.Size = new System.Drawing.Size(60, 21);
            this.checkBoxENG.TabIndex = 0;
            this.checkBoxENG.Text = "ENG";
            this.checkBoxENG.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 553);
            this.Controls.Add(this.panelLanguage);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.gMapControl);
            this.Controls.Add(this.labelInfoIP);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxInputIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(425, 600);
            this.MinimumSize = new System.Drawing.Size(425, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxControlUp)).EndInit();
            this.panelLanguage.ResumeLayout(false);
            this.panelLanguage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxControlRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputIP;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelInfoIP;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.CheckBox checkBoxTopMost;
        private System.Windows.Forms.CheckBox checkBoxAvtoStart;
        private System.Windows.Forms.PictureBox pictureBoxControlUp;
        private System.Windows.Forms.Panel panelLanguage;
        private System.Windows.Forms.CheckBox checkBoxRUS;
        private System.Windows.Forms.CheckBox checkBoxENG;
        private System.Windows.Forms.PictureBox pictureBoxControlRight;
        private System.Windows.Forms.Label labelCreatorName;
    }
}

