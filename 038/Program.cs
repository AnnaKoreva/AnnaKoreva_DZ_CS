// 38 В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int []ar;
Init(out ar, 123, 0,100); 
Quantity (ar, out int ind);
Print(ar);
System.Console.WriteLine();
System.Console.WriteLine($"Количество элементов на отрезке 10,99 равно  {ind}");



        // Функция ввода данных
 void Init(out int[] ar, int Length, int min, int max) 
   {
        ar=new int[Length];
        Random random=new Random();
        for(int i=0; i<ar.Length;i++)
            ar[i]=random.Next(min,max+1); 
    }

void Quantity(int [] ar, out int ind)
{
   ind=0;
     for(int i=0; i<ar.Length;i++)
     if(ar[i]>=10 && ar[i] <=99) ind++;
 
}
        
        //Функция вывода результатов
 void Print(int[] ar)
    {
        for(int i=0; i<ar.Length;i++)
        System.Console.Write($"{ar[i],4}");
    }




/*int n=123; 
int []ar=new int[n];
int ind=0;
Random random=new Random();
for(int i=0; i<ar.Length;i++)
{
     ar[i]=random.Next(0,1000);
     if(ar[i]>=10 && ar[i] <=99)
     {
        ind++;
     }
}
System.Console.WriteLine($"Количество элементов {ind}"); */
