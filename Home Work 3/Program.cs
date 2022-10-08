Console.WriteLine("Введите число a ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c ");
int c = int.Parse(Console.ReadLine());
if(a > b && a > c)
{
    Console.WriteLine(a);
}
if(b > a && b > c)
{
    Console.WriteLine(b);
}
if(c > a && c > b)
{
    Console.WriteLine(c);
}