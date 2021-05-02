using OnionArchitecture.Application.Interfaces;
using OnionArchitecture.Application.Interfaces.Products;
using OnionArchitecture.Infrastructure.Persistence.Contexts;
using OnionArchitecture.Infrastructure.Persistence.Repositories.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture.Infrastructure.Persistence.Repositories
{
    public class WrapperRepository : IWrapperRepository
    {
        private RepositoryContext _repoContext;
        private IProductRepository _product;

        public IProductRepository Product
        {
            get
            {
                if (_product == null)
                {
                    _product = new ProductRepository(_repoContext);
                }
                return _product;
            }
        }

        public WrapperRepository(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }
}
