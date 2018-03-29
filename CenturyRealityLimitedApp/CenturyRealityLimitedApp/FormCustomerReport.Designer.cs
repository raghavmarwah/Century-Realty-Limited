namespace CenturyRealityLimitedApp
{
    partial class FormCustomerReport
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
            this.customerReport = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // customerReport
            // 
            this.customerReport.Font = new System.Drawing.Font("Consolas", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerReport.Location = new System.Drawing.Point(9, 12);
            this.customerReport.Name = "customerReport";
            this.customerReport.Size = new System.Drawing.Size(1295, 983);
            this.customerReport.TabIndex = 0;
            this.customerReport.Text = "";
            // 
            // FormCustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 1145);
            this.Controls.Add(this.customerReport);
            this.Name = "FormCustomerReport";
            this.Text = "FormCustomerReport";
            this.Load += new System.EventHandler(this.FormCustomerReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox customerReport;
    }
}