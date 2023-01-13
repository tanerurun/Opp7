using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class ProductDal : IProductDal
    {
        List<Product> _products;
        public ProductDal()
        {
            _products = new List<Product>
            {
                new Product{ ProductId=1, CategoryId=1, ProductName="kalem", UnitPrice=34, UnitsInStock=4 },
                new Product{ ProductId=2, UnitsInStock= 4 },
                new Product{ ProductId=3,UnitsInStock= 4 , UnitPrice=4, ProductName="bardak", CategoryId=4}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;
            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = null;
            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.ProductName = product.ProductName;

        }
    }
}
