using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Abstract;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product {ProductId = 1 , CategoryID = 1,ProductName="Table",UnitPrice = 15,UnitsInStock = 15},
                new Product { ProductId = 2, CategoryID = 2, ProductName = "Camera", UnitPrice = 500, UnitsInStock = 3 },
                new Product { ProductId = 3, CategoryID = 3, ProductName = "Phone", UnitPrice = 1500, UnitsInStock = 2 },
                new Product { ProductId = 4, CategoryID = 4, ProductName = "Keyboard", UnitPrice = 400, UnitsInStock = 10 },
                new Product { ProductId = 5, CategoryID = 5, ProductName = "Xbox", UnitPrice = 1700, UnitsInStock = 2 },

            };
        }


        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ usage instead of loop, we can use LINQ like below. 
            Product prodcuctToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryID == categoryId).ToList();
            //Uyanları yeni bir liste yapar
        }

        public void Update(Product product)
        {
            Product prodcuctToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            prodcuctToUpdate.ProductName = product.ProductName;
            prodcuctToUpdate.CategoryID = product.CategoryID;
            prodcuctToUpdate.UnitPrice = product.UnitPrice;
            prodcuctToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}

