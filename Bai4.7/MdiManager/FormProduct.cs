namespace MdiManager;

public partial class FormProduct : BaseChildForm
{
    private readonly BindingSource _source = new();

    public FormProduct()
    {
        InitializeComponent();
    }

    private void FormProduct_Load(object? sender, EventArgs e)
    {
        _source.DataSource = AppData.Products;
        dgvProducts.DataSource = _source;

        // Binding 2 chiều
        txtProductId.DataBindings.Add("Text", _source, nameof(Product.ProductId), false, DataSourceUpdateMode.OnPropertyChanged);
        txtProductName.DataBindings.Add("Text", _source, nameof(Product.ProductName), false, DataSourceUpdateMode.OnPropertyChanged);
        cboCategory.DataBindings.Add("SelectedItem", _source, nameof(Product.Category), true, DataSourceUpdateMode.OnPropertyChanged);
        txtUnitPrice.DataBindings.Add("Text", _source, nameof(Product.UnitPrice), true, DataSourceUpdateMode.OnValidation);
        txtQuantity.DataBindings.Add("Text", _source, nameof(Product.Quantity), true, DataSourceUpdateMode.OnValidation);

        BindImage(picImage, _source, nameof(Product.ImagePath));

        _source.ListChanged += (_, _) => RefreshState();
        RefreshState();
    }

    private void FormProduct_FormClosed(object? sender, FormClosedEventArgs e)
    {
        picImage.Image?.Dispose();
        _source.Dispose();
    }

    public override void RefreshData()
    {
        _source.EndEdit();
        _source.ResetBindings(false);
        ReportStatus("Đã làm mới danh sách sản phẩm.");
    }

    // ---------- Chức năng ----------
    private void btnAdd_Click(object? sender, EventArgs e)
    {
        var product = new Product { ProductId = NextProductId(), Category = "Điện thoại" };
        AppData.Products.Add(product);
        _source.Position = _source.IndexOf(product);
        txtProductName.Focus();
        ReportStatus($"Đã thêm sản phẩm mới '{product.ProductId}'. Hãy nhập thông tin rồi bấm Cập nhật.");
    }

    private void btnUpdate_Click(object? sender, EventArgs e)
    {
        if (_source.Current is not Product current)
        {
            ShowInfo("Hãy chọn sản phẩm cần cập nhật.");
            return;
        }

        if (!ValidateInput(current)) return;

        _source.EndEdit();
        _source.ResetCurrentItem();
        ReportStatus($"Đã cập nhật sản phẩm '{current.ProductId} - {current.ProductName}'.");
    }

    private void btnDelete_Click(object? sender, EventArgs e) => DeleteCurrent();

    private void DeleteCurrent()
    {
        if (_source.Current is not Product current)
        {
            ShowInfo("Hãy chọn sản phẩm cần xóa.");
            return;
        }

        var result = MessageBox.Show(
            $"Bạn có chắc muốn xóa sản phẩm '{current.ProductName}'?",
            "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result != DialogResult.Yes) return;

        string info = $"{current.ProductId} - {current.ProductName}";
        _source.RemoveCurrent();
        errorProvider.Clear();
        ReportStatus($"Đã xóa sản phẩm '{info}'.");
    }

    private void btnChooseImage_Click(object? sender, EventArgs e)
    {
        if (_source.Current is not Product current)
        {
            ShowInfo("Hãy chọn hoặc thêm sản phẩm trước khi chọn ảnh.");
            return;
        }

        using var dialog = new OpenFileDialog
        {
            Title = "Chọn ảnh sản phẩm",
            Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        };

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            current.ImagePath = dialog.FileName;
            ReportStatus($"Đã đổi ảnh cho sản phẩm '{current.ProductId}'.");
        }
    }

    private void btnExportCsv_Click(object? sender, EventArgs e)
    {
        _source.EndEdit();

        string? path = SaveCsv("products.csv",
            "ProductId,ProductName,Category,UnitPrice,Quantity,ImagePath",
            AppData.Products.Select(p =>
                string.Join(",", Csv(p.ProductId), Csv(p.ProductName), Csv(p.Category),
                    p.UnitPrice.ToString(System.Globalization.CultureInfo.InvariantCulture), p.Quantity, Csv(p.ImagePath))));

        if (path is not null)
            ReportStatus($"Đã xuất {AppData.Products.Count} sản phẩm ra '{Path.GetFileName(path)}'.");
    }

    // ---------- ContextMenuStrip của DataGridView ----------
    private void dgvProducts_CellMouseDown(object? sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
        {
            dgvProducts.ClearSelection();
            dgvProducts.Rows[e.RowIndex].Selected = true;
            dgvProducts.CurrentCell = dgvProducts.Rows[e.RowIndex].Cells[Math.Max(0, e.ColumnIndex)];
        }
    }

    private void mnuViewDetail_Click(object? sender, EventArgs e)
    {
        if (_source.Current is not Product p)
        {
            ShowInfo("Chưa chọn sản phẩm nào.");
            return;
        }

        MessageBox.Show(
            $"Mã SP: {p.ProductId}\nTên SP: {p.ProductName}\nDanh mục: {p.Category}\n" +
            $"Đơn giá: {p.UnitPrice:N0} VND\nSố lượng: {p.Quantity}\n" +
            $"Ảnh: {(string.IsNullOrEmpty(p.ImagePath) ? "(chưa có)" : p.ImagePath)}",
            "Chi tiết sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ReportStatus($"Đã xem chi tiết sản phẩm '{p.ProductId}'.");
    }

    private void mnuDeleteRow_Click(object? sender, EventArgs e) => DeleteCurrent();

    private void mnuRefresh_Click(object? sender, EventArgs e) => RefreshData();

    // ---------- Hỗ trợ ----------
    private bool ValidateInput(Product current)
    {
        errorProvider.Clear();
        bool valid = true;

        string id = txtProductId.Text.Trim();
        if (id.Length == 0)
        {
            errorProvider.SetError(txtProductId, "Mã SP không được để trống.");
            valid = false;
        }
        else if (AppData.Products.Any(p => !ReferenceEquals(p, current) &&
                                           string.Equals(p.ProductId, id, StringComparison.OrdinalIgnoreCase)))
        {
            errorProvider.SetError(txtProductId, "Mã SP đã tồn tại.");
            valid = false;
        }

        if (string.IsNullOrWhiteSpace(txtProductName.Text))
        {
            errorProvider.SetError(txtProductName, "Tên sản phẩm không được để trống.");
            valid = false;
        }

        if (!decimal.TryParse(txtUnitPrice.Text, out var price) || price <= 0)
        {
            errorProvider.SetError(txtUnitPrice, "Đơn giá phải lớn hơn 0.");
            valid = false;
        }

        if (!int.TryParse(txtQuantity.Text, out var quantity) || quantity < 0)
        {
            errorProvider.SetError(txtQuantity, "Số lượng phải lớn hơn hoặc bằng 0.");
            valid = false;
        }

        return valid;
    }

    private static string NextProductId()
    {
        int n = AppData.Products.Count + 1;
        string id;
        do { id = $"SP{n++:D3}"; }
        while (AppData.Products.Any(p => string.Equals(p.ProductId, id, StringComparison.OrdinalIgnoreCase)));
        return id;
    }

    private void RefreshState()
    {
        bool hasData = AppData.Products.Count > 0;
        grpInfo.Enabled = hasData;
        btnDelete.Enabled = hasData;
        btnUpdate.Enabled = hasData;
        btnExportCsv.Enabled = hasData;
    }
}
