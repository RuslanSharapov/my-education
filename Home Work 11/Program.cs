Console.WriteLine("Введите первое число ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int B = int.Parse(Console.ReadLine());
int result = A % B;
if (result == 0)
{
    Console.WriteLine("Число A кратно числу B");
}
else
{
    Console.WriteLine("Число не кратно, остаток : " + result);
}