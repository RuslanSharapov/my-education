Console.WriteLine("Select day of the week 1 - 7 :");
int week = int.Parse(Console.ReadLine());
if (week > 5 && week < 8)
{
    Console.WriteLine("Day off");
}
else
{
    Console.WriteLine("Working day");
}