// 34 Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
//Найти сумму положительных/отрицательных элементов массива
//Решение  с использованием функций 

int []ar;
Init(out ar, 12, -9,9);

int sum, sumtwo;
Solve(ar, out sum, out sumtwo);
Print(ar);
System.Console.WriteLine();
 System.Console.WriteLine($"Сумма положительнх чисел равна {sum}");
System.Console.WriteLine($"Сумма отрийательных чисел равна {sumtwo}");




// Функция ввода данных
      void Init(out int[] ar, int Length, int min, int max) // void (подпрограмма) нчиего не возвращает, Init - назание подпрограммы (можно указать любое), int[] ar - передали внутрь подпрограммы массив и его длинну которые назначили в вводе данных, int min и int max - аругменты для минимального и макстмального значения массива. Если написать int Length= 10 int min = 0, int max =10 это будут аргументы по умолчанию и в вводе данных не нужно будет их задавать, программа будет брать их из int Length= 10 иint min = 0 и int max =10
    {
        ar=new int[Length];
        Random random=new Random();// создали генератор случайных чисел и заполнили им массив
        for(int i=0; i<ar.Length;i++)
            ar[i]=random.Next(min,max+1); // указываем что массив может быть с любыми произвольными цифпами от 0 до 10 с учетом того что мах+1, если будет просто мах то числа будут от 0 до 9
    }
 
    
    //Функция вывода результатов
    void Print(int[] ar)
    {
        for(int i=0; i<ar.Length;i++)
        System.Console.Write($"{ar[i],4}");
    }


    void Solve(int [] ar, out int sum, out int sumtwo)
{
    sumtwo=0;
    sum=0;
    
    for(int i=0; i<ar.Length;i++)
        {
        if(ar[i]>=0)    sum = ar[i]+ sum;
        
        if(ar[i]<=0) sumtwo = ar[i]+ sumtwo;
        
        }

}
