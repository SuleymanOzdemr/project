using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    // Solid
    // Open Closed Principle
    public class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var item in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(item.ProductName);
            }

        }
    }
}
