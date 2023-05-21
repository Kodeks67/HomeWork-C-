int SumNumbers(int first_number, int second_number)
{
    if (first_number <= second_number)
    {
        return first_number + SumNumbers(first_number + 1, second_number);
    }
    return 0;
}
System.Console.WriteLine(SumNumbers(1, 15));
