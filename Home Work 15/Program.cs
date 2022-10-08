Console.WriteLine("Введите X: ");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int Y = int.Parse(Console.ReadLine());
if(X > 0 && Y > 0)
{
    Console.WriteLine("Первая Четверть");
}
if(X < 0 && Y > 0)
{
    Console.WriteLine("Вторая Четверть");
}
if(X < 0 && Y < 0)
{
    Console.WriteLine("Третья Четверть");
}
if(X > 0 && Y < 0)
{
    Console.WriteLine("Четвёртая Четверть");
}