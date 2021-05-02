using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Application.Interfaces.Products;
using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Infrastructure.Persistence.Repositories.Products
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly DbSet<Product> _products;

        public ProductRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
            _products = repositoryContext.Set<Product>();
        }

        public Task<bool> IsUniqueBarcodeAsync(string barcode)
        {
            return _products
                .AllAsync(p => p.Barcode != barcode);
        }
    }
}
