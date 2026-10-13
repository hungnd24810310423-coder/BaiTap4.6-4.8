namespace AsyncMdiApp;

/// <summary>
/// Giả lập nạp dữ liệu lớn từ CSDL/File.
/// Phần nặng chạy ở luồng nền (Task.Run + Thread.Sleep), phần trăm báo về UI qua IProgress&lt;int&gt;.
/// </summary>
internal static class DataLoader
{
    private const int Total = 100;
    private const int DelayMs = 40;   // 100 bản ghi x 40ms ≈ 4 giây

    private static readonly string[] LastNames = { "Nguyễn", "Trần", "Lê", "Phạm", "Hoàng", "Vũ", "Đặng", "Bùi" };
    private static readonly string[] MiddleNames = { "Văn", "Thị", "Hữu", "Minh", "Quốc", "Ngọc" };
    private static readonly string[] FirstNames = { "An", "Bình", "Cường", "Dũng", "Hà", "Lan", "Linh", "Nam", "Trang" };
    private static readonly string[] Categories = { "Điện thoại", "Laptop", "Phụ kiện" };

    public static async Task<List<Student>> LoadStudentsAsync(
        IProgress<int> progress, CancellationToken cancellationToken, bool simulateError = false)
    {
        return await Task.Run(() =>
        {
            var random = new Random();
            var list = new List<Student>();

            for (int i = 1; i <= Total; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                Thread.Sleep(DelayMs);   // giả lập truy vấn chậm (đang ở luồng nền)

                if (simulateError && i == Total * 6 / 10)
                    throw new InvalidOperationException("Mất kết nối tới cơ sở dữ liệu (giả lập lỗi).");

                list.Add(new Student
                {
                    StudentId = $"SV{i:D3}",
                    FullName = $"{Pick(LastNames, random)} {Pick(MiddleNames, random)} {Pick(FirstNames, random)}",
                    Age = random.Next(18, 26),
                    Gender = random.Next(2) == 0 ? "Nam" : "Nữ"
                });

                progress.Report(i * 100 / Total);
            }

            return list;
        }, cancellationToken);
    }

    public static async Task<List<Product>> LoadProductsAsync(
        IProgress<int> progress, CancellationToken cancellationToken, bool simulateError = false)
    {
        return await Task.Run(() =>
        {
            var random = new Random();
            var list = new List<Product>();

            for (int i = 1; i <= Total; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                Thread.Sleep(DelayMs);

                if (simulateError && i == Total * 6 / 10)
                    throw new InvalidOperationException("Không đọc được file dữ liệu sản phẩm (giả lập lỗi).");

                list.Add(new Product
                {
                    ProductId = $"SP{i:D3}",
                    ProductName = $"Sản phẩm {i:D3}",
                    Category = Pick(Categories, random),
                    UnitPrice = random.Next(1, 60) * 500_000m,
                    Quantity = random.Next(0, 100)
                });

                progress.Report(i * 100 / Total);
            }

            return list;
        }, cancellationToken);
    }

    private static string Pick(string[] source, Random random) => source[random.Next(source.Length)];
}
