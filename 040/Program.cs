/*40 Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. 
Создайте массив, который является произведением пар чисел в одномерном массиве a. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д*/
// решение с подпрограммой
int[] arr = new int [10];
FillArray(arr);
Print(arr);
ArrayPairProd (arr);

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
void ArrayPairProd (int[] arr)
{
    int end = (arr.Length-1);
    int[] arrProd=new int[arr.Length/2];
    System.Console.WriteLine("Массив №2 (произведение пар из Массива №1)");
    for(int i=0;i<arrProd.Length;i++)
    {
        arrProd[i]=arr[i]*arr[end];
        end--;
        System.Console.Write($"{arrProd[i]}\t");
    }    
}


/* как решил преподаватель
int N=9;
int[] a=new int[N];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(1,11);

int[] b=new int[N/2];

for(int i=0;i<a.Length/2;i++)
{
    System.Console.WriteLine($"{a[i]} {a[a.Length-i-1]}");
    b[i]=a[i]*a[a.Length-i-1];
}

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");
System.Console.WriteLine();

for(int i=0;i<b.Length;i++)
    System.Console.Write($"{b[i],4}");
System.Console.WriteLine();*/


/* как решила я 
int n=Convert.ToInt32(Console.ReadLine());
int []ar=new int[n];
Random random=new Random();
for(int i=0; i<ar.Length;i++)
{
    ar[i]=random.Next(1,10); 
}


int [] artwo= new int[n/2];
int last= n-1;
for(int a=0; a<artwo.Length; a++)
{
    artwo[a] = ar[a] * ar [last];
    last--;
    System.Console.WriteLine(artwo[a]);
}
*/
