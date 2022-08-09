// Дано число больше 9. Вывести на экран  вторую цифру числа с конца
System.Console.Write("Введите число больше 9: ");
int a;
a=Convert.ToInt32((Console.ReadLine()));
System.Console.WriteLine((a/10)%10);
