namespace SalesWinApp
{
    partial class frmOrder
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
            lbOrder = new Label();
            btnViewDetail = new Button();
            btnExit = new Button();
            dgvOrder = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // lbOrder
            // 
            lbOrder.AutoSize = true;
            lbOrder.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbOrder.Location = new Point(294, 20);
            lbOrder.Name = "lbOrder";
            lbOrder.Size = new Size(75, 31);
            lbOrder.TabIndex = 0;
            lbOrder.Text = "Order";
            // 
            // btnViewDetail
            // 
            btnViewDetail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewDetail.Location = new Point(95, 95);
            btnViewDetail.Name = "btnViewDetail";
            btnViewDetail.Size = new Size(136, 41);
            btnViewDetail.TabIndex = 1;
            btnViewDetail.Text = "View Detail";
            btnViewDetail.UseVisualStyleBackColor = true;
            btnViewDetail.Click += btnViewDetail_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(467, 95);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 41);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(12, 162);
            dgvOrder.MultiSelect = false;
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.Size = new Size(671, 222);
            dgvOrder.TabIndex = 3;
            dgvOrder.CellClick += dgvOrder_CellClick;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(695, 450);
            Controls.Add(dgvOrder);
            Controls.Add(btnExit);
            Controls.Add(btnViewDetail);
            Controls.Add(lbOrder);
            Name = "frmOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            Load += frmOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbOrder;
        private Button btnViewDetail;
        private Button btnExit;
        private DataGridView dgvOrder;
    }
}