int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
    int[,] array = new int[firstLength, secondLength];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);

    return array;
}

bool FillArray(int[,] array, int checkNumber)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] == checkNumber)
            {
                Console.WriteLine($"{checkNumber} - Ура в массиве такое число есть");
                return true;
            }

    Console.WriteLine($"{checkNumber} - такого числа в массиве нет!");
    return false;
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
Console.Write("Введите проверяемое число: ");
int checkNumber = Convert.ToInt32(Console.ReadLine());
FillArray(array, checkNumber);