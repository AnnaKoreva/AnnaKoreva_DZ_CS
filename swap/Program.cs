// меняем переменные местами
/*void Swap(ref int a, ref int b) //идентификатор reference (ref) для изменения значения передаваемой переменной в ref будет хранится адрес ячейки
{
    int t=a;
    a=b;
    b=t;
}
int a= 1;
int b= 2;
System.Console.WriteLine($"a={a} b={b}");
Swap(ref a, ref b);
System.Console.WriteLine("a={a} b={b}"); */

//out 
void Calculate(int a, int b, out int sum, out int sub) // out пишется для того чтобы переменным sum sub не были присвоены какие-либо значения
{
    sum=a+b;
    sub=a-b;
}
int sum, sub;
Calculate(2,2,out sum,out  sub);
System.Console.WriteLine ($"{sum} & {sub}");