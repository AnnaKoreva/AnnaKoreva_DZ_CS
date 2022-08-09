// Дано число из  диапозона  [10, 99]. Показать наибольшую цифру числа
int a = new Random().Next(10,99);
System.Console.WriteLine($"Cлучайно сформированноe число =  {a}");
int b = a/10;
int c = a%10;
if (b<c) System.Console.WriteLine($"В случайно сформированном числе {a} наибольшей цифрой является {c}");
else System.Console.WriteLine($"В случайно сформированном числе наибольшей цифрой является {b}");



