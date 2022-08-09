// С клавиатуры вводятся три числа. Найти максимальное из трех чисел
Console.Write("Введите первое число: ");
string x = Console.ReadLine();
int a=Convert.ToInt32(x);
Console.Write("Введите второе число: ");
x = Console.ReadLine();
int b=Convert.ToInt32(x);
Console.Write("Введите второе число: ");
x = Console.ReadLine();
int c=Convert.ToInt32(x);
int max=a;
if (max<b){
    max=b;}
if (max<c){
    max=c;}
Console.Write($"Число {max} имеет набольше значение!");