// Выяснить является ли число чётным
Console.Write("Введите число: ");
string x = Console.ReadLine();
int a=Convert.ToInt32(x);
if (a%2==0){
    Console.Write($"Число {a} является четным!");
}
else{
Console.Write($"Число {a} не является четным!");
}