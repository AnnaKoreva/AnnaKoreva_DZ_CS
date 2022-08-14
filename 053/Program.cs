// Написать подпрограмму, поиска элемента в двумерном массиве, подпрограмма возвращает позицию числа.
// Если элемент отсутствует, подпрограмма возвращает -1.

int Check (int[,] Array,int checkValue)
{
    bool check = false; 
    int match=0;
    for (int i =0;i<5;i++)
{
    for (int j = 0;j<6;j++)
    {
        if (Array[i,j]==checkValue)
        {
            check=true;
            System.Console.WriteLine($"Число {checkValue} найдено в двумерном масиве с идексами i={i} и j={j}");
            match++;
        }
    }
}
if (!check) return -1;
else {System.Console.Write("Кол-во совпадений: "); return match;}
}
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
System.Console.Write("Введите число для поиска его индексов в двумерном массиве: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Check(arr,a));
