// Показать натуральные числа от M до N, N и M заданы
int m=3,n = 10;
ShowM2N(m,n);
void ShowM2N (int m, int n)
{
    m++;
    System.Console.WriteLine(m);
    if (m!=n-1) ShowM2N(m,n);
}