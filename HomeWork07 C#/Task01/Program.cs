double[,] CreateTwoDimensionArray(int firstLength, int secondLength, int firstnumber, int secondnumber)
{
    double[,] array = new double[firstLength, secondLength];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().NextDouble() * new Random().Next(firstnumber, secondnumber);

    return array;
}


void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

Console.Write("первое число для диапазона: ");
int firstnumber1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число для диапазона: ");
int secondnumber2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
PrintArray(CreateTwoDimensionArray(line, column, firstnumber1, secondnumber2));
