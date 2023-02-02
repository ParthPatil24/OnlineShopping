namespace DAL;
using BOL;

public class ProductsRepository
{
    public static List<Product> GetAll()
    {
        List<Product> products = new List<Product>();
        products.Add(new Product{ Id = 1, Title = "Vandal", Description = "Rifle", Category = "Rifle", Price = 2900, Stock = 100});
        products.Add(new Product{ Id = 2, Title = "Phantom", Description = " Silenced Rifle", Category = "Rifle", Price = 2900, Stock = 50});
        products.Add(new Product{ Id = 3, Title = "Judge", Description = "Rapid Shotgun", Category = "Shotgun", Price = 1600, Stock = 0});
        products.Add(new Product{ Id = 4, Title = "Op", Description = "Long Rage Sniper Rifle", Category = " Sniper Rifle", Price = 2900, Stock = 1});

        return products;
    }

    public static Product GetById(int id)
    {
        List<Product> products = GetAll();
        var theProduct = (from prod in products where prod.Id == id select prod);
        return theProduct.First<Product>();
    } 

    public static bool Insert(Product product)
    {
        bool status = false;
        List<Product> products = GetAll();
        products.Add(product);
        status = true;
        return status;
    }

    public static bool Delete(int id)
    {
        bool status=false;
        List<Product> products = GetAll();
        Product theProduct=GetById(id);
        products.Remove(theProduct);
        status=true;
        return status;
    }

    public static bool Update(int id)
    {
        bool status=false;
        List<Product> products=GetAll();
        //var theProduct = 
        status=true;
        return status;
    }
}

