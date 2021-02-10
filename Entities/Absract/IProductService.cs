using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Absract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByUnitPrice(decimal min, decimal max);
    }
}

