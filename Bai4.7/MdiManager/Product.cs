using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MdiManager;

public class Product : INotifyPropertyChanged
{
    private string _productId = string.Empty;
    private string _productName = string.Empty;
    private string _category = "Điện thoại";
    private decimal _unitPrice;
    private int _quantity;
    private string _imagePath = string.Empty;

    public event PropertyChangedEventHandler? PropertyChanged;

    public string ProductId { get => _productId; set => Set(ref _productId, value); }
    public string ProductName { get => _productName; set => Set(ref _productName, value); }
    public string Category { get => _category; set => Set(ref _category, value); }
    public decimal UnitPrice { get => _unitPrice; set => Set(ref _unitPrice, value); }
    public int Quantity { get => _quantity; set => Set(ref _quantity, value); }
    public string ImagePath { get => _imagePath; set => Set(ref _imagePath, value); }

    private void Set<T>(ref T field, T value, [CallerMemberName] string? name = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return;
        field = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
