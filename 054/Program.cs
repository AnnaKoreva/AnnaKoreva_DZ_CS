// Написать подпрограмму, которая в матрице чисел находит сумму элементов главной диагонали
System.Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во колонок: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,]arr=new int[m,n];
System.Console.WriteLine("Сформирован двумерный массив из случайных чисел от 1 до 10:");
for (int i =0;i<m;i++)
{
    for (int j = 0;j<n;j++)
    {
        arr[i,j]=new Random().Next(1,10);
        System.Console.Write($"{arr[i,j]}\t");
    }
    System.Console.WriteLine();
}
int sum=0;
for (int i =0;i<m && i<n;i++)
{
    sum+=arr[i,i];
}
System.Console.WriteLine($"Сумма всех элементов главной диагонали равна: {sum}");