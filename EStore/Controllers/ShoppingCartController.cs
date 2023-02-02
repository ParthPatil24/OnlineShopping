using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStore.Models;
using BOL;
using SAL;

namespace EStore.Controllers;

public class ShoppingCartController : Controller
{
    private readonly ILogger<ShoppingCartController> _logger;

    public ShoppingCartController(ILogger<ShoppingCartController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        //Show list of items kept in cart maintained by session
        int cart=int.Parse(HttpContext.Session.GetInt32("cart").ToString());
        this.ViewData["cart"]=cart;
        Console.WriteLine("Data is retrived from session cart");
        Console.WriteLine(cart);
        return View();
    }


    [HttpGet]
    public IActionResult AddToCart(int id)
    {
        Console.WriteLine("Data added to session cart");
        HttpContext.Session.SetInt32("cart", id);
        return RedirectToAction("Index","ShoppingCart");
    }
}