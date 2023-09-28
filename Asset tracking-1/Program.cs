


using Asset_tracking_1;
using System.Diagnostics;
using System.Reflection;

// creating a set list of products

List<Product> productList = new List<Product>();

productList.Add(new Laptop("HP", "Elitebook", "Sweden", "2020-10-2", "SEK", 588));
productList.Add(new Laptop("Asus", "W234", "USA", "2017-4-21", "USD", 1200));
productList.Add(new Laptop("Lenovo", "Yoga 730", "USA", "2018-5-28", "USD", 835));
productList.Add(new Laptop("Lenovo", "Yoga 730", "USA", "2019-5-21", "USD", 1030));
productList.Add(new Laptop("HP", "Elitebook", "Spain", "2019-6-1", "EUR", 1423));

productList.Add(new MobilePhone("iPhone", "8", "Spain", "2018-12-29", "EUR", 970));
productList.Add(new MobilePhone("iPhone", "11", "Spain", "2020-9-25", "EUR", 990));
productList.Add(new MobilePhone("iPhone", "X", "Sweden", "2018-7-15", "SEK", 1245));
productList.Add(new MobilePhone("Motorola", "Razr", "Sweden", "2020-3-16", "SEK", 970));

List<Product> productListOrder = productList.OrderBy(x => x.GetType().Name).ToList();
List<Product> productListOrderOffice = productList.OrderBy(x => x.Office).ThenBy(y => y.PurchaseDate).ToList();

// printing tableformat and all content

Console.WriteLine("Type".PadRight(15) + "Brand".PadRight(15) + "Model".PadRight(15) + "Office".PadRight(15) +
    "Purchase Date".PadRight(15) + "Price (USD)".PadRight(15) + "Currency".PadRight(15) + "Local price");
Console.WriteLine("----".PadRight(15) + "-----".PadRight(15) + "-----".PadRight(15) + "------".PadRight(15) +
    "-------------".PadRight(15) + "-----------".PadRight(15) + "--------".PadRight(15) + "-----------");

foreach (var i in productListOrderOffice)
{
    
    Console.Write(i.GetType().Name.PadRight(15));
    Console.Write(i.Brand.PadRight(15));
    Console.Write(i.Model.PadRight(15));
    Console.Write(i.Office.PadRight(15));
    Console.Write(i.PurchaseDate.PadRight(15));
    Console.Write(i.Price.ToString().PadRight(15));
    Console.Write(i.Currency.PadRight(15));
    //Console.Write(i.localPrice);

    Console.WriteLine();
    
}


Console.ReadLine();