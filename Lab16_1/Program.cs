// See https://aka.ms/new-console-template for more information
using Lab16_1;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

const int n = 5;
Product[] products = new Product[n];

for (int i = 0; i < n; i++)
{
    products[i] = new Product();
    Console.WriteLine("Введите код товара");
    products[i].code = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите название товара");
    products[i].name = Console.ReadLine();
    Console.WriteLine("Введите цену товара");
    products[i].price = Convert.ToDouble(Console.ReadLine());
}

JsonSerializerOptions options = new JsonSerializerOptions()
{
    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
    WriteIndented = true
};

string json = JsonSerializer.Serialize(products, options);

using (StreamWriter sw = new StreamWriter("../../../../Products.json"))
{
    sw.WriteLine(json);
}
