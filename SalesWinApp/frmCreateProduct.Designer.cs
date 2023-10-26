namespace SalesWinApp
{
    partial class frmCreateProduct
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
            btnExit = new Button();
            btnCreate = new Button();
            lbCreateProduct = new Label();
            txtUnitsInStock = new TextBox();
            txtUnitPrice = new TextBox();
            txtWeight = new TextBox();
            txtCategory = new TextBox();
            txtProductName = new TextBox();
            lbUnitsInStock = new Label();
            lbUnitPrice = new Label();
            lbWeight = new Label();
            lbCategoryId = new Label();
            lbProductName = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(724, 321);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(142, 45);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.Location = new Point(206, 321);
            btnCreate.Margin = new Padding(4, 3, 4, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(142, 45);
            btnCreate.TabIndex = 18;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lbCreateProduct
            // 
            lbCreateProduct.AutoSize = true;
            lbCreateProduct.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbCreateProduct.Location = new Point(386, 24);
            lbCreateProduct.Margin = new Padding(4, 0, 4, 0);
            lbCreateProduct.Name = "lbCreateProduct";
            lbCreateProduct.Size = new Size(178, 32);
            lbCreateProduct.TabIndex = 16;
            lbCreateProduct.Text = "Create Product";
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.BorderStyle = BorderStyle.FixedSingle;
            txtUnitsInStock.Location = new Point(635, 169);
            txtUnitsInStock.Margin = new Padding(4, 3, 4, 3);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(287, 30);
            txtUnitsInStock.TabIndex = 10;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            txtUnitPrice.Location = new Point(635, 104);
            txtUnitPrice.Margin = new Padding(4, 3, 4, 3);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(287, 30);
            txtUnitPrice.TabIndex = 11;
            // 
            // txtWeight
            // 
            txtWeight.BorderStyle = BorderStyle.FixedSingle;
            txtWeight.Location = new Point(180, 231);
            txtWeight.Margin = new Padding(4, 3, 4, 3);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(287, 30);
            txtWeight.TabIndex = 12;
            // 
            // txtCategory
            // 
            txtCategory.BorderStyle = BorderStyle.FixedSingle;
            txtCategory.Location = new Point(180, 169);
            txtCategory.Margin = new Padding(4, 3, 4, 3);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(287, 30);
            txtCategory.TabIndex = 13;
            // 
            // txtProductName
            // 
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Location = new Point(180, 104);
            txtProductName.Margin = new Padding(4, 3, 4, 3);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(287, 30);
            txtProductName.TabIndex = 14;
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbUnitsInStock.Location = new Point(498, 177);
            lbUnitsInStock.Margin = new Padding(4, 0, 4, 0);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new Size(110, 19);
            lbUnitsInStock.TabIndex = 4;
            lbUnitsInStock.Text = "Units In Stock";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbUnitPrice.Location = new Point(498, 112);
            lbUnitPrice.Margin = new Padding(4, 0, 4, 0);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(81, 19);
            lbUnitPrice.TabIndex = 5;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbWeight.Location = new Point(42, 239);
            lbWeight.Margin = new Padding(4, 0, 4, 0);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(61, 19);
            lbWeight.TabIndex = 6;
            lbWeight.Text = "Weight";
            // 
            // lbCategoryId
            // 
            lbCategoryId.AutoSize = true;
            lbCategoryId.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbCategoryId.Location = new Point(42, 177);
            lbCategoryId.Margin = new Padding(4, 0, 4, 0);
            lbCategoryId.Name = "lbCategoryId";
            lbCategoryId.Size = new Size(98, 19);
            lbCategoryId.TabIndex = 7;
            lbCategoryId.Text = "Category ID";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbProductName.Location = new Point(42, 107);
            lbProductName.Margin = new Padding(4, 0, 4, 0);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(113, 19);
            lbProductName.TabIndex = 8;
            lbProductName.Text = "Product Name";
            // 
            // frmCreateProduct
            // 
            AcceptButton = btnCreate;
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(1000, 443);
            Controls.Add(btnExit);
            Controls.Add(btnCreate);
            Controls.Add(lbCreateProduct);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtWeight);
            Controls.Add(txtCategory);
            Controls.Add(txtProductName);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Controls.Add(lbCategoryId);
            Controls.Add(lbProductName);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmCreateProduct";
            Text = "CreateProduct";
            Load += frmCreateProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnCreate;
        private Label lbCreateProduct;
        private TextBox txtUnitsInStock;
        private TextBox txtUnitPrice;
        private TextBox txtWeight;
        private TextBox txtCategory;
        private TextBox txtProductName;
        private Label lbUnitsInStock;
        private Label lbUnitPrice;
        private Label lbWeight;
        private Label lbCategoryId;
        private Label lbProductName;
    }
}