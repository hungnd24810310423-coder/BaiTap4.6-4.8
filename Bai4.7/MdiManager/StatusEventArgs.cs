namespace MdiManager;

/// <summary>Thông điệp trạng thái Form con gửi lên Form cha.</summary>
public class StatusEventArgs : EventArgs
{
    public string Message { get; }
    public StatusEventArgs(string message) => Message = message;
}
