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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.paymentMethodsLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressGroup = new System.Windows.Forms.GroupBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.optionsGroup = new System.Windows.Forms.GroupBox();
            this.nightModeLabel = new System.Windows.Forms.Label();
            this.nightModeBar = new System.Windows.Forms.ProgressBar();
            this.searchButton = new System.Windows.Forms.Button();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.twitterIcon = new System.Windows.Forms.PictureBox();
            this.instagramIcon = new System.Windows.Forms.PictureBox();
            this.facebookIcon = new System.Windows.Forms.PictureBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.resultGroupBox.SuspendLayout();
            this.addressGroup.SuspendLayout();
            this.optionsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.twitterIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instagramIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.splitContainer1.Panel1.Controls.Add(this.resultGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.addressGroup);
            this.splitContainer1.Panel1.Controls.Add(this.imageBox);
            this.splitContainer1.Panel1.Controls.Add(this.optionsGroup);
            this.splitContainer1.Panel1.Controls.Add(this.searchButton);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gMap);
            this.splitContainer1.Size = new System.Drawing.Size(1106, 684);
            this.splitContainer1.SplitterDistance = 247;
            this.splitContainer1.TabIndex = 0;
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.AutoSize = true;
            this.resultGroupBox.Controls.Add(this.twitterIcon);
            this.resultGroupBox.Controls.Add(this.instagramIcon);
            this.resultGroupBox.Controls.Add(this.facebookIcon);
            this.resultGroupBox.Controls.Add(this.paymentMethodsLabel);
            this.resultGroupBox.Controls.Add(this.descriptionLabel);
            this.resultGroupBox.Controls.Add(this.nameLabel);
            this.resultGroupBox.Location = new System.Drawing.Point(12, 378);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.resultGroupBox.Size = new System.Drawing.Size(223, 294);
            this.resultGroupBox.TabIndex = 11;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Visible = false;
            // 
            // paymentMethodsLabel
            // 
            this.paymentMethodsLabel.AutoSize = true;
            this.paymentMethodsLabel.Location = new System.Drawing.Point(12, 109);
            this.paymentMethodsLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.paymentMethodsLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.paymentMethodsLabel.Name = "paymentMethodsLabel";
            this.paymentMethodsLabel.Size = new System.Drawing.Size(97, 13);
            this.paymentMethodsLabel.TabIndex = 11;
            this.paymentMethodsLabel.Text = "Payment methods: ";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(11, 166);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(66, 13);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Description: ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(11, 32);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name: ";
            // 
            // addressGroup
            // 
            this.addressGroup.Controls.Add(this.cityBox);
            this.addressGroup.Controls.Add(this.cityLabel);
            this.addressGroup.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addressGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addressGroup.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addressGroup.Location = new System.Drawing.Point(12, 12);
            this.addressGroup.Name = "addressGroup";
            this.addressGroup.Size = new System.Drawing.Size(223, 71);
            this.addressGroup.TabIndex = 7;
            this.addressGroup.TabStop = false;
            // 
            // cityBox
            // 
            this.cityBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.cityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.cityBox.Location = new System.Drawing.Point(86, 32);
            this.cityBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(118, 13);
            this.cityBox.TabIndex = 1;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(11, 32);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(30, 13);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City";
            // 
            // optionsGroup
            // 
            this.optionsGroup.Controls.Add(this.nightModeLabel);
            this.optionsGroup.Controls.Add(this.nightModeBar);
            this.optionsGroup.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.optionsGroup.Location = new System.Drawing.Point(12, 89);
            this.optionsGroup.Name = "optionsGroup";
            this.optionsGroup.Size = new System.Drawing.Size(224, 68);
            this.optionsGroup.TabIndex = 8;
            this.optionsGroup.TabStop = false;
            // 
            // nightModeLabel
            // 
            this.nightModeLabel.AutoSize = true;
            this.nightModeLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nightModeLabel.Location = new System.Drawing.Point(12, 30);
            this.nightModeLabel.Name = "nightModeLabel";
            this.nightModeLabel.Size = new System.Drawing.Size(72, 13);
            this.nightModeLabel.TabIndex = 1;
            this.nightModeLabel.Text = "Night mode";
            // 
            // nightModeBar
            // 
            this.nightModeBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nightModeBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightModeBar.Location = new System.Drawing.Point(90, 30);
            this.nightModeBar.Maximum = 1;
            this.nightModeBar.Name = "nightModeBar";
            this.nightModeBar.Size = new System.Drawing.Size(12, 14);
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
            this.searchButton.Location = new System.Drawing.Point(12, 173);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(224, 38);
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
            this.gMap.Size = new System.Drawing.Size(855, 684);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 11D;
            this.gMap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMap_OnMarkerClick);
            // 
            // twitterIcon
            // 
            this.twitterIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twitterIcon.Image = global::StreetFood.Properties.Resources.twitter_icon;
            this.twitterIcon.Location = new System.Drawing.Point(17, 56);
            this.twitterIcon.Name = "twitterIcon";
            this.twitterIcon.Size = new System.Drawing.Size(35, 35);
            this.twitterIcon.TabIndex = 14;
            this.twitterIcon.TabStop = false;
            this.twitterIcon.Click += new System.EventHandler(this.twitterIcon_Click);
            // 
            // instagramIcon
            // 
            this.instagramIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instagramIcon.Image = ((System.Drawing.Image)(resources.GetObject("instagramIcon.Image")));
            this.instagramIcon.InitialImage = null;
            this.instagramIcon.Location = new System.Drawing.Point(90, 56);
            this.instagramIcon.Name = "instagramIcon";
            this.instagramIcon.Size = new System.Drawing.Size(35, 35);
            this.instagramIcon.TabIndex = 13;
            this.instagramIcon.TabStop = false;
            this.instagramIcon.Click += new System.EventHandler(this.instagramIcon_Click);
            // 
            // facebookIcon
            // 
            this.facebookIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facebookIcon.Image = global::StreetFood.Properties.Resources.facebook_icon;
            this.facebookIcon.Location = new System.Drawing.Point(169, 56);
            this.facebookIcon.Name = "facebookIcon";
            this.facebookIcon.Size = new System.Drawing.Size(33, 35);
            this.facebookIcon.TabIndex = 12;
            this.facebookIcon.TabStop = false;
            this.facebookIcon.Visible = false;
            this.facebookIcon.Click += new System.EventHandler(this.facebookIcon_Click);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(13, 226);
            this.imageBox.Margin = new System.Windows.Forms.Padding(2);
            this.imageBox.MaximumSize = new System.Drawing.Size(223, 136);
            this.imageBox.MinimumSize = new System.Drawing.Size(223, 136);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(223, 136);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            this.imageBox.Visible = false;
            this.imageBox.WaitOnLoad = true;
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            this.addressGroup.ResumeLayout(false);
            this.addressGroup.PerformLayout();
            this.optionsGroup.ResumeLayout(false);
            this.optionsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.twitterIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instagramIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
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
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.Label paymentMethodsLabel;
        private System.Windows.Forms.PictureBox facebookIcon;
        private System.Windows.Forms.PictureBox instagramIcon;
        private System.Windows.Forms.PictureBox twitterIcon;
    }
}

