Console.WriteLine("введите кщщрдинаты x1:");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите кщщрдинаты y1:");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите кщщрдинаты z1:");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите кщщрдинаты x2:");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите кщщрдинаты y2:");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите кщщрдинаты z2:");
int z2 = int.Parse(Console.ReadLine());
double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine($"расстояние между двумя точками в 3D={dist:f2}");

