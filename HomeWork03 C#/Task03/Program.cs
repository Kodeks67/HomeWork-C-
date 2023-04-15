void pow(double num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}
pow(double.Parse(Console.ReadLine()));