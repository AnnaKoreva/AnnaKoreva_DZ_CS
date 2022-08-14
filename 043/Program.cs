// С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры
int N = Convert.ToInt32(Console.ReadLine());
int[]arr=new int[N];
int count=0;
for(int i=0;i<arr.Length;i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
    if (arr[i]>0) count++;
}
System.Console.WriteLine(count);