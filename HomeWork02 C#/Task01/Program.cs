int numberA = new Random().Next(100, 1000);
Console.WriteLine(numberA);

int del = (numberA / 10) % 10;
Console.WriteLine(del);


Console.WriteLine($"{del}");
