// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.
System.Console.Write("Укажите кол-во строк в массиве:\t\t");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите кол-во колонок в массиве:\t");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr=new int [m,n];
    for (int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            arr[i,j] = new Random().Next(1,10);
            System.Console.Write($"{arr[i,j]}\t");
        }
        System.Console.WriteLine();
    }
    for (int i=0;i<m;i+=2)
    {
        for(int j=0;j<n;j+=2)
        {
            arr[i,j] = Convert.ToInt32(Math.Pow(arr[i,j],2));
            
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine("=");
for (int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            System.Console.Write($"{arr[i,j]}\t");
        }
        System.Console.WriteLine();
    }