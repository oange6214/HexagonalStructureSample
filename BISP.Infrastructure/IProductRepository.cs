﻿
using BISP.DomainLayer;

namespace BISP.InfrastructureLayer;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product> GetByIdAsync(int id);
    Task AddAsync(Product product);
}
