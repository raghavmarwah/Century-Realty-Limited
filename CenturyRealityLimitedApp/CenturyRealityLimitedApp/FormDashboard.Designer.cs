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
            this.buttonAddNewListing = new System.Windows.Forms.Button();
            this.dataGridViewActiveListings = new System.Windows.Forms.DataGridView();
            this.buttonSellListing = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonViewAgents = new System.Windows.Forms.Button();
            this.buttonPastListings = new System.Windows.Forms.Button();
            this.labelDisplayUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveListings)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddNewListing
            // 
            this.buttonAddNewListing.Location = new System.Drawing.Point(660, 592);
            this.buttonAddNewListing.Name = "buttonAddNewListing";
            this.buttonAddNewListing.Size = new System.Drawing.Size(181, 93);
            this.buttonAddNewListing.TabIndex = 0;
            this.buttonAddNewListing.Text = "Add Listing";
            this.buttonAddNewListing.UseVisualStyleBackColor = true;
            this.buttonAddNewListing.Click += new System.EventHandler(this.buttonAddListing_Click);
            // 
            // dataGridViewActiveListings
            // 
            this.dataGridViewActiveListings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActiveListings.Location = new System.Drawing.Point(35, 32);
            this.dataGridViewActiveListings.Name = "dataGridViewActiveListings";
            this.dataGridViewActiveListings.RowTemplate.Height = 33;
            this.dataGridViewActiveListings.Size = new System.Drawing.Size(1721, 492);
            this.dataGridViewActiveListings.TabIndex = 1;
            // 
            // buttonSellListing
            // 
            this.buttonSellListing.Location = new System.Drawing.Point(903, 588);
            this.buttonSellListing.Name = "buttonSellListing";
            this.buttonSellListing.Size = new System.Drawing.Size(226, 96);
            this.buttonSellListing.TabIndex = 2;
            this.buttonSellListing.Text = "Sell This Listing";
            this.buttonSellListing.UseVisualStyleBackColor = true;
            this.buttonSellListing.Click += new System.EventHandler(this.buttonSellListing_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(1197, 588);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(223, 96);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh Data";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonViewAgents
            // 
            this.buttonViewAgents.Location = new System.Drawing.Point(64, 591);
            this.buttonViewAgents.Name = "buttonViewAgents";
            this.buttonViewAgents.Size = new System.Drawing.Size(225, 93);
            this.buttonViewAgents.TabIndex = 4;
            this.buttonViewAgents.Text = "View Agents";
            this.buttonViewAgents.UseVisualStyleBackColor = true;
            this.buttonViewAgents.Click += new System.EventHandler(this.buttonViewAgents_Click);
            // 
            // buttonPastListings
            // 
            this.buttonPastListings.Location = new System.Drawing.Point(67, 754);
            this.buttonPastListings.Name = "buttonPastListings";
            this.buttonPastListings.Size = new System.Drawing.Size(221, 108);
            this.buttonPastListings.TabIndex = 5;
            this.buttonPastListings.Text = "Past Listings";
            this.buttonPastListings.UseVisualStyleBackColor = true;
            this.buttonPastListings.Click += new System.EventHandler(this.buttonPastListings_Click);
            // 
            // labelDisplayUser
            // 
            this.labelDisplayUser.AutoSize = true;
            this.labelDisplayUser.Location = new System.Drawing.Point(679, 932);
            this.labelDisplayUser.Name = "labelDisplayUser";
            this.labelDisplayUser.Size = new System.Drawing.Size(70, 25);
            this.labelDisplayUser.TabIndex = 6;
            this.labelDisplayUser.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 931);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 101);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1977, 1199);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDisplayUser);
            this.Controls.Add(this.buttonPastListings);
            this.Controls.Add(this.buttonViewAgents);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSellListing);
            this.Controls.Add(this.dataGridViewActiveListings);
            this.Controls.Add(this.buttonAddNewListing);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveListings)).EndInit();
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
        private System.Windows.Forms.Label labelDisplayUser;
        private System.Windows.Forms.Button button1;
    }
}