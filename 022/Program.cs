// 23 Программа проверяет пятизначное число на палиндромом.
System.Console.WriteLine("Введите пятизначное число");
int a;
a=Convert.ToInt32((Console.ReadLine()));

if ((a/10000)== (a%10) && (a/1000%10) == (a/10%10%10%10))
{
    System.Console.WriteLine(" число вляется паландромом");

}
else
{
   System.Console.WriteLine(" число не вляется паландромом");
} 

/*System.Console.WriteLine(a/10000); // чтобы получить в остатке 1 от числа 12345
System.Console.WriteLine(a/1000%10); // чтобы получить в остатке 2 от числа 12345
System.Console.WriteLine(a/100%10%10); // чтобы получить в остатке 3 от числа 12345
System.Console.WriteLine(a/10%10%10%10);// чтобы получить в остатке 4 от числа 12345
System.Console.WriteLine(a%10); // чтобы получить в остатке 5 от числа 12345*/