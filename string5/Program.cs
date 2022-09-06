//string5. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. 
//Вычислить сумму цифр введенного числа
string str = Console.ReadLine();
int temp = 0;
int sum = 0;
if (!Int32.TryParse(str, out temp))
    Console.WriteLine("Это не является верной записью целого");
else {
foreach (char digit in str)
    sum += digit - 48;
    Console.WriteLine(sum);
     }
