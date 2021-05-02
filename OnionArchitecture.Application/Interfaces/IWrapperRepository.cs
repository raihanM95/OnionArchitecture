using OnionArchitecture.Application.Interfaces.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture.Application.Interfaces
{
    public interface IWrapperRepository
    {
        IProductRepository Product { get; }
        //void Save();
    }
}
