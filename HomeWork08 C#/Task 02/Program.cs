int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
    int[,] array = new int[firstLength, secondLength];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);

    return array;
}

void MinRows(int[,] array)
{
    int max = 0;
    int maxRows = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            if (sum > max)
            {
                max = sum;
                maxRows = i + 1;
            }
        }
    }
    
    System.Console.WriteLine($"Максимальная сумма строки = {max}");
    System.Console.WriteLine($"Номер строки = {maxRows}");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
int[,] array = CreateTwoDimensionArray(4, 4);
PrintArray(array);
MinRows(array);
Console.WriteLine("");
// PrintArray(array);