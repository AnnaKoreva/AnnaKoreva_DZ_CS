// 24 Вывести на экран таблицу квадратов чисел от 1 до N

System.Console.Write("Введите число:\t");
int n;
n=Convert.ToInt32((Console.ReadLine()));

int b=0;
for (int a=1; a<=n; a++)
{

 b=Convert.ToInt32(Math.Pow(a,2));

 System.Console.WriteLine($"{b}\t");
}


    


