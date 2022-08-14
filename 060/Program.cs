// Составить частотный словарь элементов двумерного массива состоящих из чисел от 0 до 99.
int[,] arr;
FillArray2D(out arr,22,35);
Print2D(arr);
Dictionary (arr);
// Print2D(arr); // для сверки
void FillArray2D(out int[,] arr, int strokes, int columns)
{
    arr=new int[strokes,columns];
    for (int i=0;i<strokes;i++)
    {
        for (int j = 0;j<columns;j++)
        {
            arr[i,j]=new Random().Next(0,100);
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
void Dictionary (int[,] arr)
{   
    for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            if (arr[i,j]!=100)
            {
                int check = arr[i,j];
                int count = 0;
                for (int x=0;x<arr.GetLength(0);x++)
                {
                    for (int z=0;z<arr.GetLength(1);z++)
                    {
                        if (arr[x,z]==check) 
                        {
                            count++;
                            arr[x,z] = 100;
                        }
                    }
                }
                System.Console.WriteLine($"Число {check} встречается {count} раз");
            }
        }
    }
}