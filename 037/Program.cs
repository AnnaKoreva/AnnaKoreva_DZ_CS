/* 37 Задать массив, заполнить случайными положительными трёхзначными числами. 
Показать количество нечетных\четных чисел */
//решение с подпрограммой

int []ar;
int  ind, indtwo;
Init(out ar, 2, 100,1000); 
Even(ar, out ind, out indtwo);
Print(ar);
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных числел {ind}");
System.Console.WriteLine($"Количество нечетных числел {indtwo}");

        // Функция ввода данных
 void Init(out int[] ar, int Length, int min, int max) // void (подпрограмма) нчиего не возвращает, Init - назание подпрограммы (можно указать любое), int[] ar - передали внутрь подпрограммы массив и его длинну которые назначили в вводе данных, int min и int max - аругменты для минимального и макстмального значения массива. Если написать int Length= 10 int min = 0, int max =10 это будут аргументы по умолчанию и в вводе данных не нужно будет их задавать, программа будет брать их из int Length= 10 иint min = 0 и int max =10
    {
        ar=new int[Length];
        Random random=new Random();// создали генератор случайных чисел и заполнили им массив
        for(int i=0; i<ar.Length;i++)
            ar[i]=random.Next(min,max+1); //т.к. max+1 в массив входит число 2
 
    }
void Even (int[] ar, out int ind, out int indtwo)
{   ind=0;
    indtwo =0;
    for(int i=0; i<ar.Length;i++)
    {
        if (ar[i]%2==0) ind++;
            
        if(ar[i]%2!=0) indtwo++;
    }
}

        //Функция вывода результатов
 void Print(int[] ar)
    {
        for(int i=0; i<ar.Length;i++)
        System.Console.Write($"{ar[i],4}");
    }
    



/*int n=12; 
int []ar=new int[n];
int ind = 0;
int indtwo =0;
Random random=new Random();
for(int i=0; i<ar.Length;i++)
{
    ar[i]=random.Next(100,1000); 
    if (ar[i]%2==0) 
    {
        ind++;
    }
        
    if(ar[i]%2!=0) 
    {
        indtwo++;
    }

}
  
System.Console.WriteLine($"Количество четных числел {ind}");
System.Console.WriteLine($"Количество нечетных числел {indtwo}");*/
