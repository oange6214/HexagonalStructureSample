using BISP.DomainLayer;
using BISP.InfrastructureLayer;

namespace BISP.ApplicationLayer;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _productRepository.GetAll();
    }

    public Product GetProductById(int id)
    {
        return _productRepository.GetById(id);
    }

    public void AddProduct(Product product)
    {
        _productRepository.Add(product);
    }
}
