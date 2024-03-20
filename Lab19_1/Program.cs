// See https://aka.ms/new-console-template for more information
using Lab19_1;

Console.WriteLine("Hello, World!");


List<PCModel> pcs = new List<PCModel>();

pcs.Add(new PCModel(1, "PC 1", "i3", 2.2, 4, 256, 2, 3000, 100));
pcs.Add(new PCModel(3, "PC 3", "i5", 3.2, 8, 512, 4, 5000, 50));
pcs.Add(new PCModel(2, "PC 2", "i3", 3.2, 8, 256, 2, 3500, 20));
pcs.Add(new PCModel(5, "PC 5", "i7", 4.2, 16, 1024, 4, 7000, 90));
pcs.Add(new PCModel(4, "PC 4", "i5", 3.2, 16, 1024, 4, 6000, 70));
pcs.Add(new PCModel(6, "PC 6", "i7", 4.2, 32, 2048, 8, 9000, 60));


Console.WriteLine("Введите тип процессора");
string type = Console.ReadLine();
List<PCModel> pcsWithType = pcs.Where(pc => pc.type == type).ToList();

Console.WriteLine("Введите объем озу");
int memory = Convert.ToInt32(Console.ReadLine());
List<PCModel> pcsWithMemory = pcs.Where(pc => pc.memory_volume >= memory).ToList();

List<PCModel> sortedByPrice = pcs.OrderBy(pc => pc.price).ToList();

IEnumerable<IGrouping<string, PCModel>> groupedByType = pcs.GroupBy(pc => pc.type);

bool hasMoreThan30 = pcs.Any(pc => pc.quantity >= 30);

Console.WriteLine(hasMoreThan30);
