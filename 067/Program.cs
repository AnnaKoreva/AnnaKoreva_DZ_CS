// Показать натуральные числа от N до 1, N задано

int n = 10;
ShowReverse (n);
void ShowReverse (int n)
{
    System.Console.WriteLine(n);
    if (n>1) ShowReverse (n-1);
}
