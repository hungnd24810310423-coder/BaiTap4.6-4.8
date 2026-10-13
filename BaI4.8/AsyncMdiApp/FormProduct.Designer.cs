namespace AsyncMdiApp
{
    partial class FormProduct
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlTop = new Panel();
            btnLoad = new Button();
            chkSimulateError = new CheckBox();
            progressBar = new ProgressBar();
            lblPercent = new Label();
            dgvProducts = new DataGridView();
            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(btnLoad);
            pnlTop.Controls.Add(chkSimulateError);
            pnlTop.Controls.Add(progressBar);
            pnlTop.Controls.Add(lblPercent);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(700, 55);
            pnlTop.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(130, 32);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Nạp dữ liệu";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // chkSimulateError
            // 
            chkSimulateError.AutoSize = true;
            chkSimulateError.Location = new Point(155, 18);
            chkSimulateError.Name = "chkSimulateError";
            chkSimulateError.Size = new Size(92, 19);
            chkSimulateError.TabIndex = 1;
            chkSimulateError.Text = "Giả lập lỗi";
            chkSimulateError.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(265, 17);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(375, 22);
            progressBar.TabIndex = 2;
            // 
            // lblPercent
            // 
            lblPercent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(650, 21);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(23, 15);
            lblPercent.TabIndex = 3;
            lblPercent.Text = "0%";
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = SystemColors.Window;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colProductId, colProductName, colCategory, colUnitPrice, colQuantity });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 55);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(700, 345);
            dgvProducts.TabIndex = 0;
            // 
            // colProductId
            // 
            colProductId.DataPropertyName = "ProductId";
            colProductId.FillWeight = 16F;
            colProductId.HeaderText = "Mã SP";
            colProductId.MinimumWidth = 60;
            colProductId.Name = "colProductId";
            colProductId.ReadOnly = true;
            // 
            // colProductName
            // 
            colProductName.DataPropertyName = "ProductName";
            colProductName.FillWeight = 34F;
            colProductName.HeaderText = "Tên SP";
            colProductName.MinimumWidth = 60;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "Category";
            colCategory.FillWeight = 20F;
            colCategory.HeaderText = "Danh mục";
            colCategory.MinimumWidth = 60;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            colUnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            colUnitPrice.DefaultCellStyle = dataGridViewCellStyle1;
            colUnitPrice.FillWeight = 20F;
            colUnitPrice.HeaderText = "Đơn giá";
            colUnitPrice.MinimumWidth = 60;
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.FillWeight = 14F;
            colQuantity.HeaderText = "Số lượng";
            colQuantity.MinimumWidth = 60;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 400);
            Controls.Add(dgvProducts);
            Controls.Add(pnlTop);
            MinimumSize = new Size(500, 300);
            Name = "FormProduct";
            Text = "Quản lý Sản phẩm";
            FormClosing += FormProduct_FormClosing;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Button btnLoad;
        private CheckBox chkSimulateError;
        private ProgressBar progressBar;
        private Label lblPercent;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colQuantity;
    }
}
