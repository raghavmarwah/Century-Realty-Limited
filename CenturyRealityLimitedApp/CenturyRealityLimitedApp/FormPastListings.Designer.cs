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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPastListings)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPastListings
            // 
            this.dataGridViewPastListings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPastListings.Location = new System.Drawing.Point(33, 30);
            this.dataGridViewPastListings.Name = "dataGridViewPastListings";
            this.dataGridViewPastListings.RowTemplate.Height = 33;
            this.dataGridViewPastListings.Size = new System.Drawing.Size(1452, 656);
            this.dataGridViewPastListings.TabIndex = 0;
            // 
            // comboBoxMonth
            // 
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
            this.comboBoxMonth.Location = new System.Drawing.Point(1095, 862);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(281, 33);
            this.comboBoxMonth.TabIndex = 1;
            // 
            // labelListingsSold
            // 
            this.labelListingsSold.AutoSize = true;
            this.labelListingsSold.Location = new System.Drawing.Point(171, 789);
            this.labelListingsSold.Name = "labelListingsSold";
            this.labelListingsSold.Size = new System.Drawing.Size(70, 25);
            this.labelListingsSold.TabIndex = 2;
            this.labelListingsSold.Text = "label1";
            // 
            // labelCompanyRevenue
            // 
            this.labelCompanyRevenue.AutoSize = true;
            this.labelCompanyRevenue.Location = new System.Drawing.Point(317, 789);
            this.labelCompanyRevenue.Name = "labelCompanyRevenue";
            this.labelCompanyRevenue.Size = new System.Drawing.Size(70, 25);
            this.labelCompanyRevenue.TabIndex = 3;
            this.labelCompanyRevenue.Text = "label2";
            // 
            // FormPastListings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 1013);
            this.Controls.Add(this.labelCompanyRevenue);
            this.Controls.Add(this.labelListingsSold);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.dataGridViewPastListings);
            this.Name = "FormPastListings";
            this.Text = "FormPastListings";
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
    }
}