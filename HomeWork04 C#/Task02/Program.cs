int SumNum(int num)
{
    int count = 0;
    while (num > 0)
    {
        // count = count + num % 10;
        count += num % 10;
        // num = num / 10
        num /= 10;
    }
    return count;


}
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма числе :" + SumNum(a));