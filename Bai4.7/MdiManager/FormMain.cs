namespace MdiManager;

/// <summary>MDI Parent: quản lý tập trung các cửa sổ chức năng.</summary>
public partial class FormMain : Form
{
    private string _userName = string.Empty;
    private bool _forceClose;

    public FormMain()
    {
        InitializeComponent();
    }

    /// <summary>Đặt thuộc tính này trước khi hiển thị form.</summary>
    public string UserName
    {
        get => _userName;
        set
        {
            _userName = value;
            lblUser.Text = $"Người dùng: {value}";
        }
    }

    /// <summary>true nếu người dùng chọn Đăng xuất (Program sẽ hiện lại form đăng nhập).</summary>
    public bool LoggedOut { get; private set; }

    private void FormMain_Load(object? sender, EventArgs e)
    {
        // Form MDI có một control MdiClient phủ toàn bộ vùng làm việc;
        // phải gán ContextMenuStrip cho nó thì chuột phải trên nền mới hiện menu.
        foreach (Control control in Controls)
        {
            if (control is MdiClient) control.ContextMenuStrip = ctxMain;
        }

        lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        SetStatus("Sẵn sàng.");
    }

    // ================= Mở / kích hoạt Form con =================

    /// <summary>
    /// Nếu Form kiểu T chưa mở -> khởi tạo, gán MdiParent và hiển thị.
    /// Nếu đã mở -> chỉ kích hoạt (đưa lên trên cùng), không mở lặp lại.
    /// </summary>
    private T OpenChild<T>() where T : BaseChildForm, new()
    {
        var existing = MdiChildren.OfType<T>().FirstOrDefault();
        if (existing is not null)
        {
            if (existing.WindowState == FormWindowState.Minimized)
                existing.WindowState = FormWindowState.Normal;

            existing.Activate();
            existing.BringToFront();
            SetStatus($"Cửa sổ '{existing.Text}' đang mở, đã chuyển lên trên cùng.");
            return existing;
        }

        var form = new T
        {
            MdiParent = this,
            CurrentUser = _userName               // Cha -> Con: truyền dữ liệu
        };
        form.StatusChanged += Child_StatusChanged;  // Con -> Cha: nhận thông điệp
        form.FormClosed += (_, _) =>
        {
            form.StatusChanged -= Child_StatusChanged;
            SetStatus($"Đã đóng cửa sổ '{form.Text}'.");
        };
        form.Show();
        SetStatus($"Đã mở cửa sổ '{form.Text}'.");
        return form;
    }

    private void Child_StatusChanged(object? sender, StatusEventArgs e)
    {
        string title = (sender as Form)?.Text ?? "Cửa sổ con";
        SetStatus($"{title}: {e.Message}");
    }

    private void SetStatus(string message) =>
        lblMessage.Text = $"[{DateTime.Now:HH:mm:ss}] {message}";

    // ================= Menu Danh mục / ToolStrip =================

    private void mnuStudent_Click(object? sender, EventArgs e) => OpenChild<FormStudent>();

    private void mnuProduct_Click(object? sender, EventArgs e) => OpenChild<FormProduct>();

    // ================= Menu Cửa sổ =================

    private void mnuCascade_Click(object? sender, EventArgs e) => LayoutMdi(MdiLayout.Cascade);

    private void mnuTileHorizontal_Click(object? sender, EventArgs e) => LayoutMdi(MdiLayout.TileHorizontal);

    private void mnuTileVertical_Click(object? sender, EventArgs e) => LayoutMdi(MdiLayout.TileVertical);

    private void mnuRefresh_Click(object? sender, EventArgs e)
    {
        // Cha -> Con: gọi hàm của Form con đang active
        if (ActiveMdiChild is BaseChildForm child)
            child.RefreshData();
        else
            SetStatus("Chưa có cửa sổ nào đang mở để làm mới.");
    }

    private void mnuCloseAll_Click(object? sender, EventArgs e)
    {
        foreach (var child in MdiChildren.ToArray())
            child.Close();
    }

    // ================= Menu Hệ thống =================

    private void mnuLogout_Click(object? sender, EventArgs e)
    {
        var result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result != DialogResult.Yes) return;

        LoggedOut = true;
        _forceClose = true;
        Close();
    }

    private void mnuExit_Click(object? sender, EventArgs e) => Close();

    private void FormMain_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (_forceClose) return;

        var result = MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thoát",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result != DialogResult.Yes) e.Cancel = true;
    }

    // ================= Đồng hồ =================

    private void timerClock_Tick(object? sender, EventArgs e) =>
        lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
}
