namespace CenturyRealityLimitedApp
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.buttonAddNewListing = new System.Windows.Forms.Button();
            this.dataGridViewActiveListings = new System.Windows.Forms.DataGridView();
            this.buttonSellListing = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonViewAgents = new System.Windows.Forms.Button();
            this.buttonPastListings = new System.Windows.Forms.Button();
            this.buttonEditProfile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxMainLogo = new System.Windows.Forms.PictureBox();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.labelActiveListings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveListings)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddNewListing
            // 
            this.buttonAddNewListing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(146)))));
            this.buttonAddNewListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewListing.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewListing.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonAddNewListing.Location = new System.Drawing.Point(779, 865);
            this.buttonAddNewListing.Name = "buttonAddNewListing";
            this.buttonAddNewListing.Size = new System.Drawing.Size(292, 71);
            this.buttonAddNewListing.TabIndex = 0;
            this.buttonAddNewListing.Text = "Add Listing";
            this.buttonAddNewListing.UseVisualStyleBackColor = false;
            this.buttonAddNewListing.Click += new System.EventHandler(this.buttonAddListing_Click);
            // 
            // dataGridViewActiveListings
            // 
            this.dataGridViewActiveListings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActiveListings.Location = new System.Drawing.Point(439, 115);
            this.dataGridViewActiveListings.Name = "dataGridViewActiveListings";
            this.dataGridViewActiveListings.RowTemplate.Height = 33;
            this.dataGridViewActiveListings.Size = new System.Drawing.Size(1690, 682);
            this.dataGridViewActiveListings.TabIndex = 1;
            // 
            // buttonSellListing
            // 
            this.buttonSellListing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(146)))));
            this.buttonSellListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSellListing.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSellListing.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonSellListing.Location = new System.Drawing.Point(1126, 865);
            this.buttonSellListing.Name = "buttonSellListing";
            this.buttonSellListing.Size = new System.Drawing.Size(292, 71);
            this.buttonSellListing.TabIndex = 2;
            this.buttonSellListing.Text = "Sell This Listing";
            this.buttonSellListing.UseVisualStyleBackColor = false;
            this.buttonSellListing.Click += new System.EventHandler(this.buttonSellListing_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(146)))));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonRefresh.Location = new System.Drawing.Point(1480, 865);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(292, 71);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh Data";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonViewAgents
            // 
            this.buttonViewAgents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.buttonViewAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewAgents.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewAgents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonViewAgents.Location = new System.Drawing.Point(3, 581);
            this.buttonViewAgents.Name = "buttonViewAgents";
            this.buttonViewAgents.Size = new System.Drawing.Size(373, 129);
            this.buttonViewAgents.TabIndex = 4;
            this.buttonViewAgents.Text = "View Agents";
            this.buttonViewAgents.UseVisualStyleBackColor = false;
            this.buttonViewAgents.Click += new System.EventHandler(this.buttonViewAgents_Click);
            // 
            // buttonPastListings
            // 
            this.buttonPastListings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.buttonPastListings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPastListings.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPastListings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPastListings.Location = new System.Drawing.Point(3, 716);
            this.buttonPastListings.Name = "buttonPastListings";
            this.buttonPastListings.Size = new System.Drawing.Size(376, 129);
            this.buttonPastListings.TabIndex = 5;
            this.buttonPastListings.Text = "Past Listings";
            this.buttonPastListings.UseVisualStyleBackColor = false;
            this.buttonPastListings.Click += new System.EventHandler(this.buttonPastListings_Click);
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.buttonEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditProfile.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditProfile.Location = new System.Drawing.Point(0, 851);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.Size = new System.Drawing.Size(376, 129);
            this.buttonEditProfile.TabIndex = 7;
            this.buttonEditProfile.Text = "Edit Profile";
            this.buttonEditProfile.UseVisualStyleBackColor = false;
            this.buttonEditProfile.Click += new System.EventHandler(this.buttonEditProfile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pictureBoxMainLogo);
            this.panel1.Controls.Add(this.buttonEditProfile);
            this.panel1.Controls.Add(this.buttonViewAgents);
            this.panel1.Controls.Add(this.buttonPastListings);
            this.panel1.Location = new System.Drawing.Point(-4, -16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 1227);
            this.panel1.TabIndex = 8;
            // 
            // pictureBoxMainLogo
            // 
            this.pictureBoxMainLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMainLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainLogo.Image")));
            this.pictureBoxMainLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMainLogo.Name = "pictureBoxMainLogo";
            this.pictureBoxMainLogo.Size = new System.Drawing.Size(373, 502);
            this.pictureBoxMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMainLogo.TabIndex = 1;
            this.pictureBoxMainLogo.TabStop = false;
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseForm.Font = new System.Drawing.Font("Eras Bold ITC", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseForm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCloseForm.Location = new System.Drawing.Point(2128, 0);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(75, 68);
            this.buttonCloseForm.TabIndex = 9;
            this.buttonCloseForm.Text = "X";
            this.buttonCloseForm.UseVisualStyleBackColor = false;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // labelActiveListings
            // 
            this.labelActiveListings.AutoSize = true;
            this.labelActiveListings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActiveListings.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelActiveListings.Location = new System.Drawing.Point(434, 53);
            this.labelActiveListings.Name = "labelActiveListings";
            this.labelActiveListings.Size = new System.Drawing.Size(218, 33);
            this.labelActiveListings.TabIndex = 10;
            this.labelActiveListings.Text = "Active Listings";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(2202, 1144);
            this.Controls.Add(this.labelActiveListings);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSellListing);
            this.Controls.Add(this.dataGridViewActiveListings);
            this.Controls.Add(this.buttonAddNewListing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveListings)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddNewListing;
        private System.Windows.Forms.DataGridView dataGridViewActiveListings;
        private System.Windows.Forms.Button buttonSellListing;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonViewAgents;
        private System.Windows.Forms.Button buttonPastListings;
        private System.Windows.Forms.Button buttonEditProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxMainLogo;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Label labelActiveListings;
    }
}