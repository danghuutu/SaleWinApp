namespace SalesWinApp
{
    partial class frmOrderDetail
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
            lbOrderDetail = new Label();
            lbTotal = new Label();
            txtTotal = new TextBox();
            btnExit = new Button();
            dgvOrderDetail = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // lbOrderDetail
            // 
            lbOrderDetail.AutoSize = true;
            lbOrderDetail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbOrderDetail.Location = new Point(241, 32);
            lbOrderDetail.Name = "lbOrderDetail";
            lbOrderDetail.Size = new Size(145, 31);
            lbOrderDetail.TabIndex = 0;
            lbOrderDetail.Text = "Order Detail";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.Location = new Point(43, 104);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(61, 25);
            lbTotal.TabIndex = 1;
            lbTotal.Text = "Total: ";
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Enabled = false;
            txtTotal.ForeColor = SystemColors.WindowText;
            txtTotal.Location = new Point(110, 106);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(302, 27);
            txtTotal.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(588, 104);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(139, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(43, 186);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.ReadOnly = true;
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.RowTemplate.Height = 29;
            dgvOrderDetail.Size = new Size(718, 225);
            dgvOrderDetail.TabIndex = 4;
            // 
            // frmOrderDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvOrderDetail);
            Controls.Add(btnExit);
            Controls.Add(txtTotal);
            Controls.Add(lbTotal);
            Controls.Add(lbOrderDetail);
            Name = "frmOrderDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderDetail";
            Load += frmOrderDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbOrderDetail;
        private Label lbTotal;
        private TextBox txtTotal;
        private Button btnExit;
        private DataGridView dgvOrderDetail;
    }
}