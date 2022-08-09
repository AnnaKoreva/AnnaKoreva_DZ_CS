// 30 Написать программу вычисления произведения чисел от 1 до N
System.Console.WriteLine("Введите  число");
int n;
n=Convert.ToInt32((Console.ReadLine()));
int b=1;
int prod=1;
while(n>=b)
{
   
    prod*=b;
    b++;
}
System.Console.WriteLine(prod);