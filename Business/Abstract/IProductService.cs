using System;
using System.Collections.Generic;
using Entities.Abstract;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}

