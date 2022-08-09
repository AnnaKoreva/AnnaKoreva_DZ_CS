// 34 Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
//Найти сумму положительных/отрицательных элементов массива
int N=12; 
int []ar=new int[N];
Random random=new Random();
int sumtwo;
sumtwo=0;
int sum;
sum=0;
for(int i=0; i<ar.Length;i++)
   {
    ar[i]=random.Next(-9,10); 
    System.Console.WriteLine($"{ar[i]}");
   
   } 
for(int i=0; i<ar.Length;i++)
    {
      if(ar[i]>=0)    sum = ar[i]+ sum;
    
     if(ar[i]<=0) sumtwo = ar[i]+ sumtwo;
    
    }

 System.Console.WriteLine($"Сумма положительнх чисел равна {sum}");
System.Console.WriteLine($"Сумма отрийательных чисел равна {sumtwo}");