// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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
System.Console.WriteLine();
for (int j = 0;j<6;j++)
{
    int average=0;
    for (int i =0;i<5;i++)
    {
        
        average+=arr[i,j];
    }
    System.Console.Write($"{average}\t");  
}


