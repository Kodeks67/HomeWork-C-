// 1 Вид
bool palindrome(int num)
{
    if (num / 10000 == num % 10 && (num / 1000) % 10 == (num / 10) % 10)
    {
        return true;
    }
    return false;

        
}
Console.WriteLine(palindrome(int.Parse(Console.ReadLine())));


// 2 Вид 

bool PalindromeV2(string number)
{
    for (int i = 0; i < number.Length / 2; i++)
        if (number[i] != number[number.Length - i - 1])
            return false;
    return true;        
}
Console.WriteLine(PalindromeV2("1221"));
