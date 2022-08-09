// 31 Показать кубы чисел, заканчивающихся на четную цифру

System.Console.Write("Введите число:\t");
int n;
n=Convert.ToInt32((Console.ReadLine()));
int b=0;
for (int a=1; a<=n; a++)
{

 b=Convert.ToInt32(Math.Pow(a,3));
 if(b%2==0)
 {
    System.Console.WriteLine($"{b}\t");
 }
 
}
