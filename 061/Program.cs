// Найти произведение двух матриц

int[,]arr1;
int[,]arr2;
FillArray(out arr1,2,3);
FillArray(out arr2,3,4);
Print2D(arr1);
Print2D(arr2);
ArrayProd (arr1, arr2);

void FillArray(out int[,] arr, int strokes, int columns)
{
    arr=new int[strokes,columns];
    for (int i=0;i<strokes;i++)
    {
        for (int j = 0;j<columns;j++)
        {
            arr[i,j]=new Random().Next(1,10);
        }
    }
}
void Print2D(int[,] arr)
{
    for (int i =0;i<arr.GetLength(0);i++)
    {
        for (int j = 0;j<arr.GetLength(1);j++)
        {
            System.Console.Write($"{arr[i,j]}  ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
void ArrayProd (int[,] arr1, int[,] arr2)
{
    int[,] arrProd = new int[arr1.GetLength(0),arr2.GetLength(1)];
    if (arr1.GetLength(0) != arr2.GetLength(1)) System.Console.WriteLine("Невозможно перемножить матрицы");
    for(int i = 0; i<arr1.GetLength(0);i++)
    {
        for (int j = 0; j<arr2.GetLength(1);j++)
        {
            for (int k = 0; k<arr1.GetLength(1);k++) // k<arr1.GetLength(1) - либо кол-во столбцов массива А, либо кол-во строк массива Б
            {
                arrProd[i,j]+=arr1[i,k]*arr2[k,j];
            }
        }
    }
    for (int i =0;i<arrProd.GetLength(0);i++)
    {
        for (int j = 0;j<arrProd.GetLength(1);j++)
        {
            System.Console.Write($"{arrProd[i,j]}  ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();        
}