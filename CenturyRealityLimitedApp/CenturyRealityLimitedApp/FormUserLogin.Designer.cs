namespace CenturyRealityLimitedApp
{
    partial class FormUserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxMainLogo = new System.Windows.Forms.PictureBox();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.textBoxRealtorId = new System.Windows.Forms.TextBox();
            this.textBoxRealtorPassword = new System.Windows.Forms.TextBox();
            this.labelRealtorLoginInfo = new System.Windows.Forms.Label();
            this.labelRealtorId = new System.Windows.Forms.Label();
            this.labelRealtorPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pictureBoxMainLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 1076);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxMainLogo
            // 
            this.pictureBoxMainLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMainLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainLogo.Image")));
            this.pictureBoxMainLogo.Location = new System.Drawing.Point(3, 0);
            this.pictureBoxMainLogo.Name = "pictureBoxMainLogo";
            this.pictureBoxMainLogo.Size = new System.Drawing.Size(627, 1076);
            this.pictureBoxMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMainLogo.TabIndex = 0;
            this.pictureBoxMainLogo.TabStop = false;
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseForm.Font = new System.Drawing.Font("Eras Bold ITC", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseForm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCloseForm.Location = new System.Drawing.Point(1627, 0);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(75, 68);
            this.buttonCloseForm.TabIndex = 1;
            this.buttonCloseForm.Text = "X";
            this.buttonCloseForm.UseVisualStyleBackColor = false;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // textBoxRealtorId
            // 
            this.textBoxRealtorId.AcceptsTab = true;
            this.textBoxRealtorId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRealtorId.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRealtorId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxRealtorId.Location = new System.Drawing.Point(988, 478);
            this.textBoxRealtorId.Name = "textBoxRealtorId";
            this.textBoxRealtorId.Size = new System.Drawing.Size(486, 58);
            this.textBoxRealtorId.TabIndex = 2;
            // 
            // textBoxRealtorPassword
            // 
            this.textBoxRealtorPassword.AcceptsTab = true;
            this.textBoxRealtorPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRealtorPassword.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRealtorPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxRealtorPassword.Location = new System.Drawing.Point(988, 576);
            this.textBoxRealtorPassword.Name = "textBoxRealtorPassword";
            this.textBoxRealtorPassword.PasswordChar = '•';
            this.textBoxRealtorPassword.Size = new System.Drawing.Size(486, 58);
            this.textBoxRealtorPassword.TabIndex = 3;
            // 
            // labelRealtorLoginInfo
            // 
            this.labelRealtorLoginInfo.AutoSize = true;
            this.labelRealtorLoginInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRealtorLoginInfo.Font = new System.Drawing.Font("Segoe UI", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRealtorLoginInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelRealtorLoginInfo.Location = new System.Drawing.Point(752, 352);
            this.labelRealtorLoginInfo.Name = "labelRealtorLoginInfo";
            this.labelRealtorLoginInfo.Size = new System.Drawing.Size(363, 71);
            this.labelRealtorLoginInfo.TabIndex = 4;
            this.labelRealtorLoginInfo.Text = "Realtor Login";
            // 
            // labelRealtorId
            // 
            this.labelRealtorId.AutoSize = true;
            this.labelRealtorId.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRealtorId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelRealtorId.Location = new System.Drawing.Point(754, 478);
            this.labelRealtorId.Name = "labelRealtorId";
            this.labelRealtorId.Size = new System.Drawing.Size(228, 59);
            this.labelRealtorId.TabIndex = 5;
            this.labelRealtorId.Text = "Realtor Id: ";
            // 
            // labelRealtorPassword
            // 
            this.labelRealtorPassword.AutoSize = true;
            this.labelRealtorPassword.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRealtorPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelRealtorPassword.Location = new System.Drawing.Point(754, 576);
            this.labelRealtorPassword.Name = "labelRealtorPassword";
            this.labelRealtorPassword.Size = new System.Drawing.Size(211, 59);
            this.labelRealtorPassword.TabIndex = 6;
            this.labelRealtorPassword.Text = "Password:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(146)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonLogin.Location = new System.Drawing.Point(918, 720);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(181, 66);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "LogIn";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(146)))));
            this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonSignUp.Location = new System.Drawing.Point(1182, 720);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(181, 66);
            this.buttonSignUp.TabIndex = 7;
            this.buttonSignUp.Text = "SignUp";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            // 
            // FormUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1700, 1075);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelRealtorPassword);
            this.Controls.Add(this.labelRealtorId);
            this.Controls.Add(this.labelRealtorLoginInfo);
            this.Controls.Add(this.textBoxRealtorPassword);
            this.Controls.Add(this.textBoxRealtorId);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormUserLogin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxMainLogo;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.TextBox textBoxRealtorId;
        private System.Windows.Forms.TextBox textBoxRealtorPassword;
        private System.Windows.Forms.Label labelRealtorLoginInfo;
        private System.Windows.Forms.Label labelRealtorId;
        private System.Windows.Forms.Label labelRealtorPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonSignUp;
    }
}

