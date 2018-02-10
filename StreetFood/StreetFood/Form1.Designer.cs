namespace StreetFood
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.optionsGroup = new System.Windows.Forms.GroupBox();
            this.nightModeLabel = new System.Windows.Forms.Label();
            this.nightModeBar = new System.Windows.Forms.ProgressBar();
            this.addressGroup = new System.Windows.Forms.GroupBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.addressGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.addressGroup);
            this.splitContainer1.Panel1.Controls.Add(this.searchButton);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gMap);
            this.splitContainer1.Size = new System.Drawing.Size(1106, 684);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.TabIndex = 0;
            // 
            // optionsGroup
            // 
            this.optionsGroup.Controls.Add(this.nightModeLabel);
            this.optionsGroup.Controls.Add(this.nightModeBar);
            this.optionsGroup.Location = new System.Drawing.Point(14, 89);
            this.optionsGroup.Name = "optionsGroup";
            this.optionsGroup.Size = new System.Drawing.Size(221, 77);
            this.optionsGroup.TabIndex = 8;
            this.optionsGroup.TabStop = false;
            this.optionsGroup.Text = "Options";
            // 
            // nightModeLabel
            // 
            this.nightModeLabel.AutoSize = true;
            this.nightModeLabel.Location = new System.Drawing.Point(11, 29);
            this.nightModeLabel.Name = "nightModeLabel";
            this.nightModeLabel.Size = new System.Drawing.Size(61, 13);
            this.nightModeLabel.TabIndex = 1;
            this.nightModeLabel.Text = "Night mode";
            // 
            // nightModeBar
            // 
            this.nightModeBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nightModeBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightModeBar.Location = new System.Drawing.Point(78, 24);
            this.nightModeBar.Maximum = 1;
            this.nightModeBar.Name = "nightModeBar";
            this.nightModeBar.Size = new System.Drawing.Size(38, 23);
            this.nightModeBar.Step = 1;
            this.nightModeBar.TabIndex = 0;
            this.nightModeBar.Click += new System.EventHandler(this.nightModeBar_Click);
            // 
            // addressGroup
            // 
            this.addressGroup.Controls.Add(this.cityBox);
            this.addressGroup.Controls.Add(this.cityLabel);
            this.addressGroup.Location = new System.Drawing.Point(12, 12);
            this.addressGroup.Name = "addressGroup";
            this.addressGroup.Size = new System.Drawing.Size(223, 71);
            this.addressGroup.TabIndex = 7;
            this.addressGroup.TabStop = false;
            this.addressGroup.Text = "Type desired cityname";
            this.addressGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(78, 29);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(128, 20);
            this.cityBox.TabIndex = 1;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(11, 32);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 184);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(223, 38);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search !";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // gMap
            // 
            this.gMap.AutoScroll = true;
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(0, 0);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 24;
            this.gMap.MinZoom = 4;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(853, 684);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 11D;
            this.gMap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMap_OnMarkerClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 684);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SFM - Street Food Map";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.addressGroup.ResumeLayout(false);
            this.addressGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.GroupBox addressGroup;
        private System.Windows.Forms.GroupBox optionsGroup;
        private System.Windows.Forms.Label nightModeLabel;
        private System.Windows.Forms.ProgressBar nightModeBar;
        private GMap.NET.WindowsForms.GMapControl gMap;
    }
}

