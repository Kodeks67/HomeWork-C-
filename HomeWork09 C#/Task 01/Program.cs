void PrintNumber(int first_number, int second_number)
{
    Console.WriteLine(second_number);
    if (first_number < second_number)
    {
        PrintNumber(first_number + 1, second_number - 1);
        System.Console.WriteLine(first_number);
    }
}
PrintNumber(1, 5);