// Вывести на экран числа от -N до N
/*Console.Write("Введите число: ");
string x = Console.ReadLine();
int a=Convert.ToInt32(x);
int b=a;
while(0<a)
{
    Console.WriteLine($"-{a}");
    a--;
}
while(a<=b)
{
    Console.WriteLine(a);
    a++;
}*/
Console.Write("Введите число: ");
string x = Console.ReadLine();
int a=Convert.ToInt32(x);
int b=-a;
while(b<=a)
{
    Console.WriteLine(b);
    b++;
}