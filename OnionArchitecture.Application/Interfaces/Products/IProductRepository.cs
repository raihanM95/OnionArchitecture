using OnionArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Interfaces.Products
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<bool> IsUniqueBarcodeAsync(string barcode);
    }
}
