using BISP.ApplicationLayer;
using BISP.DomainLayer;
using BISP.UI.Commons;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace BISP.UI.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    private readonly IProductService _productService;
    private ObservableCollection<Product> _products;
    private string _message;


    public MainViewModel(IProductService productService)
    {
        UpdateMessageCommand = new RelayCommand(UpdateMessage);
        _productService = productService;
        LoadProducts();
    }

    public ICommand UpdateMessageCommand { get; }

    public ObservableCollection<Product> Products
    {
        get { return _products; }
        set
        {
            _products = value;
            OnPropertyChanged();
        }
    }
    public string Message
    {
        get { return _message; }
        set { _message = value; OnPropertyChanged(); }
    }

    private void UpdateMessage()
    {
        var updatedMessage = DomainService.UpdateMessage();
        Message = updatedMessage;
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
