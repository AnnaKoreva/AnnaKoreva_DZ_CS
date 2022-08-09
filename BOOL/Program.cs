/*// Логический оператор НЕ (!)
bool passed=false; // задаем булевой переменной passed значение false
System.Console.WriteLine(!passed); // прописыввем, что нужно вывести на экран значение противположное переменной passed (!passed)
System.Console.WriteLine(!true);// прописыввем, что нужно вывести на экран значение противположное true (!true) никак не относящееся к переменной passed
*/

/*//Логический оператор И (&&)
System.Console.WriteLine(false && false); //ложь и ложь
System.Console.WriteLine(false && true); // ложь и правада
System.Console.WriteLine(true && false); //правда и ложь
System.Console.WriteLine(true && true); // правда и правда, единсвтенный вариант который будет истиной
*/

/*//Логичческий опрератор ИЛИ (||)
System.Console.WriteLine(false || false); //ложь или ложь
System.Console.WriteLine(false || true); // ложь или правда, это будет истиной
System.Console.WriteLine(true  || false); //правда или ложь, это будет истиной
System.Console.WriteLine(true  || true); // правда или правда, это будет истиной
*/

//ИСКЛЮЧАЮЩЕЕ ИЛИ (^) его значение соответсвует слову "либо"
System.Console.WriteLine(false ^ false); // ложь либо ложь - это будет ложь
System.Console.WriteLine(false ^ true); //  ложь либо првада - это будет истиной
System.Console.WriteLine(true  ^ false); // правда либо ложь - это будет истиной
System.Console.WriteLine(true  ^ true); // правда либо правда - это будет ложь потому что оба значения истина и оба утверждения не могут быть истиной