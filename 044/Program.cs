// Написать программу преобразования десятичного числа в двоичное
int a = Convert.ToInt32(Console.ReadLine());
void denaryToBinary (int denaryValue)
{
    if (denaryValue==0) System.Console.WriteLine(0);
    int[] arr=new int [32];
    int i=0;
    while (denaryValue>0)
    {
        arr[i] = denaryValue%2;
        denaryValue/=2;
        i++;
    }
    for (int j=i-1;j>=0;j--)
    {
        System.Console.Write(arr[j]);
    } 
}
denaryToBinary (a);