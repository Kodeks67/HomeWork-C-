double Dist()
{  
Console.WriteLine("Введите А(x, y, z)");
double numA_x = double.Parse (Console.ReadLine());
double numA_y = double.Parse (Console.ReadLine());
double numA_z = double.Parse (Console.ReadLine());
Console.WriteLine("Введите Б(x, y, z)");
double numB_x = double.Parse (Console.ReadLine());
double numB_y = double.Parse (Console.ReadLine());
double numB_z = double.Parse (Console.ReadLine());
double result = Math.Sqrt(Math.Pow(numA_x - numB_x, 2) + Math.Pow(numA_y - numB_y, 2) + Math.Pow(numA_z - numB_z, 2));
return result;
}
Console.WriteLine(Dist());