int MethodAkkermana(int n, int m)
{
    if (n == 0) return m + 1;
    else if (n != 0 && m == 0) return MethodAkkermana(n - 1, 1);
    else if (n > 0 && m > 0) return MethodAkkermana(n - 1, MethodAkkermana(n, m - 1));
    return 1;
}
System.Console.WriteLine(MethodAkkermana(3, 2));