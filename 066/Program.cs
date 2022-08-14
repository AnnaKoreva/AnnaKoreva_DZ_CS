// Показать натуральные числа от 1 до N, N задано

int n = 10;
Show (n);

void Show (int n)
{
    if (n>1) Show(n-1);
    System.Console.WriteLine(n);  
}
