﻿// 28 Определить количество цифр в числе. Сделать подпрограмму.
System.Console.Write("Введите число ");
int n;
n=Convert.ToInt32(Console.ReadLine());
int Prog (int n) // НАЗВАНИЕ ПОДПРОГРАММЫ
{   // НАЧАЛО ПОДПРОГРАММЫ
if (n==0) return 1; // если n будет равняться 0, то на экран сразу выведется 1, если не указать это отдельно, программа не будет работать с 0
 int k=0;
     while(n!=0) //ЦИКЛ
    {
    
      n= n/10; // либо n/10;
     k++; // либо k= k+1
    
     }
return k; //ВОЗВРАТ
}  //КОНЕЦ ПОДПРОГРАММЫ
    Console.Write(Prog(n));

