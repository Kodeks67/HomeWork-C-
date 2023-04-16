int[] CreateRndArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
        // array[i] = int.Parse(Console.ReadLine()); -- записывает в столбик числа массива 
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.WriteLine($"[{String.Join(", ", array)}]");
}

int leg = int.Parse(Console.ReadLine());
int minValue = int.Parse(Console.ReadLine());
int maxValue = int.Parse(Console.ReadLine());
int[] arr = CreateRndArray(leg, minValue, maxValue);
PrintArray(arr);