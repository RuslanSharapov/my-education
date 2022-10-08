Console.WriteLine("Введите трехзначное число: ");
int Number = int.Parse(Console.ReadLine());
int Number2 = Number / 100 * 10 + Number % 10;
Console.WriteLine("Новое число: " + Number2);