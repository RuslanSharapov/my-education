Console.WriteLine("Введите ваше имя :");
string username = Console.ReadLine();
if(username.ToLower() == "ruslan")
{
    Console.WriteLine("Welcome back Ruslan!");
}
else
{
    Console.Write("Hello user ");
    Console.WriteLine(username);
}