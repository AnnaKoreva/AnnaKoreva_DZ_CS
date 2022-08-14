// Спирально заполнить двумерный массив
int strokes = 15;
int columns = 5;
int[,] arr=new int[strokes,columns];
int z=1;
for (int i=0;z<=strokes*columns;i++) // arr.GetLength(0)
{  
        for (int ltr=i;ltr<arr.GetLength(1)-i-1 && z<=strokes*columns;ltr++) /* без && z<=strokes*columns код будет работать
        неправильно, например в матрице 10*7 центральая строка перезапишется новыми 71+, хотя 70 это макс зн.*/
        arr[i,ltr] = z++;
        for (int ttb = i;ttb<arr.GetLength(0)-i-1 && z<=strokes*columns;ttb++)
        arr[ttb,arr.GetLength(1)-i-1] = z++;   
        for (int rtl=arr.GetLength(1)-i-1;rtl-i>0 && z<=strokes*columns;rtl--) 
        arr[arr.GetLength(0)-i-1,rtl] = z++;  
        for (int btt = arr.GetLength(0)-i-1;btt-i>0 && z<=strokes*columns;btt--) 
        arr[btt,i] = z++;
}
Print2D(arr);
System.Console.WriteLine();
void Print2D(int[,] arr)
{
    for (int i =0;i<arr.GetLength(0);i++)
    {
        for (int j = 0;j<arr.GetLength(1);j++)
        {
            System.Console.Write($"{arr[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}