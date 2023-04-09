Console.WriteLine("Введите число для начала интервала");
int numberA = int.Parse (Console.ReadLine());
Console.WriteLine("Введите число для конца интервала");
int numberB = int.Parse (Console.ReadLine());
int Rand = new Random().Next(numberA, numberB);
Console.WriteLine(Rand);

if (Rand > 100 && Rand < 1000)
{
    Rand %= 10;
    Console.WriteLine(Rand);
}
else if (Rand > 1000)
{
    string str = Rand.ToString();
    Console.WriteLine(str[2]);
}
else
{
    Console.WriteLine("Третей цифры нет");
}
