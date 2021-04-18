using OnionArchitecture.Application.Interfaces;
using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture.Infrastructure.Service.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
