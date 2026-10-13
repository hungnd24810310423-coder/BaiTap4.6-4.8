namespace MdiManager;

public partial class FormLogin : Form
{
    public FormLogin()
    {
        InitializeComponent();
    }

    public string UserName => txtUserName.Text.Trim();

    private void btnLogin_Click(object? sender, EventArgs e)
    {
        if (UserName.Length == 0)
        {
            MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtUserName.Focus();
            return;
        }

        if (txtPassword.Text != "123456")
        {
            MessageBox.Show("Sai mật khẩu.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtPassword.Clear();
            txtPassword.Focus();
            return;
        }

        DialogResult = DialogResult.OK;
    }
}
