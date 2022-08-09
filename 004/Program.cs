// По заданному с клавиатуры номеру дня недели вывести его название

int n;
Console.WriteLine( "Введите порядковый номер дня недели");
n=Convert.ToInt32((Console.ReadLine())); // n=int.Parse(Console.ReadLine());


/*if(n==1)
{
    Console.WriteLine("Понедельник");
}
if(n==2)
{
    Console.WriteLine("Вторник");
}
if(n==3)
{
    Console.WriteLine("Среда");
}
if(n==4)
{
    Console.WriteLine("Четверг");
}
if(n==5)
{
    Console.WriteLine("Пятница");
}

if(n==6)
{
    Console.WriteLine("Суббота");
}

if(n==7)
{
    Console.WriteLine("Воскресенье");
} */
switch(n)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
     case 7:
        Console.WriteLine("Восересенье");
        break;
    default:                                                 //если ничего не подошло или цифра указана неверно
        Console.WriteLine("Неверно указан номер дня");
        break;
}