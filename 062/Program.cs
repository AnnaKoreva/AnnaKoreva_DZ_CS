// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int[,] arr;
FillArray2D(out arr,5,4);
Print2D(arr);
System.Console.WriteLine();
DelMin (arr);
void DelMin (int[,] arr)
{
    int min = arr[0,0];
    int minStr=0,minCol=0;
    for (int i =0;i<arr.GetLength(0);i++)
    {
        for (int j = 0;j<arr.GetLength(1);j++)
        {
            if (min>arr[i,j])
            { 
                min=arr[i,j];
                minStr=i;
                minCol=j;
            }
        }
    }    

    int[,] arrDel=new int[arr.GetLength(0)-1,arr.GetLength(1)-1];
    for (int i =0,x=0;i<arrDel.GetLength(0);i++,x++)
    {
        if (i==minStr) x++;
        for (int j = 0,y=0;j<arrDel.GetLength(1);j++,y++)
        {
            if (j==minCol) y++;
            arrDel[i,j] = arr [x,y];            
        }
    }       
    Print2D(arrDel);
}
void FillArray2D(out int[,] arr, int strokes, int columns)
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
}