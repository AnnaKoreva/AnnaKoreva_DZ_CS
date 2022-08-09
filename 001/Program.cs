// Вывести квадрат числа DOUBLE
System.Console.Write("Введите число, квадрат которого необходимо поулчить: ");
int a,b;
a=Convert.ToInt32((Console.ReadLine()));
b = a*a;
System.Console.WriteLine($"{a}^2 = {b}");