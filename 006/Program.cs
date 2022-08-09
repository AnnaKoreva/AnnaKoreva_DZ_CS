// Написать программу вычисления значения функции y = sin(a). (Класс Math)

double x=Math.PI;
double y=Math.Sin(x);
double y1=Math.Sin(x*2);
Console.WriteLine($"{y:G}");
Console.WriteLine(9.0/10000000.0);

if (Math.Abs(y-y1)<= 1E-10) Console.WriteLine("OK");
else Console.WriteLine("Wrong");
