// Написать программу вычисления функции Аккермана - 5*
int m = 3;
int n = 3;
System.Console.WriteLine(A(m,n));
int A(int m, int n)
{
    if (m==0) return n+1;
    if (n==0) return A(m-1,1);
    return A(m-1,A(m,n-1));    
}
