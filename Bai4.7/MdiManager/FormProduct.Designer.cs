namespace MdiManager
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlLeft = new Panel();
            pnlButtons = new Panel();
            tlpButtons = new TableLayoutPanel();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnExportCsv = new Button();
            grpInfo = new GroupBox();
            lblProductId = new Label();
            lblProductName = new Label();
            lblCategory = new Label();
            lblUnitPrice = new Label();
            lblQuantity = new Label();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            cboCategory = new ComboBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            picImage = new PictureBox();
            btnChooseImage = new Button();
            pnlRight = new Panel();
            dgvProducts = new DataGridView();
            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            ctxGrid = new ContextMenuStrip(components);
            mnuViewDetail = new ToolStripMenuItem();
            mnuDeleteRow = new ToolStripMenuItem();
            ctxSep = new ToolStripSeparator();
            mnuRefresh = new ToolStripMenuItem();
            errorProvider = new ErrorProvider(components);
            pnlLeft.SuspendLayout();
            pnlButtons.SuspendLayout();
            tlpButtons.SuspendLayout();
            grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ctxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(pnlButtons);
            pnlLeft.Controls.Add(grpInfo);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(10);
            pnlLeft.Size = new Size(360, 540);
            pnlLeft.TabIndex = 0;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(tlpButtons);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.Location = new Point(10, 390);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(340, 140);
            pnlButtons.TabIndex = 1;
            // 
            // tlpButtons
            // 
            tlpButtons.ColumnCount = 2;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpButtons.Controls.Add(btnAdd, 0, 0);
            tlpButtons.Controls.Add(btnDelete, 1, 0);
            tlpButtons.Controls.Add(btnUpdate, 0, 1);
            tlpButtons.Controls.Add(btnExportCsv, 1, 1);
            tlpButtons.Dock = DockStyle.Top;
            tlpButtons.Location = new Point(0, 0);
            tlpButtons.Name = "tlpButtons";
            tlpButtons.RowCount = 2;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpButtons.Size = new Size(340, 90);
            tlpButtons.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(164, 39);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(173, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(164, 39);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Dock = DockStyle.Fill;
            btnUpdate.Location = new Point(3, 48);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(164, 39);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Dock = DockStyle.Fill;
            btnExportCsv.Location = new Point(173, 48);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(164, 39);
            btnExportCsv.TabIndex = 3;
            btnExportCsv.Text = "Xuất file CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(lblProductId);
            grpInfo.Controls.Add(lblProductName);
            grpInfo.Controls.Add(lblCategory);
            grpInfo.Controls.Add(lblUnitPrice);
            grpInfo.Controls.Add(lblQuantity);
            grpInfo.Controls.Add(txtProductId);
            grpInfo.Controls.Add(txtProductName);
            grpInfo.Controls.Add(cboCategory);
            grpInfo.Controls.Add(txtUnitPrice);
            grpInfo.Controls.Add(txtQuantity);
            grpInfo.Controls.Add(picImage);
            grpInfo.Controls.Add(btnChooseImage);
            grpInfo.Dock = DockStyle.Top;
            grpInfo.Location = new Point(10, 10);
            grpInfo.Name = "grpInfo";
            grpInfo.Padding = new Padding(10);
            grpInfo.Size = new Size(340, 380);
            grpInfo.TabIndex = 0;
            grpInfo.TabStop = false;
            grpInfo.Text = "Thông tin sản phẩm";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(15, 33);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(41, 15);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Mã SP";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(15, 68);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(42, 15);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Tên SP";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(15, 103);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(56, 15);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Danh mục";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(15, 138);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(43, 15);
            lblUnitPrice.TabIndex = 6;
            lblUnitPrice.Text = "Đơn giá";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(15, 173);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(54, 15);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Số lượng";
            // 
            // txtProductId
            // 
            txtProductId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProductId.Location = new Point(90, 30);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(235, 23);
            txtProductId.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProductName.Location = new Point(90, 65);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(235, 23);
            txtProductName.TabIndex = 3;
            // 
            // cboCategory
            // 
            cboCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Điện thoại", "Laptop", "Phụ kiện" });
            cboCategory.Location = new Point(90, 100);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(235, 23);
            cboCategory.TabIndex = 5;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUnitPrice.Location = new Point(90, 135);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(235, 23);
            txtUnitPrice.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQuantity.Location = new Point(90, 170);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(235, 23);
            txtQuantity.TabIndex = 9;
            // 
            // picImage
            // 
            picImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picImage.BorderStyle = BorderStyle.FixedSingle;
            picImage.Location = new Point(15, 207);
            picImage.Name = "picImage";
            picImage.Size = new Size(310, 125);
            picImage.SizeMode = PictureBoxSizeMode.Zoom;
            picImage.TabIndex = 10;
            picImage.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnChooseImage.Location = new Point(15, 338);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(310, 30);
            btnChooseImage.TabIndex = 11;
            btnChooseImage.Text = "Chọn ảnh...";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(dgvProducts);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(360, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(0, 10, 10, 10);
            pnlRight.Size = new Size(540, 540);
            pnlRight.TabIndex = 1;
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
            dgvProducts.ContextMenuStrip = ctxGrid;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 10);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(530, 520);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellMouseDown += dgvProducts_CellMouseDown;
            // 
            // colProductId
            // 
            colProductId.DataPropertyName = "ProductId";
            colProductId.FillWeight = 14F;
            colProductId.HeaderText = "Mã SP";
            colProductId.MinimumWidth = 70;
            colProductId.Name = "colProductId";
            colProductId.ReadOnly = true;
            // 
            // colProductName
            // 
            colProductName.DataPropertyName = "ProductName";
            colProductName.FillWeight = 34F;
            colProductName.HeaderText = "Tên SP";
            colProductName.MinimumWidth = 120;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "Category";
            colCategory.FillWeight = 20F;
            colCategory.HeaderText = "Danh mục";
            colCategory.MinimumWidth = 80;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            colUnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            colUnitPrice.DefaultCellStyle = dataGridViewCellStyle1;
            colUnitPrice.FillWeight = 22F;
            colUnitPrice.HeaderText = "Đơn giá";
            colUnitPrice.MinimumWidth = 90;
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.FillWeight = 12F;
            colQuantity.HeaderText = "Số lượng";
            colQuantity.MinimumWidth = 70;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // ctxGrid
            // 
            ctxGrid.Items.AddRange(new ToolStripItem[] { mnuViewDetail, mnuDeleteRow, ctxSep, mnuRefresh });
            ctxGrid.Name = "ctxGrid";
            ctxGrid.Size = new Size(160, 76);
            // 
            // mnuViewDetail
            // 
            mnuViewDetail.Name = "mnuViewDetail";
            mnuViewDetail.Size = new Size(159, 22);
            mnuViewDetail.Text = "Xem chi tiết";
            mnuViewDetail.Click += mnuViewDetail_Click;
            // 
            // mnuDeleteRow
            // 
            mnuDeleteRow.Name = "mnuDeleteRow";
            mnuDeleteRow.Size = new Size(159, 22);
            mnuDeleteRow.Text = "Xóa dòng";
            mnuDeleteRow.Click += mnuDeleteRow_Click;
            // 
            // ctxSep
            // 
            ctxSep.Name = "ctxSep";
            ctxSep.Size = new Size(156, 6);
            // 
            // mnuRefresh
            // 
            mnuRefresh.Name = "mnuRefresh";
            mnuRefresh.Size = new Size(159, 22);
            mnuRefresh.Text = "Làm mới dữ liệu";
            mnuRefresh.Click += mnuRefresh_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 540);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            MinimumSize = new Size(760, 580);
            Name = "FormProduct";
            Text = "Quản lý Sản phẩm";
            FormClosed += FormProduct_FormClosed;
            Load += FormProduct_Load;
            pnlLeft.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            tlpButtons.ResumeLayout(false);
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ctxGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private Panel pnlButtons;
        private TableLayoutPanel tlpButtons;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnExportCsv;
        private GroupBox grpInfo;
        private Label lblProductId;
        private Label lblProductName;
        private Label lblCategory;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private TextBox txtProductId;
        private TextBox txtProductName;
        private ComboBox cboCategory;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private PictureBox picImage;
        private Button btnChooseImage;
        private Panel pnlRight;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colQuantity;
        private ContextMenuStrip ctxGrid;
        private ToolStripMenuItem mnuViewDetail;
        private ToolStripMenuItem mnuDeleteRow;
        private ToolStripSeparator ctxSep;
        private ToolStripMenuItem mnuRefresh;
        private ErrorProvider errorProvider;
    }
}
