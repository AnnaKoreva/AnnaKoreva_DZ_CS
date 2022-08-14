// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
int [][] arr = new int[n][];
arr[0] = new int [] {1};
for (int i=1;i<arr.Length;i++)
{
    arr[i]= new int [i+1];
    for(int j=0; j<=i;j++)
    if (j==0 || j ==i) arr[i][j] = 1;
    else arr[i][j] = arr[i-1][j-1] + arr[i-1][j];
}
for (int i = 0; i < arr.Length; i++)
{
    PrintTab (arr.Length-i);
    for (int j = 0; j < arr[i].Length; j++)
    {
        Console.Write("{0,-3} ", arr[i][j]); // была запись из инета Console.Write("{0,-3} ", arr[i][j]);
    }
    Console.WriteLine();
}
void PrintTab (int z)
{
    System.Console.Write("  ");
    z--;
    if (z==0) return;
    PrintTab (z);
}

