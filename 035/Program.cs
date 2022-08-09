// 35 Написать программу замены элементов массива на противоположные
    
//решение с подпрограммой
int []ar;
Init(out ar, 12, 0,100); //12 размер массива, 0 100 это диопазон чисел от 0 до 100(99) которые будут использованы в заполн массива
Print(ar);
Replacement (ar);
System.Console.WriteLine();
Print(ar);

        // Функция ввода данных
 void Init(out int[] ar, int Length, int min, int max) // void (подпрограмма) нчиего не возвращает, Init - назание подпрограммы (можно указать любое), int[] ar - передали внутрь подпрограммы массив и его длинну которые назначили в вводе данных, int min и int max - аругменты для минимального и макстмального значения массива. Если написать int Length= 10 int min = 0, int max =10 это будут аргументы по умолчанию и в вводе данных не нужно будет их задавать, программа будет брать их из int Length= 10 иint min = 0 и int max =10
    {
        ar=new int[Length];
        Random random=new Random();// создали генератор случайных чисел и заполнили им массив
        for(int i=0; i<ar.Length;i++)
            ar[i]=random.Next(min,max+1); //т.к. max+1 в массив входит число 2
   
    }

void Replacement (int [] ar)
    {
     for(int i=0; i<ar.Length;i++)  ar[i]= -ar[i];
    }
    
        //Функция вывода результатов
 void Print(int[] ar)
    {
        for(int i=0; i<ar.Length;i++)
        System.Console.Write($"{ar[i],4}");
    }

    /*int n=12; 
int []ar=new int[n];
Random random=new Random();
for(int i=0; i<ar.Length;i++)
{
     ar[i]=random.Next(0,100);
     ar[i]= -ar[i];
     System.Console.Write($"{ar[i],4}");
}

 */