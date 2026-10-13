using System.ComponentModel;

namespace MdiManager;

/// <summary>
/// Kho dữ liệu dùng chung toàn ứng dụng. Đóng rồi mở lại Form con thì dữ liệu vẫn còn.
/// </summary>
internal static class AppData
{
    public static BindingList<Student> Students { get; } = new()
    {
        new Student { StudentId = "SV001", FullName = "Nguyễn Văn An", Age = 20, Gender = "Nam" },
        new Student { StudentId = "SV002", FullName = "Trần Thị Bình", Age = 19, Gender = "Nữ" },
        new Student { StudentId = "SV003", FullName = "Lê Hoàng Cường", Age = 21, Gender = "Nam" }
    };

    public static BindingList<Product> Products { get; } = new()
    {
        new Product { ProductId = "SP001", ProductName = "iPhone 17", Category = "Điện thoại", UnitPrice = 25000000, Quantity = 10 },
        new Product { ProductId = "SP002", ProductName = "Dell XPS 13", Category = "Laptop", UnitPrice = 32000000, Quantity = 5 },
        new Product { ProductId = "SP003", ProductName = "Tai nghe Bluetooth", Category = "Phụ kiện", UnitPrice = 850000, Quantity = 40 }
    };
}
