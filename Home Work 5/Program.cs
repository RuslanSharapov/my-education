Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
int b = (a * (-1));
while(b <= a)
{
    int c = b++;
    Console.WriteLine(c);
}