namespace CenturyRealityLimitedApp
{
    partial class FormPastListings
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
            this.dataGridViewPastListings = new System.Windows.Forms.DataGridView();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.labelListingsSold = new System.Windows.Forms.Label();
            this.labelCompanyRevenue = new System.Windows.Forms.Label();
            this.labelListingsSoldInfo = new System.Windows.Forms.Label();
            this.labelCompanyRevenueInfo = new System.Windows.Forms.Label();
            this.labelFilterInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPastListings)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPastListings
            // 
            this.dataGridViewPastListings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPastListings.Location = new System.Drawing.Point(33, 30);
            this.dataGridViewPastListings.Name = "dataGridViewPastListings";
            this.dataGridViewPastListings.RowTemplate.Height = 33;
            this.dataGridViewPastListings.Size = new System.Drawing.Size(1617, 656);
            this.dataGridViewPastListings.TabIndex = 0;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "All",
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "June",
            "July",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.comboBoxMonth.Location = new System.Drawing.Point(949, 762);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(281, 39);
            this.comboBoxMonth.TabIndex = 1;
            // 
            // labelListingsSold
            // 
            this.labelListingsSold.AutoSize = true;
            this.labelListingsSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListingsSold.Location = new System.Drawing.Point(360, 765);
            this.labelListingsSold.Name = "labelListingsSold";
            this.labelListingsSold.Size = new System.Drawing.Size(86, 31);
            this.labelListingsSold.TabIndex = 2;
            this.labelListingsSold.Text = "label1";
            // 
            // labelCompanyRevenue
            // 
            this.labelCompanyRevenue.AutoSize = true;
            this.labelCompanyRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyRevenue.Location = new System.Drawing.Point(360, 835);
            this.labelCompanyRevenue.Name = "labelCompanyRevenue";
            this.labelCompanyRevenue.Size = new System.Drawing.Size(86, 31);
            this.labelCompanyRevenue.TabIndex = 3;
            this.labelCompanyRevenue.Text = "label2";
            // 
            // labelListingsSoldInfo
            // 
            this.labelListingsSoldInfo.AutoSize = true;
            this.labelListingsSoldInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListingsSoldInfo.Location = new System.Drawing.Point(28, 765);
            this.labelListingsSoldInfo.Name = "labelListingsSoldInfo";
            this.labelListingsSoldInfo.Size = new System.Drawing.Size(309, 31);
            this.labelListingsSoldInfo.TabIndex = 4;
            this.labelListingsSoldInfo.Text = "Number of Listings Sold:";
            // 
            // labelCompanyRevenueInfo
            // 
            this.labelCompanyRevenueInfo.AutoSize = true;
            this.labelCompanyRevenueInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyRevenueInfo.Location = new System.Drawing.Point(28, 835);
            this.labelCompanyRevenueInfo.Name = "labelCompanyRevenueInfo";
            this.labelCompanyRevenueInfo.Size = new System.Drawing.Size(300, 31);
            this.labelCompanyRevenueInfo.TabIndex = 5;
            this.labelCompanyRevenueInfo.Text = "Total Revenue Earned: ";
            // 
            // labelFilterInfo
            // 
            this.labelFilterInfo.AutoSize = true;
            this.labelFilterInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterInfo.Location = new System.Drawing.Point(707, 765);
            this.labelFilterInfo.Name = "labelFilterInfo";
            this.labelFilterInfo.Size = new System.Drawing.Size(196, 31);
            this.labelFilterInfo.TabIndex = 6;
            this.labelFilterInfo.Text = "Filter By Month";
            // 
            // FormPastListings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 1013);
            this.Controls.Add(this.labelFilterInfo);
            this.Controls.Add(this.labelCompanyRevenueInfo);
            this.Controls.Add(this.labelListingsSoldInfo);
            this.Controls.Add(this.labelCompanyRevenue);
            this.Controls.Add(this.labelListingsSold);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.dataGridViewPastListings);
            this.Name = "FormPastListings";
            this.Text = "Past Listings";
            this.Load += new System.EventHandler(this.FormPastListings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPastListings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPastListings;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Label labelListingsSold;
        private System.Windows.Forms.Label labelCompanyRevenue;
        private System.Windows.Forms.Label labelListingsSoldInfo;
        private System.Windows.Forms.Label labelCompanyRevenueInfo;
        private System.Windows.Forms.Label labelFilterInfo;
    }
}