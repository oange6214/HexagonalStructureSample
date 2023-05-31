
using BISP.DomainLayer;

namespace BISP.ApplicationLayer;

public interface IProductService
{
    IEnumerable<Product> GetAllProducts();
    Product GetProductById(int id);
    void AddProduct(Product product);
}