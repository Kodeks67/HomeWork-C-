bool palindrome(int num)
{
    if (num / 10000 == num % 10 && (num / 1000) % 10 == (num / 10) % 10)
    {
        return true;
    }
    return false;

        
}
Console.WriteLine(palindrome(int.Parse(Console.ReadLine())));
