using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    // Context : Db tabloları ile proje classlarını bağlamak.
    // EntityFrameWorkCore ile DbContext miras alarak kullanabilir olduk.
    // override yazarak clasın içindeki metodu kolaylıkla çağırıldı.
    //Server için veritabanı ismi eklendi, hangi database'bağlanacağını belirlemek için 
    //veri tabanı ismi eklendi (Northwind) 
    //veri tabanı şifre ile girilmediğinden Trusted_Connection = true olarak yazıldı. 
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database = Northwind; Trusted_Connection = true");
        }

        // Burada Veritabanından gelecek product tablosunu Products'a bağla.
        // Context Db Tabloları ile proje claslarını bağlamaya yarar.
        //DbSet<Product>  -----> Products
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
