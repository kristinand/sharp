// See https://aka.ms/new-console-template for more information

using Lab16_2;
using System.Text.Json;

string json = string.Empty;
using (StreamReader sr = new StreamReader("../../../../Products.json"))
{
    json = sr.ReadToEnd();
}

Product[] products = JsonSerializer.Deserialize<Product[]>(json);

if (products != null)
{
    Product productWithMaxPrice = products[0];
    foreach (Product product in products)
    {
        if (product.price > productWithMaxPrice.price)
        {
            productWithMaxPrice = product;
        }
    }

Console.WriteLine(productWithMaxPrice.name);
}
