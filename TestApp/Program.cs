using BOL;
using System.IO;
using System.Text.Json;

List<Product> products = new List<Product>();
        products.Add(new Product{ Id = 1, Title = "Vandal", Description = "Rifle", Category = "Rifle", Price = 2900, Stock = 100});
        products.Add(new Product{ Id = 2, Title = "Phantom", Description = " Silenced Rifle", Category = "Rifle", Price = 2900, Stock = 50});
        products.Add(new Product{ Id = 3, Title = "Judge", Description = "Rapid Shotgun", Category = "Shotgun", Price = 1600, Stock = 0});
        products.Add(new Product{ Id = 4, Title = "Op", Description = "Long Rage Sniper Rifle", Category = " Sniper Rifle", Price = 2900, Stock = 1});

string jsonString = JsonSerializer.Serialize(products);
Console.WriteLine(jsonString);
File.WriteAllText("D:\\products.json", jsonString);

string restoredJsonString = File.ReadAllText("D:\\products.json");

List<Product> restoredProducts = JsonSerializer.Deserialize<List<Product>>(restoredJsonString);
Console.WriteLine("\n\n\n Deserialized data from file  products.json\n\n\n");

foreach(Product p in restoredProducts){
    Console.WriteLine(p.Title+" "+p.Id);
}
