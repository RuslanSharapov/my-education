Console.WriteLine("Введите координаты x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты x2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты z2: ");
int z2 = int.Parse(Console.ReadLine());

double d = Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0), 0.5);
Console.WriteLine("Расстояние " + d);