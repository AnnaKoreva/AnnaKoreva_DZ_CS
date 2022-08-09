// 36 Определить, присутствует ли в заданном массиве, некоторое число
//решение с подпрограммой
System.Console.Write("Введите число для проверки массива: ");
int checkNumber = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [10];
FillArray(arr);
Print(arr);
Check (arr,checkNumber);
void FillArray(int[] arr)
{
    for (int i=0;i<arr.Length;i++)
        arr[i] = new Random().Next(0,10);   
}
void Print(int[] arr)
{
    for (int i=0;i<arr.Length;i++)
        System.Console.Write($"{arr[i]} ");
}
void Check (int[] arr,int checkNumber)
{
    bool check = false;
    for (int i = 0; i<arr.Length;i++)
    {
        if (arr[i] == checkNumber) check = true;
    }
    System.Console.WriteLine();
    if (check)
    {
        System.Console.WriteLine("Совпадение найдено");
        return;
    }
    else
    {
        System.Console.WriteLine("Совпадений не найдено");
    }
}

   /* int N=4; 
int []ar=new int[N];
bool sp;
sp=false;
Random random=new Random();
for(int i=0; i<ar.Length;i++)
{
    ar[i]=random.Next(0,10);
    System.Console.WriteLine($"{ar[i]}");
}

for(int i=0; i<ar.Length;i++)
{
    if(ar[i]==5) 
    {
        sp=true;
    }    
}
if (sp==true)
{
    System.Console.WriteLine($"Совпадение найдено");
}
else
{
    System.Console.WriteLine($"Совпадений нет");
}*/
  



// как решил преподаватель 
/*int N=3;
int[] a=new int[N];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
{
    a[i]=random.Next(-9,10);
}

int number=400;
a[1]=number;
//Алгоритм линейного поиска
int j=0;
while (j<a.Length && a[j]!=number) j++;
if (j==a.Length) System.Console.WriteLine("No");
else System.Console.WriteLine($"Yes. {j}");

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");
System.Console.WriteLine(); */


/* как решила я 
int N=4; 
int []ar=new int[N];
bool sp;
sp=false;
Random random=new Random();
for(int i=0; i<ar.Length;i++)
{
    ar[i]=random.Next(0,10);
    System.Console.WriteLine($"{ar[i]}");
}

for(int i=0; i<ar.Length;i++)
{
    if(ar[i]==5) 
    {
        sp=true;
    }    
}
if (sp==true)
{
    System.Console.WriteLine($"Совпадение найдено");
}
else
{
    System.Console.WriteLine($"Совпадений нет");
}*/
    

 


