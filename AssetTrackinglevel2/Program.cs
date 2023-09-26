


using Asset_tracking_2;
using AssetTrackinglevel2;
using System.Collections.Generic;
using System.Diagnostics;

List<Product> productList = new List<Product>();
AppMessages appMessages = new AppMessages();
AddProduct addProduct = new AddProduct();


// creating a set list of products, mostly for testing purposes

productList.Add(new Computer("HP", "Elitebook", "Sweden", "2020-10-2", "SEK", 588));
productList.Add(new Computer("Asus", "W234", "USA", "2017-4-21", "USD", 1200));
productList.Add(new Computer("Lenovo", "Yoga 730", "USA", "2018-5-28", "USD", 835));
productList.Add(new Computer("Lenovo", "Yoga 730", "USA", "2019-5-21", "USD", 1030));
productList.Add(new Computer("HP", "Elitebook", "Spain", "2019-6-1", "EUR", 1423));

productList.Add(new Phone("iPhone", "8", "Spain", "2018-12-29", "EUR", 970));
productList.Add(new Phone("iPhone", "11", "Spain", "2020-9-25", "EUR", 990));
productList.Add(new Phone("iPhone", "X", "Sweden", "2018-7-15", "SEK", 1245));
productList.Add(new Phone("Motorola", "Razr", "Sweden", "2020-3-16", "SEK", 970));

string typeName;

while (true)
{
    appMessages.Instructions();
    Console.Write("Type of product: ");
    typeName = Console.ReadLine();
    if (typeName.ToLower().Trim() == "q")
    {
        break;
    }
    if (typeName.ToLower().Trim() == "p")
    {
        addProduct.Phone(productList);
    }
    else if (typeName.ToLower().Trim() == "c")
    {
        addProduct.Computer(productList);
    }
    appMessages.successfulAdd();
}

List<Product> productListOrder = productList.OrderBy(x => x.GetType().Name).ToList();
List<Product> productListOrderOffice = productList.OrderBy(x => x.Office).ThenBy(y => y.PurchaseDate).ToList();

// printing tableformat and all content

new Printing().PrintTableOfContent(productListOrderOffice);

Console.ReadLine();