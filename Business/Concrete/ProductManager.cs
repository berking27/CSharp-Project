using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal ProductDal;

        public ProductManager(IProductDal productDal)
        {
            ProductDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Business Codes
            return ProductDal.GetAll();
            
        }
    }
}

