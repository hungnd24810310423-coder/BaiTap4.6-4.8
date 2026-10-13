namespace AsyncMdiApp;

public partial class FormProduct : Form
{
    private CancellationTokenSource? _cts;   // khác null nghĩa là đang nạp dữ liệu

    public FormProduct()
    {
        InitializeComponent();
    }

    private async void btnLoad_Click(object? sender, EventArgs e)
    {
        var parent = MdiParent as FormMain;

        btnLoad.Enabled = false;                 // khóa nút, tránh bấm trùng
        chkSimulateError.Enabled = false;
        progressBar.Value = 0;
        lblPercent.Text = "0%";

        _cts = new CancellationTokenSource();

        // Progress<int> tạo trên UI thread -> callback tự chạy lại trên UI thread
        var progress = new Progress<int>(percent =>
        {
            if (IsDisposed) return;
            progressBar.Value = percent;
            lblPercent.Text = $"{percent}%";
            parent?.UpdateProgress("Đang nạp danh sách sản phẩm...", percent);   // cập nhật StatusStrip form cha
        });

        try
        {
            List<Product> data = await DataLoader.LoadProductsAsync(progress, _cts.Token, chkSimulateError.Checked);

            // Sau await, code chạy lại trên UI thread nên được phép dùng control
            if (IsDisposed) return;
            dgvProducts.DataSource = data;
            progressBar.Value = 100;
            lblPercent.Text = "100%";
            parent?.UpdateProgress($"Nạp xong {data.Count} sản phẩm.", 100);
            MessageBox.Show($"Nạp dữ liệu hoàn tất: {data.Count} sản phẩm.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (OperationCanceledException)
        {
            // Xảy ra khi đóng form trong lúc đang nạp
            parent?.UpdateProgress("Đã hủy nạp dữ liệu.", 0);
        }
        catch (Exception ex)
        {
            parent?.UpdateProgress("Nạp dữ liệu thất bại.", 0);
            if (!IsDisposed)
            {
                lblPercent.Text = "Lỗi";
                MessageBox.Show($"Không thể nạp dữ liệu:\n{ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        finally
        {
            _cts?.Dispose();
            _cts = null;
            if (!IsDisposed)
            {
                btnLoad.Enabled = true;          // luôn mở lại nút dù thành công, lỗi hay hủy
                chkSimulateError.Enabled = true;
            }
        }
    }

    private void FormProduct_FormClosing(object? sender, FormClosingEventArgs e)
    {
        // Đóng form khi đang nạp -> hủy tác vụ nền, không cập nhật vào form đã đóng
        _cts?.Cancel();
    }
}
