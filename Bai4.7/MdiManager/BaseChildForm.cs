using System.Text;

namespace MdiManager;

/// <summary>
/// Lớp cơ sở cho mọi Form con (MDI Child).
///  - Con -> Cha : sự kiện StatusChanged (ReportStatus) để cập nhật StatusStrip của FormMain.
///  - Cha -> Con : thuộc tính CurrentUser và hàm RefreshData() do FormMain gọi.
/// </summary>
public class BaseChildForm : Form
{
    public event EventHandler<StatusEventArgs>? StatusChanged;

    /// <summary>Tên người dùng đang đăng nhập (do Form cha truyền xuống).</summary>
    public string CurrentUser { get; set; } = string.Empty;

    /// <summary>Form cha gọi hàm này để yêu cầu Form con làm mới dữ liệu.</summary>
    public virtual void RefreshData() { }

    protected void ReportStatus(string message) =>
        StatusChanged?.Invoke(this, new StatusEventArgs(message));

    protected static void ShowInfo(string message) =>
        MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

    protected static string Csv(string? value) =>
        $"\"{(value ?? string.Empty).Replace("\"", "\"\"")}\"";

    /// <summary>Đọc ảnh vào bộ nhớ (copy sang Bitmap) để không khóa file trên đĩa.</summary>
    protected static Image? LoadImage(string? path)
    {
        if (string.IsNullOrWhiteSpace(path) || !File.Exists(path)) return null;
        try
        {
            using var stream = File.OpenRead(path);
            using var temp = Image.FromStream(stream);
            return new Bitmap(temp);
        }
        catch
        {
            return null;
        }
    }

    /// <summary>Binding một chiều: đường dẫn ảnh (nguồn) -> PictureBox.Image.</summary>
    protected static void BindImage(PictureBox pic, BindingSource source, string pathProperty)
    {
        var binding = new Binding("Image", source, pathProperty, true, DataSourceUpdateMode.Never);
        binding.Format += (_, e) =>
        {
            pic.Image?.Dispose();
            pic.Image = null;
            e.Value = LoadImage(e.Value as string);
        };
        pic.DataBindings.Add(binding);
    }

    /// <summary>Hiện SaveFileDialog và ghi CSV (UTF-8 có BOM). Trả về đường dẫn file hoặc null.</summary>
    protected static string? SaveCsv(string defaultFileName, string header, IEnumerable<string> rows)
    {
        using var dialog = new SaveFileDialog
        {
            Title = "Xuất file CSV",
            Filter = "CSV file|*.csv",
            FileName = defaultFileName
        };
        if (dialog.ShowDialog() != DialogResult.OK) return null;

        try
        {
            using var writer = new StreamWriter(dialog.FileName, false, new UTF8Encoding(true));
            writer.WriteLine(header);
            foreach (var row in rows) writer.WriteLine(row);
            return dialog.FileName;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Không thể ghi file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }
}
