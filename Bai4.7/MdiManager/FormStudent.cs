namespace MdiManager;

public partial class FormStudent : BaseChildForm
{
    private readonly BindingSource _source = new();

    public FormStudent()
    {
        InitializeComponent();
    }

    private void FormStudent_Load(object? sender, EventArgs e)
    {
        // BindingList<Student> -> BindingSource -> DataGridView + các Control nhập liệu
        _source.DataSource = AppData.Students;
        dgvStudents.DataSource = _source;

        // Binding 2 chiều: Control <-> dòng đang chọn
        txtStudentId.DataBindings.Add("Text", _source, nameof(Student.StudentId), false, DataSourceUpdateMode.OnPropertyChanged);
        txtFullName.DataBindings.Add("Text", _source, nameof(Student.FullName), false, DataSourceUpdateMode.OnPropertyChanged);
        txtAge.DataBindings.Add("Text", _source, nameof(Student.Age), true, DataSourceUpdateMode.OnValidation);
        cboGender.DataBindings.Add("SelectedItem", _source, nameof(Student.Gender), true, DataSourceUpdateMode.OnPropertyChanged);

        // PictureBox tự nạp ảnh từ AvatarPath khi đổi dòng
        BindImage(picAvatar, _source, nameof(Student.AvatarPath));

        _source.ListChanged += (_, _) => RefreshState();
        RefreshState();
    }

    private void FormStudent_FormClosed(object? sender, FormClosedEventArgs e)
    {
        picAvatar.Image?.Dispose();
        _source.Dispose();   // ngắt kết nối khỏi danh sách dùng chung
    }

    public override void RefreshData()
    {
        _source.EndEdit();
        _source.ResetBindings(false);
        ReportStatus("Đã làm mới danh sách sinh viên.");
    }

    // ---------- Chức năng ----------
    private void btnAdd_Click(object? sender, EventArgs e)
    {
        var student = new Student { StudentId = NextStudentId(), Age = 18, Gender = "Nam" };
        AppData.Students.Add(student);
        _source.Position = _source.IndexOf(student);
        txtFullName.Focus();
        ReportStatus($"Đã thêm sinh viên mới '{student.StudentId}'. Hãy nhập thông tin rồi bấm Cập nhật.");
    }

    private void btnUpdate_Click(object? sender, EventArgs e)
    {
        if (_source.Current is not Student current)
        {
            ShowInfo("Hãy chọn sinh viên cần cập nhật.");
            return;
        }

        if (!ValidateInput(current)) return;

        _source.EndEdit();
        _source.ResetCurrentItem();
        ReportStatus($"Đã cập nhật sinh viên '{current.StudentId} - {current.FullName}'.");
    }

    private void btnDelete_Click(object? sender, EventArgs e) => DeleteCurrent();

    private void DeleteCurrent()
    {
        if (_source.Current is not Student current)
        {
            ShowInfo("Hãy chọn sinh viên cần xóa.");
            return;
        }

        var result = MessageBox.Show(
            $"Bạn có chắc muốn xóa sinh viên '{current.FullName}'?",
            "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result != DialogResult.Yes) return;

        string info = $"{current.StudentId} - {current.FullName}";
        _source.RemoveCurrent();
        errorProvider.Clear();
        ReportStatus($"Đã xóa sinh viên '{info}'.");
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
            current.AvatarPath = dialog.FileName;
            ReportStatus($"Đã đổi ảnh đại diện cho '{current.StudentId}'.");
        }
    }

    private void btnExportCsv_Click(object? sender, EventArgs e)
    {
        _source.EndEdit();

        string? path = SaveCsv("students.csv",
            "StudentId,FullName,Age,Gender,AvatarPath",
            AppData.Students.Select(s =>
                string.Join(",", Csv(s.StudentId), Csv(s.FullName), s.Age, Csv(s.Gender), Csv(s.AvatarPath))));

        if (path is not null)
            ReportStatus($"Đã xuất {AppData.Students.Count} sinh viên ra '{Path.GetFileName(path)}'.");
    }

    // ---------- ContextMenuStrip của DataGridView ----------
    private void dgvStudents_CellMouseDown(object? sender, DataGridViewCellMouseEventArgs e)
    {
        // Chuột phải: chọn luôn dòng được nhấn để menu ngữ cảnh tác động đúng dòng
        if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
        {
            dgvStudents.ClearSelection();
            dgvStudents.Rows[e.RowIndex].Selected = true;
            dgvStudents.CurrentCell = dgvStudents.Rows[e.RowIndex].Cells[Math.Max(0, e.ColumnIndex)];
        }
    }

    private void mnuViewDetail_Click(object? sender, EventArgs e)
    {
        if (_source.Current is not Student s)
        {
            ShowInfo("Chưa chọn sinh viên nào.");
            return;
        }

        MessageBox.Show(
            $"Mã SV: {s.StudentId}\nHọ tên: {s.FullName}\nTuổi: {s.Age}\nGiới tính: {s.Gender}\n" +
            $"Ảnh: {(string.IsNullOrEmpty(s.AvatarPath) ? "(chưa có)" : s.AvatarPath)}",
            "Chi tiết sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ReportStatus($"Đã xem chi tiết sinh viên '{s.StudentId}'.");
    }

    private void mnuDeleteRow_Click(object? sender, EventArgs e) => DeleteCurrent();

    private void mnuRefresh_Click(object? sender, EventArgs e) => RefreshData();

    // ---------- Hỗ trợ ----------
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
        else if (AppData.Students.Any(s => !ReferenceEquals(s, current) &&
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

    private static string NextStudentId()
    {
        int n = AppData.Students.Count + 1;
        string id;
        do { id = $"SV{n++:D3}"; }
        while (AppData.Students.Any(s => string.Equals(s.StudentId, id, StringComparison.OrdinalIgnoreCase)));
        return id;
    }

    private void RefreshState()
    {
        bool hasData = AppData.Students.Count > 0;
        grpInfo.Enabled = hasData;
        btnDelete.Enabled = hasData;
        btnUpdate.Enabled = hasData;
        btnExportCsv.Enabled = hasData;
    }
}
