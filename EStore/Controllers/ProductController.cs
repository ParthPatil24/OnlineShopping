using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BOL;
using SAL;

namespace EStore.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        ProductHubService svc = new ProductHubService();
        List<Product> allProducts = svc.GetAllProducts();
        this.ViewData["products"] = allProducts;
        return View();
    }

    [HttpGet]
    public IActionResult Details(int id)
    {  
        ProductHubService svc=new ProductHubService();
        Product product=svc.GetProductById(id);  
        Console.WriteLine(product.Title + " " + product.Id);
        this.ViewBag.currentProduct=product;
        return View();
    }
}