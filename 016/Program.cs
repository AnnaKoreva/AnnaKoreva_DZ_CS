// 16 Дано число. Проверить кратно ли оно 7 и 23

int a=161;
bool b=a%7==0 && a%23==0; //выясняем чвляется ли число кратно 7 и 23, если да то будет True
System.Console.WriteLine(b);
if (b)
{
    System.Console.WriteLine("Кратно");
}
else {
    System.Console.WriteLine("Не кратно");
}