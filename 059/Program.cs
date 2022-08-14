// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,]arr=new int[5,6];
System.Console.WriteLine("Сформирован двумерный массив из случайных чисел от 1 до 10:");
for (int i =0;i<5;i++)
{
    for (int j = 0;j<6;j++)
    {
        arr[i,j]=new Random().Next(1,10);
        System.Console.Write($"{arr[i,j]}\t");
    }
    System.Console.WriteLine();
}
void MinSumStoke(int[,]arr)
{
    
    int sumMin=0;
    int strokeMin=0;
    for (int i = 0;i<arr.GetLength(1);i++)
    {
        sumMin+=arr[0,i];
    }
    System.Console.WriteLine(sumMin);

    for (int i = 1;i<arr.GetLength(0);i++)
    {
        int sum=0;
        for (int j = 0;j<arr.GetLength(1);j++)
        {
            sum+=arr[i,j];
        }
        System.Console.WriteLine(sum);
        if (sumMin>sum)
        {
            sumMin=sum;
            strokeMin = i;
        } 
    }
    System.Console.WriteLine($"Наименьшая сумма всех элементов находится в строке {strokeMin} и равна {sumMin}");
}
MinSumStoke(arr);