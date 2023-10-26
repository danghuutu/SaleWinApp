namespace SalesWinApp
{
    partial class frmProduct
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
            lbProduct = new Label();
            grSearch = new GroupBox();
            txtSearch = new TextBox();
            rdById = new RadioButton();
            rdByName = new RadioButton();
            btnSearch = new Button();
            btnCreate = new Button();
            btnLoad = new Button();
            btnUpdate = new Button();
            btnExit = new Button();
            dgvProduct = new DataGridView();
            grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // lbProduct
            // 
            lbProduct.AutoSize = true;
            lbProduct.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbProduct.Location = new Point(286, 21);
            lbProduct.Name = "lbProduct";
            lbProduct.Size = new Size(99, 31);
            lbProduct.TabIndex = 0;
            lbProduct.Text = "Product";
            // 
            // grSearch
            // 
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(rdByName);
            grSearch.Controls.Add(rdById);
            grSearch.Controls.Add(txtSearch);
            grSearch.Location = new Point(58, 72);
            grSearch.Name = "grSearch";
            grSearch.Size = new Size(327, 141);
            grSearch.TabIndex = 1;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(19, 46);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(144, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // rdById
            // 
            rdById.AutoSize = true;
            rdById.Location = new Point(213, 34);
            rdById.Name = "rdById";
            rdById.Size = new Size(65, 24);
            rdById.TabIndex = 1;
            rdById.TabStop = true;
            rdById.Text = "By ID";
            rdById.UseVisualStyleBackColor = true;
            rdById.CheckedChanged += rdById_CheckedChanged;
            // 
            // rdByName
            // 
            rdByName.AutoSize = true;
            rdByName.Location = new Point(215, 85);
            rdByName.Name = "rdByName";
            rdByName.Size = new Size(90, 24);
            rdByName.TabIndex = 2;
            rdByName.TabStop = true;
            rdByName.Text = "By Name";
            rdByName.UseVisualStyleBackColor = true;
            rdByName.CheckedChanged += rdByName_CheckedChanged;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(87, 96);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.Location = new Point(467, 88);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 35);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(662, 88);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 35);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(467, 159);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 35);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(662, 162);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 35);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(58, 238);
            dgvProduct.MultiSelect = false;
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(698, 206);
            dgvProduct.TabIndex = 6;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 471);
            Controls.Add(dgvProduct);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(btnLoad);
            Controls.Add(btnCreate);
            Controls.Add(grSearch);
            Controls.Add(lbProduct);
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            Load += frmProduct_Load;
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProduct;
        private GroupBox grSearch;
        private Button btnSearch;
        private RadioButton rdByName;
        private RadioButton rdById;
        private TextBox txtSearch;
        private Button btnCreate;
        private Button btnLoad;
        private Button btnUpdate;
        private Button btnExit;
        private DataGridView dgvProduct;
    }
}