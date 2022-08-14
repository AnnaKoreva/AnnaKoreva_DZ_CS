// Показать числа Фибоначчи
int [] arr = new int[32];
arr[0]=0;
arr[1]=1;
for (int i = 2;i<arr.Length;i++)
{
    arr[i]=arr[i-2]+arr[i-1];
}
for (int i = 0;i<arr.Length;i++)
{
    System.Console.Write($"{arr[i]} ");
}