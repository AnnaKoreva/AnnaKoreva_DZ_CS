// Создать подпрограмму Create2DArray(m,n), которая возвращает двумерный массив следующим правилом: 
// Arrayij = i+j, где i и j - индексы элементов массива, а m и n - размеры массива

void Create2DArray (int m, int n)
{
    int[,] arr=new int [m,n];
    for (int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            arr[i,j] = i+j;
            System.Console.Write($"{arr[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}
System.Console.Write("Укажите кол-во строк в массиве:\t\t");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите кол-во колонок в массиве:\t");
int n = Convert.ToInt32(Console.ReadLine());
Create2DArray (m,n);