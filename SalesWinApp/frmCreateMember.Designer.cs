namespace SalesWinApp
{
    partial class frmCreateMember
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
            lbCreateMember = new Label();
            lbEmail = new Label();
            lbPassword = new Label();
            lbCompany = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtCompany = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            btnCreate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lbCreateMember
            // 
            lbCreateMember.AutoSize = true;
            lbCreateMember.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbCreateMember.Location = new Point(251, 29);
            lbCreateMember.Name = "lbCreateMember";
            lbCreateMember.Size = new Size(178, 31);
            lbCreateMember.TabIndex = 0;
            lbCreateMember.Text = "Create Member";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(56, 93);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(56, 167);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // lbCompany
            // 
            lbCompany.AutoSize = true;
            lbCompany.Location = new Point(56, 238);
            lbCompany.Name = "lbCompany";
            lbCompany.Size = new Size(72, 20);
            lbCompany.TabIndex = 3;
            lbCompany.Text = "Company";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(383, 93);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(383, 167);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(140, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(140, 160);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(211, 27);
            txtPassword.TabIndex = 7;
            // 
            // txtCompany
            // 
            txtCompany.BorderStyle = BorderStyle.FixedSingle;
            txtCompany.Location = new Point(140, 231);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(211, 27);
            txtCompany.TabIndex = 8;
            // 
            // txtCity
            // 
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Location = new Point(464, 86);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(197, 27);
            txtCity.TabIndex = 9;
            // 
            // txtCountry
            // 
            txtCountry.BorderStyle = BorderStyle.FixedSingle;
            txtCountry.Location = new Point(464, 160);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(197, 27);
            txtCountry.TabIndex = 10;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.Location = new Point(140, 301);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(116, 36);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(545, 301);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(116, 36);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmCreateMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 414);
            Controls.Add(btnExit);
            Controls.Add(btnCreate);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompany);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbCompany);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbCreateMember);
            Name = "frmCreateMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateMember";
            Load += frmCreateMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCreateMember;
        private Label lbEmail;
        private Label lbPassword;
        private Label lbCompany;
        private Label lbCity;
        private Label lbCountry;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtCompany;
        private TextBox txtCity;
        private TextBox txtCountry;
        private Button btnCreate;
        private Button btnExit;
    }
}