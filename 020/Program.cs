// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
/*System.Console.WriteLine("Введите x,y");
int x;
int y;
x=Convert.ToInt32((Console.ReadLine()));
y=Convert.ToInt32((Console.ReadLine()));
if (x>0 && y>0)
{
    System.Console.WriteLine("точка с координатами x,y находится в I четверти плоскости");
}
if (x<0 && y>0)
{
    System.Console.WriteLine("точка с координатами x,y находится вo II четверти плоскости");
}
if (x<0 && y<0)
{
    System.Console.WriteLine("точка с координатами x,y находится вo III четверти плоскости");
}

if (x>0 && y<0)
{
    System.Console.WriteLine("точка с координатами x,y находится вo IV четверти плоскости");
}
*/

//Как решил преподаватель
int AreaN(double x, double y)
{
   if (x>0 && y>0) return 1;
   if (x<0 && y>0) return 2;
   if (x<0 && y<0) return 3;
   if (x>0 && y<0) return 4;
   return 0;
}
int x=40, y=5;
System.Console.WriteLine(AreaN(x,y));