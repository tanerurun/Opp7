using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAll();
        List<Product> GetAllByCategory(int categoryId);
    }
}
