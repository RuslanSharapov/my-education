int[] num = { 1, 3, 6, 17, 14, 58, 99 };
int Max = int.MinValue;
for (int i = 0; i < num.Length; i++)
{
    if (Max < num[i])
    {
        Max = num[i];
    }
}
Console.WriteLine(Max);
Console.ReadKey();