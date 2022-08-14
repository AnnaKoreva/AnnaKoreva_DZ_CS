// Написать программу, которая обменивает элементы первой строки и последней строки

int[,]arr=new int[5,6];
System.Console.WriteLine("Сформирован двумерный массив из случайных чисел от 1 до 10:");
for (int i =0;i<arr.GetLength(0);i++)
{
    for (int j = 0;j<arr.GetLength(1);j++)
    {
        arr[i,j]=new Random().Next(1,10);
        System.Console.Write($"{arr[i,j]}\t");
    }
    System.Console.WriteLine();
}
void exchangeFirstAndLastStroke (int[,] arr)
{
    int[,] arrCash=new int[arr.GetLength(0),arr.GetLength(1)];
    for(int i = 0; i<arr.GetLength(1);i++) // copy first stroke form arr to last stroke of arrCash
    {
        arrCash[arr.GetLength(0)-1,i] = arr[0,i];
    }
      for (int i = 0;i<arr.GetLength(1);i++) 
    {
        arr[0,i] = arr[arr.GetLength(0)-1,i]; // clone the last stroke of arr to first
        arr[arr.GetLength(0)-1,i] = arrCash[arr.GetLength(0)-1,i]; // copy the last stroke from arrCash to the last stroke of arr
    }
}
exchangeFirstAndLastStroke (arr);
System.Console.WriteLine();
for (int i =0;i<arr.GetLength(0);i++)
{
    for (int j = 0;j<arr.GetLength(1);j++)
    {
        System.Console.Write($"{arr[i,j]}\t");
    }
    System.Console.WriteLine();
}