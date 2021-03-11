using OnionArchitecture.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture.Application
{
    public interface IWrapperRepository
    {
        IProductRepository Product { get; }
        void Save();
    }
}
