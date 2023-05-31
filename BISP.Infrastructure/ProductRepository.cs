﻿
using BISP.DomainLayer;

namespace BISP.InfrastructureLayer;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Product> GetAll()
    {
        return _context.Products.ToList();
    }

    public Product GetById(int id)
    {
        return _context.Products.Find(id);
    }

    public void Add(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }
}
