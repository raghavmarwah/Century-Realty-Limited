﻿namespace CenturyRealityLimitedApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(903, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 96);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1197, 588);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 96);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(64, 591);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 93);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(67, 754);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(221, 108);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1977, 1199);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewActiveListings);
            this.Controls.Add(this.buttonAddNewListing);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveListings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddNewListing;
        private System.Windows.Forms.DataGridView dataGridViewActiveListings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}