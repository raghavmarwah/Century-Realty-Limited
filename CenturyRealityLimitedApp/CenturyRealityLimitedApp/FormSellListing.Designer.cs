namespace CenturyRealityLimitedApp
{
    partial class FormSellListing
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.realtorReport = new System.Windows.Forms.RichTextBox();
            this.buttonSellListing = new System.Windows.Forms.Button();
            this.textBoxBuyingParty = new System.Windows.Forms.TextBox();
            this.buttonCustomerReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(301, 40);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(280, 31);
            this.dateTimePicker.TabIndex = 0;
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Location = new System.Drawing.Point(666, 40);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(162, 51);
            this.buttonGenerateReport.TabIndex = 1;
            this.buttonGenerateReport.Text = "Generate Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // realtorReport
            // 
            this.realtorReport.Font = new System.Drawing.Font("Consolas", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realtorReport.Location = new System.Drawing.Point(32, 220);
            this.realtorReport.Name = "realtorReport";
            this.realtorReport.Size = new System.Drawing.Size(1312, 586);
            this.realtorReport.TabIndex = 2;
            this.realtorReport.Text = "";
            // 
            // buttonSellListing
            // 
            this.buttonSellListing.Enabled = false;
            this.buttonSellListing.Location = new System.Drawing.Point(305, 924);
            this.buttonSellListing.Name = "buttonSellListing";
            this.buttonSellListing.Size = new System.Drawing.Size(206, 67);
            this.buttonSellListing.TabIndex = 3;
            this.buttonSellListing.Text = "Sell Listing";
            this.buttonSellListing.UseVisualStyleBackColor = true;
            this.buttonSellListing.Click += new System.EventHandler(this.buttonSellListing_Click);
            // 
            // textBoxBuyingParty
            // 
            this.textBoxBuyingParty.Location = new System.Drawing.Point(305, 116);
            this.textBoxBuyingParty.Name = "textBoxBuyingParty";
            this.textBoxBuyingParty.Size = new System.Drawing.Size(290, 31);
            this.textBoxBuyingParty.TabIndex = 4;
            // 
            // buttonCustomerReport
            // 
            this.buttonCustomerReport.Location = new System.Drawing.Point(678, 925);
            this.buttonCustomerReport.Name = "buttonCustomerReport";
            this.buttonCustomerReport.Size = new System.Drawing.Size(218, 74);
            this.buttonCustomerReport.TabIndex = 5;
            this.buttonCustomerReport.Text = "Customer Report";
            this.buttonCustomerReport.UseVisualStyleBackColor = true;
            // 
            // FormSellListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 1149);
            this.Controls.Add(this.buttonCustomerReport);
            this.Controls.Add(this.textBoxBuyingParty);
            this.Controls.Add(this.buttonSellListing);
            this.Controls.Add(this.realtorReport);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "FormSellListing";
            this.Text = "FormSellListing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.RichTextBox realtorReport;
        private System.Windows.Forms.Button buttonSellListing;
        private System.Windows.Forms.TextBox textBoxBuyingParty;
        private System.Windows.Forms.Button buttonCustomerReport;
    }
}