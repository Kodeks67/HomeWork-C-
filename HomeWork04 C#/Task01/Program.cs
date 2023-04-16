int NaturalDegree(int first_number, int second_number)
{
    int result = 1;
    for (int i = 1; i <= second_number; i++)
    {
        result = result * first_number;
    }
    return result;
}
Console.WriteLine(NaturalDegree(5, 4));