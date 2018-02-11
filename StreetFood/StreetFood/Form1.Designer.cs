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
            this.searchButton = new System.Windows.Forms.Button();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.addressGroup = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.addressGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.addressGroup);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.optionsGroup);
            this.splitContainer1.Panel1.Controls.Add(this.searchButton);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gMap);
            this.splitContainer1.Size = new System.Drawing.Size(1475, 842);
            this.splitContainer1.SplitterDistance = 332;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // optionsGroup
            // 
            this.optionsGroup.Controls.Add(this.nightModeLabel);
            this.optionsGroup.Controls.Add(this.nightModeBar);
            this.optionsGroup.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.optionsGroup.Location = new System.Drawing.Point(16, 110);
            this.optionsGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optionsGroup.Name = "optionsGroup";
            this.optionsGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optionsGroup.Size = new System.Drawing.Size(298, 84);
            this.optionsGroup.TabIndex = 8;
            this.optionsGroup.TabStop = false;
            this.optionsGroup.Enter += new System.EventHandler(this.optionsGroup_Enter);
            // 
            // nightModeLabel
            // 
            this.nightModeLabel.AutoSize = true;
            this.nightModeLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nightModeLabel.Location = new System.Drawing.Point(15, 36);
            this.nightModeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nightModeLabel.Name = "nightModeLabel";
            this.nightModeLabel.Size = new System.Drawing.Size(89, 17);
            this.nightModeLabel.TabIndex = 1;
            this.nightModeLabel.Text = "Night mode";
            this.nightModeLabel.Click += new System.EventHandler(this.nightModeLabel_Click);
            // 
            // nightModeBar
            // 
            this.nightModeBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nightModeBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightModeBar.Location = new System.Drawing.Point(112, 36);
            this.nightModeBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nightModeBar.Maximum = 1;
            this.nightModeBar.Name = "nightModeBar";
            this.nightModeBar.Size = new System.Drawing.Size(16, 17);
            this.nightModeBar.Step = 1;
            this.nightModeBar.TabIndex = 0;
            this.nightModeBar.Click += new System.EventHandler(this.nightModeBar_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(215)))), ((int)(((byte)(183)))));
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.searchButton.Location = new System.Drawing.Point(16, 213);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(298, 47);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
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
            this.gMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.gMap.Size = new System.Drawing.Size(1138, 842);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 11D;
            this.gMap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMap_OnMarkerClick);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(15, 39);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 17);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City";
            this.cityLabel.Click += new System.EventHandler(this.cityLabel_Click);
            // 
            // cityBox
            // 
            this.cityBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.cityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.cityBox.Location = new System.Drawing.Point(115, 40);
            this.cityBox.Margin = new System.Windows.Forms.Padding(6);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(158, 16);
            this.cityBox.TabIndex = 1;
            this.cityBox.TextChanged += new System.EventHandler(this.cityBox_TextChanged);
            // 
            // addressGroup
            // 
            this.addressGroup.Controls.Add(this.cityBox);
            this.addressGroup.Controls.Add(this.cityLabel);
            this.addressGroup.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addressGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addressGroup.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addressGroup.Location = new System.Drawing.Point(16, 15);
            this.addressGroup.Margin = new System.Windows.Forms.Padding(4);
            this.addressGroup.Name = "addressGroup";
            this.addressGroup.Padding = new System.Windows.Forms.Padding(4);
            this.addressGroup.Size = new System.Drawing.Size(297, 87);
            this.addressGroup.TabIndex = 7;
            this.addressGroup.TabStop = false;
            this.addressGroup.Enter += new System.EventHandler(this.addressGroup_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 278);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(297, 167);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(297, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name: ";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 498);
            this.label2.MaximumSize = new System.Drawing.Size(298, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Description: ";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 842);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SFM - Street Food Map";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.addressGroup.ResumeLayout(false);
            this.addressGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox optionsGroup;
        private System.Windows.Forms.Label nightModeLabel;
        private System.Windows.Forms.ProgressBar nightModeBar;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.GroupBox addressGroup;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

