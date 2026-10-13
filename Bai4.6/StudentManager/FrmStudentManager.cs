using System.ComponentModel;
using System.Text;

namespace StudentManager;

public partial class FrmStudentManager : Form
{
    private readonly BindingList<Student> _students = new();
    private readonly BindingSource _source = new();

    public FrmStudentManager()
    {
        InitializeComponent();
        InitializeData();
    }

    private void InitializeData()
    {
        _students.Add(new Student { StudentId = "SV001", FullName = "Nguyễn Văn An", Age = 20, Gender = "Nam" });
        _students.Add(new Student { StudentId = "SV002", FullName = "Trần Thị Bình", Age = 19, Gender = "Nữ" });
        _students.Add(new Student { StudentId = "SV003", FullName = "Lê Hoàng Cường", Age = 21, Gender = "Nam" });

        // BindingList<Student> -> BindingSource -> DataGridView + các Control nhập liệu
        _source.DataSource = _students;
        dgvStudents.DataSource = _source;

        // Binding 2 chiều: Control <-> thuộc tính của dòng đang chọn (Current)
        txtStudentId.DataBindings.Add("Text", _source, nameof(Student.StudentId), false, DataSourceUpdateMode.OnPropertyChanged);
        txtFullName.DataBindings.Add("Text", _source, nameof(Student.FullName), false, DataSourceUpdateMode.OnPropertyChanged);
        txtAge.DataBindings.Add("Text", _source, nameof(Student.Age), true, DataSourceUpdateMode.OnValidation);
        cboGender.DataBindings.Add("SelectedItem", _source, nameof(Student.Gender), true, DataSourceUpdateMode.OnPropertyChanged);

        // PictureBox: tự nạp ảnh từ AvatarPath mỗi khi đổi dòng (chỉ một chiều Source -> Control)
        var avatarBinding = new Binding("Image", _source, nameof(Student.AvatarPath), true, DataSourceUpdateMode.Never);
        avatarBinding.Format += AvatarBinding_Format;
        picAvatar.DataBindings.Add(avatarBinding);

        _source.ListChanged += (_, _) => RefreshState();
        RefreshState();
    }

    // ---------- Binding ảnh ----------
    private void AvatarBinding_Format(object? sender, ConvertEventArgs e)
    {
        picAvatar.Image?.Dispose();
        picAvatar.Image = null;
        e.Value = LoadImage(e.Value as string);
    }

    /// <summary>Đọc ảnh vào bộ nhớ (copy sang Bitmap) để không khóa file trên đĩa.</summary>
    private static Image? LoadImage(string? path)
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

    // ---------- Chức năng ----------
    private void btnAdd_Click(object? sender, EventArgs e)
    {
        var student = new Student { StudentId = NextStudentId(), Age = 18, Gender = "Nam" };
        _students.Add(student);
        _source.Position = _source.IndexOf(student);   // chọn dòng mới -> form tự hiển thị
        txtFullName.Focus();
    }

    private void btnUpdate_Click(object? sender, EventArgs e)
    {
        if (_source.Current is not Student current)
        {
            ShowInfo("Hãy chọn sinh viên cần cập nhật.");
            return;
        }

        if (!ValidateInput(current)) return;

        _source.EndEdit();            // đẩy dữ liệu từ Control xuống đối tượng
        _source.ResetCurrentItem();   // làm mới dòng trên lưới
        ShowInfo("Cập nhật thành công.");
    }

    private void btnDelete_Click(object? sender, EventArgs e)
    {
        if (_source.Current is not Student current)
        {
            ShowInfo("Hãy chọn sinh viên cần xóa.");
            return;
        }

        var result = MessageBox.Show(
            $"Bạn có chắc muốn xóa sinh viên '{current.FullName}'?",
            "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            _source.RemoveCurrent();
            errorProvider.Clear();
        }
    }

    private void btnChooseImage_Click(object? sender, EventArgs e)
    {
        if (_source.Current is not Student current)
        {
            ShowInfo("Hãy chọn hoặc thêm sinh viên trước khi chọn ảnh.");
            return;
        }

        using var dialog = new OpenFileDialog
        {
            Title = "Chọn ảnh đại diện",
            Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        };

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            // Đổi AvatarPath -> INotifyPropertyChanged -> binding tự nạp lại PictureBox
            current.AvatarPath = dialog.FileName;
        }
    }

    private void btnExportCsv_Click(object? sender, EventArgs e)
    {
        _source.EndEdit();

        using var dialog = new SaveFileDialog
        {
            Title = "Xuất danh sách sinh viên",
            Filter = "CSV file|*.csv",
            FileName = "students.csv"
        };

        if (dialog.ShowDialog() != DialogResult.OK) return;

        try
        {
            // UTF-8 có BOM để Excel hiển thị đúng tiếng Việt
            using var writer = new StreamWriter(dialog.FileName, false, new UTF8Encoding(true));
            writer.WriteLine("StudentId,FullName,Age,Gender,AvatarPath");
            foreach (var s in _students)
            {
                writer.WriteLine(string.Join(",",
                    Csv(s.StudentId), Csv(s.FullName), s.Age, Csv(s.Gender), Csv(s.AvatarPath)));
            }
            ShowInfo("Xuất CSV thành công.");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Không thể ghi file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // ---------- Hỗ trợ ----------
    private static string Csv(string? value) => $"\"{(value ?? string.Empty).Replace("\"", "\"\"")}\"";

    private bool ValidateInput(Student current)
    {
        errorProvider.Clear();
        bool valid = true;

        string id = txtStudentId.Text.Trim();
        if (id.Length == 0)
        {
            errorProvider.SetError(txtStudentId, "Mã SV không được để trống.");
            valid = false;
        }
        else if (_students.Any(s => !ReferenceEquals(s, current) &&
                                    string.Equals(s.StudentId, id, StringComparison.OrdinalIgnoreCase)))
        {
            errorProvider.SetError(txtStudentId, "Mã SV đã tồn tại.");
            valid = false;
        }

        if (string.IsNullOrWhiteSpace(txtFullName.Text))
        {
            errorProvider.SetError(txtFullName, "Họ tên không được để trống.");
            valid = false;
        }

        if (!int.TryParse(txtAge.Text, out int age) || age < 1 || age > 120)
        {
            errorProvider.SetError(txtAge, "Tuổi phải là số nguyên từ 1 đến 120.");
            valid = false;
        }

        return valid;
    }

    private string NextStudentId()
    {
        int n = _students.Count + 1;
        string id;
        do { id = $"SV{n++:D3}"; }
        while (_students.Any(s => string.Equals(s.StudentId, id, StringComparison.OrdinalIgnoreCase)));
        return id;
    }

    private void RefreshState()
    {
        bool hasData = _students.Count > 0;
        grpInfo.Enabled = hasData;
        btnDelete.Enabled = hasData;
        btnUpdate.Enabled = hasData;
        btnExportCsv.Enabled = hasData;
        lblStatus.Text = $"Tổng số sinh viên: {_students.Count}";
    }

    private static void ShowInfo(string message) =>
        MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
