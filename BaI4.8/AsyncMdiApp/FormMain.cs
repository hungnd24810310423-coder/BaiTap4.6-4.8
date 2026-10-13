namespace AsyncMdiApp;

/// <summary>MDI Parent: chứa menu, các Form con và StatusStrip hiển thị tiến trình.</summary>
public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    /// <summary>Form con gọi hàm này để cập nhật thông điệp và % tiến trình lên StatusStrip.</summary>
    public void UpdateProgress(string message, int percent)
    {
        percent = Math.Clamp(percent, 0, 100);
        lblMessage.Text = message;
        pbStatus.Value = percent;
        lblPercent.Text = $"{percent}%";
    }

    /// <summary>Chưa mở thì tạo mới; đã mở thì chỉ kích hoạt.</summary>
    private void OpenChild<T>() where T : Form, new()
    {
        var existing = MdiChildren.OfType<T>().FirstOrDefault();
        if (existing is not null)
        {
            existing.Activate();
            return;
        }

        new T { MdiParent = this }.Show();
    }

    private void mnuStudent_Click(object? sender, EventArgs e) => OpenChild<FormStudent>();

    private void mnuProduct_Click(object? sender, EventArgs e) => OpenChild<FormProduct>();

    private void mnuExit_Click(object? sender, EventArgs e) => Close();
}
