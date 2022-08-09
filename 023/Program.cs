// 23 Найти расстояние между точками в пространстве 2D
 
double Distance(double x1, double y1, double x2, double y2) // тут могуть бы указаны любые переменные вместо х1, у1, х2,у2
{
    double d; // задаем новую переменную
    d=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y1-y2,2)); // Math.Sqrt - расчет квадратного корня из числа которое получится по итогу расчтета Math.Pow, а Math.Pow - возведение числа в степень, в данном случае во вторую (2)
    return d;
}

double x1=0, y1=0, x2=10, y2=10;
System.Console.WriteLine(Distance(x1, y1, x2, y2));
