// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная)

int[,]arr=new int[5,5];
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
System.Console.WriteLine("\n");
void StrokeToColumn (int[,] arr)
{
    if (arr.GetLength(0)!=arr.GetLength(1)) System.Console.WriteLine("Невозможно обменять строки на столбцы - массив не является квадратным");
    else
    {
        int[,] arrCash = new int [arr.GetLength(0),arr.GetLength(1)];
        for (int i = 0;i<arr.GetLength(0);i++)
        {
            for (int j = 0;j<arr.GetLength(1);j++)
            {
                arrCash[i,j]=arr[i,j];
            }
        }
        for (int i = 0;i<arr.GetLength(0);i++)
        {
            for (int j = 0;j<arr.GetLength(1);j++)
            {
                arr[i,j] = arrCash[j,i];
            }
        }
    }
}
StrokeToColumn(arr);
System.Console.WriteLine("Сформирован двумерный массив из случайных чисел от 1 до 10:");
for (int i =0;i<arr.GetLength(0);i++)
{
    for (int j = 0;j<arr.GetLength(1);j++)
    {
        System.Console.Write($"{arr[i,j]}\t");
    }
    System.Console.WriteLine();
}
