// Написать программу копирования массива
int[] arr=new int[10];
for (int i = 0; i< arr.Length;i++)
{
    arr[i]=new Random().Next(1,10);
    System.Console.Write($"{arr[i]}\t");
}
int[]arr2=new int[10];
System.Console.WriteLine("");
for (int i = 0; i< arr.Length;i++)
{
    arr2[i]=arr[i];
    System.Console.Write($"{arr2[i]}\t");
}