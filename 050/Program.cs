// В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j])
System.Console.Write("Укажите кол-во строк в массиве:\t\t");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите кол-во колонок в массиве:\t");
int k = Convert.ToInt32(Console.ReadLine());
int[,]arr=new int[n,k];
for (int i=0;i<n;i++)
{
    for (int z=0;z<k;z++)
    {
        arr[i,z] = new Random().Next(1,10);
        System.Console.Write($"{arr[i,z]}\t");
    }
    System.Console.WriteLine();
}
for (int i=0;i<n;i++)
{
    for (int z=0;z<k;z+=2)
    {
        arr[i,z] = -arr[i,z];
    }
}
System.Console.WriteLine("=");
for (int i=0;i<n;i++)
{
    for (int z=0;z<k;z++)
    {
        System.Console.Write($"{arr[i,z]}\t");
    }
    System.Console.WriteLine();
}