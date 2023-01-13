using Bussines.Concrete;
using DataAccess.Concrete.InMemory;

internal class Program
{
    private static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new ProductDal());
        foreach (var item in productManager.GetAll())
        {
            Console.WriteLine(item.ProductName);
        }
        Console.WriteLine("Hello, World!");
    }
}