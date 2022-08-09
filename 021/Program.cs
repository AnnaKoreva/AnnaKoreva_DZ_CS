// 21 Задать номер четверти, показать диапазоны для возможных координат
System.Console.WriteLine("Введите значение четверти: 1, 2, 3  или 4");
int a;
a=Convert.ToInt32((Console.ReadLine()));
if (a == 1)
{
    System.Console.WriteLine(" Диопазон возможных координат x>0,  y>0");
}
if (a == 2)
{
    System.Console.WriteLine("Диопазон возможных координат x<0,  y>0");
}
if (a == 3) 
{
    System.Console.WriteLine("Диопазон возможных координат x<0, y<0");
}

if  (a == 4)
{
    System.Console.WriteLine("Диопазон возможных координатx>0  y<0");
}
