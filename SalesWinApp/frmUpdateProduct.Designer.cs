namespace SalesWinApp
{
    partial class frmUpdateProduct
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
            lbProductId = new Label();
            lbProductName = new Label();
            lbCategoryId = new Label();
            lbWeight = new Label();
            lbUnitPrice = new Label();
            lbUnitsInStock = new Label();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            txtCategory = new TextBox();
            txtWeight = new TextBox();
            txtUnitPrice = new TextBox();
            txtUnitsInStock = new TextBox();
            lbUpdateProduct = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lbProductId
            // 
            lbProductId.AutoSize = true;
            lbProductId.Location = new Point(43, 83);
            lbProductId.Name = "lbProductId";
            lbProductId.Size = new Size(79, 20);
            lbProductId.TabIndex = 0;
            lbProductId.Text = "Product ID";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(43, 139);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(104, 20);
            lbProductName.TabIndex = 0;
            lbProductName.Text = "Product Name";
            // 
            // lbCategoryId
            // 
            lbCategoryId.AutoSize = true;
            lbCategoryId.Location = new Point(43, 203);
            lbCategoryId.Name = "lbCategoryId";
            lbCategoryId.Size = new Size(88, 20);
            lbCategoryId.TabIndex = 0;
            lbCategoryId.Text = "Category ID";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(430, 87);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(56, 20);
            lbWeight.TabIndex = 0;
            lbWeight.Text = "Weight";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(430, 143);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(72, 20);
            lbUnitPrice.TabIndex = 0;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new Point(430, 207);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new Size(98, 20);
            lbUnitsInStock.TabIndex = 0;
            lbUnitsInStock.Text = "Units In Stock";
            // 
            // txtProductId
            // 
            txtProductId.BorderStyle = BorderStyle.FixedSingle;
            txtProductId.Location = new Point(151, 80);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(251, 27);
            txtProductId.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Location = new Point(151, 136);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(251, 27);
            txtProductName.TabIndex = 1;
            // 
            // txtCategory
            // 
            txtCategory.BorderStyle = BorderStyle.FixedSingle;
            txtCategory.Location = new Point(151, 200);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(251, 27);
            txtCategory.TabIndex = 1;
            // 
            // txtWeight
            // 
            txtWeight.BorderStyle = BorderStyle.FixedSingle;
            txtWeight.Location = new Point(534, 87);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(230, 27);
            txtWeight.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            txtUnitPrice.Location = new Point(534, 143);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(230, 27);
            txtUnitPrice.TabIndex = 1;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.BorderStyle = BorderStyle.FixedSingle;
            txtUnitsInStock.Location = new Point(534, 204);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(230, 27);
            txtUnitsInStock.TabIndex = 1;
            // 
            // lbUpdateProduct
            // 
            lbUpdateProduct.AutoSize = true;
            lbUpdateProduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUpdateProduct.Location = new Point(290, 18);
            lbUpdateProduct.Name = "lbUpdateProduct";
            lbUpdateProduct.Size = new Size(155, 28);
            lbUpdateProduct.TabIndex = 2;
            lbUpdateProduct.Text = "Update Product";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(169, 271);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 37);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(568, 271);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(109, 37);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmUpdateProduct
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 370);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(lbUpdateProduct);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtWeight);
            Controls.Add(txtCategory);
            Controls.Add(txtProductName);
            Controls.Add(txtProductId);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Controls.Add(lbCategoryId);
            Controls.Add(lbProductName);
            Controls.Add(lbProductId);
            Name = "frmUpdateProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateProduct";
            Load += frmUpdateProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProductId;
        private Label lbProductName;
        private Label lbCategoryId;
        private Label lbWeight;
        private Label lbUnitPrice;
        private Label lbUnitsInStock;
        private TextBox txtProductId;
        private TextBox txtProductName;
        private TextBox txtCategory;
        private TextBox txtWeight;
        private TextBox txtUnitPrice;
        private TextBox txtUnitsInStock;
        private Label lbUpdateProduct;
        private Button btnUpdate;
        private Button btnExit;
    }
}