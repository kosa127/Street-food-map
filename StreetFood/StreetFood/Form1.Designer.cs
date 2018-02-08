namespace StreetFood
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.addressGroup = new System.Windows.Forms.GroupBox();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.zipCodeBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.optionsGroup.SuspendLayout();
            this.addressGroup.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.optionsGroup);
            this.splitContainer1.Panel1.Controls.Add(this.addressGroup);
            this.splitContainer1.Panel1.Controls.Add(this.searchButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gMap);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1475, 842);
            this.splitContainer1.SplitterDistance = 334;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // optionsGroup
            // 
            this.optionsGroup.Controls.Add(this.label1);
            this.optionsGroup.Controls.Add(this.progressBar1);
            this.optionsGroup.Location = new System.Drawing.Point(16, 220);
            this.optionsGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optionsGroup.Name = "optionsGroup";
            this.optionsGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optionsGroup.Size = new System.Drawing.Size(311, 95);
            this.optionsGroup.TabIndex = 8;
            this.optionsGroup.TabStop = false;
            this.optionsGroup.Text = "Options";
            this.optionsGroup.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Night mode";
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBar1.Location = new System.Drawing.Point(104, 23);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Maximum = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(133, 28);
            this.progressBar1.TabIndex = 0;
            // 
            // addressGroup
            // 
            this.addressGroup.Controls.Add(this.streetBox);
            this.addressGroup.Controls.Add(this.zipCodeLabel);
            this.addressGroup.Controls.Add(this.cityBox);
            this.addressGroup.Controls.Add(this.zipCodeBox);
            this.addressGroup.Controls.Add(this.cityLabel);
            this.addressGroup.Controls.Add(this.streetLabel);
            this.addressGroup.Location = new System.Drawing.Point(16, 15);
            this.addressGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressGroup.Name = "addressGroup";
            this.addressGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressGroup.Size = new System.Drawing.Size(311, 181);
            this.addressGroup.TabIndex = 7;
            this.addressGroup.TabStop = false;
            this.addressGroup.Text = "Address";
            this.addressGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(104, 81);
            this.streetBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(169, 22);
            this.streetBox.TabIndex = 3;
            this.streetBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(15, 132);
            this.zipCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(63, 17);
            this.zipCodeLabel.TabIndex = 6;
            this.zipCodeLabel.Text = "Zip code";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(104, 36);
            this.cityBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(169, 22);
            this.cityBox.TabIndex = 1;
            this.cityBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // zipCodeBox
            // 
            this.zipCodeBox.Location = new System.Drawing.Point(104, 128);
            this.zipCodeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zipCodeBox.Name = "zipCodeBox";
            this.zipCodeBox.Size = new System.Drawing.Size(169, 22);
            this.zipCodeBox.TabIndex = 5;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(15, 39);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(31, 17);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City";
            this.cityLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(15, 85);
            this.streetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(46, 17);
            this.streetLabel.TabIndex = 4;
            this.streetLabel.Text = "Street";
            this.streetLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(16, 340);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(311, 47);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(0, 0);
            this.gMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
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
            this.gMap.Size = new System.Drawing.Size(1136, 842);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 0D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 842);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SFM - Street Food Map";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.optionsGroup.ResumeLayout(false);
            this.optionsGroup.PerformLayout();
            this.addressGroup.ResumeLayout(false);
            this.addressGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox zipCodeBox;
        private System.Windows.Forms.GroupBox addressGroup;
        private System.Windows.Forms.GroupBox optionsGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private GMap.NET.WindowsForms.GMapControl gMap;
    }
}

