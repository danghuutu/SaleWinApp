namespace SalesWinApp
{
    partial class frmUpdateMember
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
            lbUpdateMember = new Label();
            lbMemberId = new Label();
            lbEmail = new Label();
            lbCompany = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            lbPassword = new Label();
            txtMemberId = new TextBox();
            txtEmail = new TextBox();
            txtCompany = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtPassword = new TextBox();
            btnUpdate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lbUpdateMember
            // 
            lbUpdateMember.AutoSize = true;
            lbUpdateMember.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbUpdateMember.Location = new Point(254, 35);
            lbUpdateMember.Name = "lbUpdateMember";
            lbUpdateMember.Size = new Size(188, 31);
            lbUpdateMember.TabIndex = 0;
            lbUpdateMember.Text = "Update Member";
            // 
            // lbMemberId
            // 
            lbMemberId.AutoSize = true;
            lbMemberId.Location = new Point(41, 95);
            lbMemberId.Name = "lbMemberId";
            lbMemberId.Size = new Size(80, 20);
            lbMemberId.TabIndex = 1;
            lbMemberId.Text = "MemberID";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(41, 160);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbCompany
            // 
            lbCompany.AutoSize = true;
            lbCompany.Location = new Point(41, 223);
            lbCompany.Name = "lbCompany";
            lbCompany.Size = new Size(72, 20);
            lbCompany.TabIndex = 3;
            lbCompany.Text = "Company";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(443, 95);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(442, 160);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(442, 223);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 6;
            lbPassword.Text = "Password";
            // 
            // txtMemberId
            // 
            txtMemberId.BorderStyle = BorderStyle.FixedSingle;
            txtMemberId.Location = new Point(146, 88);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(251, 27);
            txtMemberId.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(146, 153);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtCompany
            // 
            txtCompany.BorderStyle = BorderStyle.FixedSingle;
            txtCompany.Location = new Point(146, 216);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(251, 27);
            txtCompany.TabIndex = 9;
            // 
            // txtCity
            // 
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Location = new Point(522, 92);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(227, 27);
            txtCity.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.BorderStyle = BorderStyle.FixedSingle;
            txtCountry.Location = new Point(522, 157);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(227, 27);
            txtCountry.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(522, 216);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(227, 27);
            txtPassword.TabIndex = 12;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(183, 309);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 36);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(562, 309);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(113, 36);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompany);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberId);
            Controls.Add(lbPassword);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbCompany);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberId);
            Controls.Add(lbUpdateMember);
            Name = "frmUpdateMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateMember";
            Load += frmUpdateMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUpdateMember;
        private Label lbMemberId;
        private Label lbEmail;
        private Label lbCompany;
        private Label lbCity;
        private Label lbCountry;
        private Label lbPassword;
        private TextBox txtMemberId;
        private TextBox txtEmail;
        private TextBox txtCompany;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPassword;
        private Button btnUpdate;
        private Button btnExit;
    }
}