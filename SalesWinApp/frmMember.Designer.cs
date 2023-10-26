namespace SalesWinApp
{
    partial class frmMember
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
            lbMemberId = new Label();
            lbEmail = new Label();
            lbCompany = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            lbMemberManagement = new Label();
            txtMemberId = new TextBox();
            txtEmail = new TextBox();
            txtCompany = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnViewOrder = new Button();
            btnOrder = new Button();
            btnProduct = new Button();
            btnExit = new Button();
            dgvMember = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // lbMemberId
            // 
            lbMemberId.AutoSize = true;
            lbMemberId.Location = new Point(54, 78);
            lbMemberId.Name = "lbMemberId";
            lbMemberId.Size = new Size(80, 20);
            lbMemberId.TabIndex = 0;
            lbMemberId.Text = "MemberID";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(54, 129);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbCompany
            // 
            lbCompany.AutoSize = true;
            lbCompany.Location = new Point(54, 183);
            lbCompany.Name = "lbCompany";
            lbCompany.Size = new Size(72, 20);
            lbCompany.TabIndex = 2;
            lbCompany.Text = "Company";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(457, 78);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 3;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(457, 129);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 4;
            lbCountry.Text = "Country";
            // 
            // lbMemberManagement
            // 
            lbMemberManagement.AutoSize = true;
            lbMemberManagement.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbMemberManagement.Location = new Point(265, 18);
            lbMemberManagement.Name = "lbMemberManagement";
            lbMemberManagement.Size = new Size(252, 31);
            lbMemberManagement.TabIndex = 5;
            lbMemberManagement.Text = "Member Management";
            // 
            // txtMemberId
            // 
            txtMemberId.BorderStyle = BorderStyle.FixedSingle;
            txtMemberId.Location = new Point(156, 71);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(252, 27);
            txtMemberId.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(156, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtCompany
            // 
            txtCompany.BorderStyle = BorderStyle.FixedSingle;
            txtCompany.Location = new Point(156, 176);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(252, 27);
            txtCompany.TabIndex = 8;
            // 
            // txtCity
            // 
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Location = new Point(544, 71);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(303, 27);
            txtCity.TabIndex = 9;
            // 
            // txtCountry
            // 
            txtCountry.BorderStyle = BorderStyle.FixedSingle;
            txtCountry.Location = new Point(544, 122);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(303, 27);
            txtCountry.TabIndex = 10;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.Location = new Point(54, 229);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 33);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(187, 229);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 33);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(314, 229);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 33);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnViewOrder
            // 
            btnViewOrder.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewOrder.Location = new Point(457, 229);
            btnViewOrder.Name = "btnViewOrder";
            btnViewOrder.Size = new Size(128, 33);
            btnViewOrder.TabIndex = 14;
            btnViewOrder.Text = "View Order";
            btnViewOrder.UseVisualStyleBackColor = true;
            btnViewOrder.Click += btnViewOrder_Click;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrder.Location = new Point(622, 229);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 33);
            btnOrder.TabIndex = 15;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnProduct
            // 
            btnProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnProduct.Location = new Point(753, 229);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(94, 33);
            btnProduct.TabIndex = 16;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(387, 537);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 34);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvMember
            // 
            dgvMember.AllowUserToAddRows = false;
            dgvMember.AllowUserToDeleteRows = false;
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(54, 282);
            dgvMember.MultiSelect = false;
            dgvMember.Name = "dgvMember";
            dgvMember.ReadOnly = true;
            dgvMember.RowHeadersWidth = 51;
            dgvMember.RowTemplate.Height = 29;
            dgvMember.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMember.Size = new Size(793, 237);
            dgvMember.TabIndex = 18;
            dgvMember.CellClick += dgvMember_CellClick;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 583);
            Controls.Add(dgvMember);
            Controls.Add(btnExit);
            Controls.Add(btnProduct);
            Controls.Add(btnOrder);
            Controls.Add(btnViewOrder);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompany);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberId);
            Controls.Add(lbMemberManagement);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbCompany);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberId);
            Name = "frmMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Management";
            Load += frmMember_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberId;
        private Label lbEmail;
        private Label lbCompany;
        private Label lbCity;
        private Label lbCountry;
        private Label lbMemberManagement;
        private TextBox txtMemberId;
        private TextBox txtEmail;
        private TextBox txtCompany;
        private TextBox txtCity;
        private TextBox txtCountry;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnViewOrder;
        private Button btnOrder;
        private Button btnProduct;
        private Button btnExit;
        private DataGridView dgvMember;
    }
}