namespace SAL;
using BOL;
using BLL;

public class ProductHubService
{
    public List<Product> GetAllProducts()
    {
        ProductManager theManager=ProductManager.GetProductManager();
        List<Product> allProducts=theManager.GetAllProducts();
        return allProducts;    
    }

    public Product GetProductById(int id)
    {
        ProductManager theManager=ProductManager.GetProductManager();
        Product  theProduct=theManager.GetProductById(id);         
        return theProduct;
    }

    public List<Country> GetAllCountries()
    {
        ProductManager theManager = ProductManager.GetProductManager();
        List<Country> countries = theManager.GetAllCountries();
        return countries;
    }
    
    public void Delete(int id)
    {
         ProductManager theManager = ProductManager.GetProductManager();
         theManager.Delete(id);
    }
}
