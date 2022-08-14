// Показать натуральные числа от M до N, N и M заданы
int m=3,n = 10;
System.Console.WriteLine(ShowM2N(m,n));
int ShowM2N (int m, int n)
{    
    m++;
    System.Console.WriteLine(m);
    if (m==n-1) return m;
    return m+ShowM2N(m,n);    
}
