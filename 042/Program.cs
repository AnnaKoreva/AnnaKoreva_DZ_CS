// Выяснить являются ли три числа сторонами треугольника
// При помощи массива и функции
void triangle (ref int a, ref int b, ref int c)
{
    if (a+b>c) 
    {
        if (b+c>a)
        {
            if (c+a>b) System.Console.WriteLine("a, b, c - являются сторонами треуголника");
            else System.Console.WriteLine("a, b, c - НЕ являются сторонами треуголника");
        }
        else System.Console.WriteLine("a, b, c - НЕ являются сторонами треуголника");
    }
    else System.Console.WriteLine("a, b, c - НЕ являются сторонами треуголника");
}
int [] arr = new int [3];
for (int i = 0;i<arr.Length;i++)
{
    arr[i]=new Random().Next(0,20);
    System.Console.WriteLine(arr[i]);
}
triangle (ref arr[0], ref arr[1], ref arr[2]);
