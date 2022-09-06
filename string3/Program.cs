//С клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки
string str = Console.ReadLine();
int count = 0;
for (int i = 0; i<str.Length;i++)
{
    if (str[i]!='.') 
    {
        count++;
    }
    else break;
}
System.Console.WriteLine(count);