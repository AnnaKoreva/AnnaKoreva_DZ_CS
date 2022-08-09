// С клавиатуры вводятся два числа a и b. Найти максимальное из них.
Console.Write("Введите первое число: ");
string x = Console.ReadLine();
int a=Convert.ToInt32(x);
Console.Write("Введите второе число: ");
x = Console.ReadLine();
int b=Convert.ToInt32(x);
int max;
if (a>b){
    max=a;
}
else{
max=b;
}
Console.Write($"Число {max} имеет набольше значение!");