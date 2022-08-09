// 41 В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
// решение через функции
/* double []ar;
InitDoubles(out ar,2);
double min, max;
FindMinMax(ar, out min, out max);
Print(ar);
System.Console.WriteLine();
System.Console.WriteLine(max-min);

void InitDoubles(out double[] ar, int Length=10, int min=0, int max=100) // из-за того что мы ниже делим на 10.0(ar[i]=random.Next(min,max+1)/10.0;) мах в реальности равен 10, а не 100
{   ar=new double[Length];
    Random random=new Random();// создали генератор случайных чисел и заполнили им массив
    for(int i=0; i<ar.Length;i++)
         ar[i]=random.Next(min,max+1)/10.0;//делим на 10.0 чтобы у нас были именно вещественные числа 
}
 
 void FindMinMax(double[] ar, out double min, out double max)
 {
     max=ar[0];
     min=ar[0];

    for(int i=1; i<ar.Length;i++)
    {
        if(max<ar[i]) max=ar[i];
        if(min>ar[i]) min=ar[i];
    }
    
 }
    
    //Функция вывода результатов
    void Print(double[] ar)
    {
        for(int i=0; i<ar.Length;i++)
        System.Console.Write($"{ar[i],4}");
    } */

    //Считываем данные из посторонних источников 
    using   System;
double []ar;
//InitDoubles(out ar,2);
string s=Console.ReadLine(); // считывам строку
string[] ss= s.Split(' ');// превращаем строку к массиву строк путем обращения к методу Split и указываем что разделитем явдяется пробел
ar=Array.ConvertAll<string,double>(ss, Convert.ToDouble);// каждую строчку конвертируем в массив double через класс Array, функцию ConvertAll, указваем массив строк и с помощью какого метода каждую строчку мы будем конвертировать (Convert.ToDouble)

double min, max;
FindMinMax(ar, out min, out max);
Print(ar);
System.Console.WriteLine();
System.Console.WriteLine(max-min);

void InitDoubles(out double[] ar, int Length=10, int min=0, int max=100) // из-за того что мы ниже делим на 10.0(ar[i]=random.Next(min,max+1)/10.0;) мах в реальности равен 10, а не 100
{   ar=new double[Length];
    Random random=new Random();// создали генератор случайных чисел и заполнили им массив
    for(int i=0; i<ar.Length;i++)
         ar[i]=random.Next(min,max+1)/10.0;//делим на 10.0 чтобы у нас были именно вещественные числа 
}
 
 void FindMinMax(double[] ar, out double min, out double max)
 {
     max=ar[0];
     min=ar[0];

    for(int i=1; i<ar.Length;i++)
    {
        if(max<ar[i]) max=ar[i];
        if(min>ar[i]) min=ar[i];
    }
    
 }
    
    //Функция вывода результатов
    void Print(double[] ar)
    {
        for(int i=0; i<ar.Length;i++)
        System.Console.Write($"{ar[i],4}");
    }


