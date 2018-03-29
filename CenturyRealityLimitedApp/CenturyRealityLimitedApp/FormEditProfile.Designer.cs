namespace CenturyRealityLimitedApp
{
    partial class FormEditProfile
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
            this.labelRealtorUsername = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.buttonUpdatePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRealtorUsername
            // 
            this.labelRealtorUsername.AutoSize = true;
            this.labelRealtorUsername.Location = new System.Drawing.Point(306, 93);
            this.labelRealtorUsername.Name = "labelRealtorUsername";
            this.labelRealtorUsername.Size = new System.Drawing.Size(70, 25);
            this.labelRealtorUsername.TabIndex = 2;
            this.labelRealtorUsername.Text = "label3";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(318, 160);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '•';
            this.textBoxNewPassword.Size = new System.Drawing.Size(302, 31);
            this.textBoxNewPassword.TabIndex = 3;
            // 
            // buttonUpdatePassword
            // 
            this.buttonUpdatePassword.Location = new System.Drawing.Point(345, 273);
            this.buttonUpdatePassword.Name = "buttonUpdatePassword";
            this.buttonUpdatePassword.Size = new System.Drawing.Size(225, 94);
            this.buttonUpdatePassword.TabIndex = 4;
            this.buttonUpdatePassword.Text = "Update";
            this.buttonUpdatePassword.UseVisualStyleBackColor = true;
            this.buttonUpdatePassword.Click += new System.EventHandler(this.buttonUpdatePassword_Click);
            // 
            // FormEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 866);
            this.Controls.Add(this.buttonUpdatePassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.labelRealtorUsername);
            this.Name = "FormEditProfile";
            this.Text = "FormEditProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRealtorUsername;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button buttonUpdatePassword;
    }
}