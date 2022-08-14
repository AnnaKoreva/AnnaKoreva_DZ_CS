// Найти сумму цифр числа
int a = 12345;
System.Console.WriteLine(SumOfValue(a));

int SumOfValue (int a)
{
    if (a!=0) return a%10 + SumOfValue(a/10);
    else return 0;
}
