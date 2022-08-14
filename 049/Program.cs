// Показать двумерный массив размером m×n заполненный вещественными случайными числами
System.Console.Write("Укажите кол-во строк в массиве:\t\t");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите кол-во колонок в массиве:\t");
int n = Convert.ToInt32(Console.ReadLine());
double[,]arr=new double[m,n];
for (int i=0;i<m;i++)
{
    for (int z=0;z<n;z++)
    {
        arr[i,z] = new Random().NextDouble();
        System.Console.Write($"{arr[i,z]}\t");
    }
    System.Console.WriteLine();
}