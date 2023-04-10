using System;
class Program
{
    static void Main() // Выполнение начинается с метода Main
    {
        var x = double.Parse(Input("x: ")); // создается целочисленная переменная x
        var n = int.Parse(Input("n: ")); // создается целочисленная переменная n
        var sum = Sum(x, n); // Вычисляет сумму последовательности числовых значений
         Console.WriteLine($"Сумма: {sum:F15}"); // Для вывода информации на консоль
        Console.ReadLine(); // чтоб не закрывалось
    }
    static double Sum(double x, int n, double sum = 0) // // метод с обычным параметром типа int и универсальными параметрами
    {
 if (n <= 0) return sum;
 sum += Math.Cos(Math.Pow(x, n)); // Для математических вычислений
 return Sum(x, n - 1, sum); // завершает выполнение метода
}
static string Input(string prompt) // static можно использовать для объявления классов static
 {
 string line = ""; // объект типа String, значением которого является текст.
 while (line == "") // выполняет оператор или блок операторов, пока определенное логическое выражение равно значению true
 {
 Console.Write(prompt); // Используется для вывода всех типов данных на консоль, перевод на новую строку не осуществляет.
 line = Console.ReadLine(); // чтоб не закрывалось
 }
 return line; // завершает выполнение метода
 }
}
