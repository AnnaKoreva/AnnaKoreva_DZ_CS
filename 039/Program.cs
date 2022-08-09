// 39 Найти сумму чисел одномерного массива стоящих на нечетной позиции
// решение с подпрограммой

int []ar;
Init(out ar, 5, 0,10); 
Nposition(ar, out int sum);
Print(ar);
System.Console.WriteLine();
System.Console.WriteLine($"Суммы чисел стоящих на нечетной позиции равна {sum}"); 

        // Функция ввода данных
 void Init(out int[] ar, int Length, int min, int max) 
   {
        ar=new int[Length];
        Random random=new Random();
        for(int i=0; i<ar.Length;i++)
            ar[i]=random.Next(min,max+1); 
    }

void Nposition(int [] ar, out int sum)
{
    sum=0;
    for(int i=1;i<ar.Length;i=i+2) sum=sum+ar[i];
 
}
        
        //Функция вывода результатов
 void Print(int[] ar)
    {
        for(int i=0; i<ar.Length;i++)
        System.Console.Write($"{ar[i],4}");
    }


/* решение преподователя
int N=4;
int[] a=new int[N];
Random random=new Random();//псевдослучайные числа
for (int i=0;i<a.Length;i++)
    a[i]=random.Next(0,11);

for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");

int sum=0;
for(int i=1;i<a.Length;i=i+2)
    
    sum=sum+a[i]; // либо sum+=a[i];
System.Console.WriteLine();
System.Console.WriteLine(sum);   */


/* как решила я int n=20; 
int []ar=new int[n];
int sum=0;
Random random=new Random();
for(int i=0; i<ar.Length;i++)
{
    ar[i]=random.Next(10,100); 
      
    if(ar[i]%2!=0) 
    {
        sum=sum+ar[i];
        ar[i]++;
    }

}
  
System.Console.WriteLine($"суммa чисел стоящих на нечетной позиции\t{sum}");
*/
