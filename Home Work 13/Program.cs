Console.WriteLine("Select day of the week 1 - 7 :");
int day = int.Parse(Console.ReadLine());
if (day > 5 && day < 8)
{
    Console.WriteLine("Day off");
}
else
{
    Console.WriteLine("Working day");
}