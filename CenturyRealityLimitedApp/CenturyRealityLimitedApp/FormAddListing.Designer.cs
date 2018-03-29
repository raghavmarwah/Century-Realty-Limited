namespace CenturyRealityLimitedApp
{
    partial class FormAddListing
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
            this.textBoxStreetAddress = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxPincode = new System.Windows.Forms.TextBox();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.textBoxListPrice = new System.Windows.Forms.TextBox();
            this.textBoxSellerName = new System.Windows.Forms.TextBox();
            this.textBoxFloorArea = new System.Windows.Forms.TextBox();
            this.textBoxBathrooms = new System.Windows.Forms.TextBox();
            this.textBoxBedrooms = new System.Windows.Forms.TextBox();
            this.listBoxHouseType = new System.Windows.Forms.ListBox();
            this.buttonAddListing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxStreetAddress
            // 
            this.textBoxStreetAddress.Location = new System.Drawing.Point(71, 67);
            this.textBoxStreetAddress.Name = "textBoxStreetAddress";
            this.textBoxStreetAddress.Size = new System.Drawing.Size(100, 31);
            this.textBoxStreetAddress.TabIndex = 0;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(252, 78);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 31);
            this.textBoxCity.TabIndex = 1;
            // 
            // textBoxPincode
            // 
            this.textBoxPincode.Location = new System.Drawing.Point(441, 91);
            this.textBoxPincode.Name = "textBoxPincode";
            this.textBoxPincode.Size = new System.Drawing.Size(100, 31);
            this.textBoxPincode.TabIndex = 2;
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.Location = new System.Drawing.Point(618, 91);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(100, 31);
            this.textBoxProvince.TabIndex = 3;
            // 
            // textBoxListPrice
            // 
            this.textBoxListPrice.Location = new System.Drawing.Point(782, 261);
            this.textBoxListPrice.Name = "textBoxListPrice";
            this.textBoxListPrice.Size = new System.Drawing.Size(100, 31);
            this.textBoxListPrice.TabIndex = 5;
            // 
            // textBoxSellerName
            // 
            this.textBoxSellerName.Location = new System.Drawing.Point(636, 270);
            this.textBoxSellerName.Name = "textBoxSellerName";
            this.textBoxSellerName.Size = new System.Drawing.Size(100, 31);
            this.textBoxSellerName.TabIndex = 6;
            // 
            // textBoxFloorArea
            // 
            this.textBoxFloorArea.Location = new System.Drawing.Point(465, 270);
            this.textBoxFloorArea.Name = "textBoxFloorArea";
            this.textBoxFloorArea.Size = new System.Drawing.Size(100, 31);
            this.textBoxFloorArea.TabIndex = 7;
            // 
            // textBoxBathrooms
            // 
            this.textBoxBathrooms.Location = new System.Drawing.Point(284, 248);
            this.textBoxBathrooms.Name = "textBoxBathrooms";
            this.textBoxBathrooms.Size = new System.Drawing.Size(100, 31);
            this.textBoxBathrooms.TabIndex = 8;
            // 
            // textBoxBedrooms
            // 
            this.textBoxBedrooms.Location = new System.Drawing.Point(97, 220);
            this.textBoxBedrooms.Name = "textBoxBedrooms";
            this.textBoxBedrooms.Size = new System.Drawing.Size(100, 31);
            this.textBoxBedrooms.TabIndex = 9;
            // 
            // listBoxHouseType
            // 
            this.listBoxHouseType.FormattingEnabled = true;
            this.listBoxHouseType.ItemHeight = 25;
            this.listBoxHouseType.Items.AddRange(new object[] {
            "Condo",
            "Single",
            "Duplex",
            "Town Home"});
            this.listBoxHouseType.Location = new System.Drawing.Point(804, 91);
            this.listBoxHouseType.Name = "listBoxHouseType";
            this.listBoxHouseType.Size = new System.Drawing.Size(251, 129);
            this.listBoxHouseType.TabIndex = 10;
            // 
            // buttonAddListing
            // 
            this.buttonAddListing.Location = new System.Drawing.Point(596, 628);
            this.buttonAddListing.Name = "buttonAddListing";
            this.buttonAddListing.Size = new System.Drawing.Size(219, 104);
            this.buttonAddListing.TabIndex = 11;
            this.buttonAddListing.Text = "button2";
            this.buttonAddListing.UseVisualStyleBackColor = true;
            this.buttonAddListing.Click += new System.EventHandler(this.buttonAddListing_Click);
            // 
            // FormAddListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 1100);
            this.Controls.Add(this.buttonAddListing);
            this.Controls.Add(this.listBoxHouseType);
            this.Controls.Add(this.textBoxBedrooms);
            this.Controls.Add(this.textBoxBathrooms);
            this.Controls.Add(this.textBoxFloorArea);
            this.Controls.Add(this.textBoxSellerName);
            this.Controls.Add(this.textBoxListPrice);
            this.Controls.Add(this.textBoxProvince);
            this.Controls.Add(this.textBoxPincode);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxStreetAddress);
            this.Name = "FormAddListing";
            this.Text = "FormAddListing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStreetAddress;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxPincode;
        private System.Windows.Forms.TextBox textBoxProvince;
        private System.Windows.Forms.TextBox textBoxListPrice;
        private System.Windows.Forms.TextBox textBoxSellerName;
        private System.Windows.Forms.TextBox textBoxFloorArea;
        private System.Windows.Forms.TextBox textBoxBathrooms;
        private System.Windows.Forms.TextBox textBoxBedrooms;
        private System.Windows.Forms.ListBox listBoxHouseType;
        private System.Windows.Forms.Button buttonAddListing;
    }
}