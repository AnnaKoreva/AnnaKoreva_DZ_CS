// 26 Найти сумму чисел от 1 до А
System.Console.Write("Введите число:\t");
int A;
A=Convert.ToInt32((Console.ReadLine()));

int sum=0;
for (int n=1; n<=A; n++)
{
sum=sum+n;
}
System.Console.WriteLine($"{sum}\t");