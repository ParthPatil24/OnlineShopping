namespace BLL;
using BOL;
using DAL;

public class ProductManager
{
    public static ProductManager _ref = null;

    private ProductManager(){

    }

    public static ProductManager GetProductManager(){
        if(_ref==null)
        {
            _ref = new ProductManager();
        }
        return _ref;
    }

    public List<Product> GetAllProducts()
    {
        List<Product> products = ProductsRepository.GetAll();
        return products;
    }

    public Product GetProductById(int id)
    {
        Product product = ProductsRepository.GetById(id);
        return product;
    }

     public List<Product> GetSoldOutProducts()
    {
        List<Product> products = GetAllProducts();
        var soldOutProducts = from prod in products
                                where prod.Stock == 0
                                select prod;
        return soldOutProducts as List<Product>; 
    }

    public List<Country> GetAllCountries(){
        List<Country> countries = DBManager.GetAll();
        return countries;
    }

    public void Delete(int id)
    {
        Console.WriteLine(DBManager.Delete(id));
    }
}
