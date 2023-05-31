using BISP.ApplicationLayer;
using BISP.DomainLayer;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BISP.UI.ViewModels;

public class ProductViewModel : INotifyPropertyChanged
{
    private readonly IProductService _productService;
    private ObservableCollection<Product> _products;

    public ProductViewModel(IProductService productService)
    {
        _productService = productService;
        LoadProducts();
    }

    public ObservableCollection<Product> Products
    {
        get { return _products; }
        set
        {
            _products = value;
            OnPropertyChanged();
        }
    }

    private async void LoadProducts()
    {
        var products = await _productService.GetAllProductsAsync();
        Products = new ObservableCollection<Product>(products);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string propName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
