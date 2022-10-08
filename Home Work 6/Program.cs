Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
while(a <= 100)
{
    int b = a % 2;
    if(b != 1)
    {
        Console.WriteLine("четное " + a);
        a++;
    }
    else
    {
        a++;
    }
}
