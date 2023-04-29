double[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
	double[,] array = new double[firstLength, secondLength];

	for (int i = 0; i < array.GetLength(0); i++)
		for (int j = 0; j < array.GetLength(1); j++)
			array[i, j] = new Random().NextDouble();

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

Console.WriteLine("Введите количество строк");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int column = Convert.ToInt32(Console.ReadLine());
PrintArray(CreateTwoDimensionArray(line, column ));
