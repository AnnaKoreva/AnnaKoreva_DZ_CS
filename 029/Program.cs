// 29 Подсчитать сумму цифр в числе
System.Console.WriteLine("Введите  число");
int a;
a=Convert.ToInt32((Console.ReadLine()));
int sum =0;
while(a>0)
{
    int b;
    b=a%10;
    a=a/10;
    
  sum=sum+b;
}
System.Console.WriteLine($"Количество цифр в числе:{sum}"); 



