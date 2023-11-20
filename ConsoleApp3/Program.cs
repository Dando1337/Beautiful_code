Console.BackgroundColor = ConsoleColor.Cyan;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Введите X1 заданного уравнения");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите X2 заданного уравнения");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
// Переменная для ответа
double answer = 1;
// Переменная для минимального числа
double min = 0;
// Переменные для нахождения F и F2
double f;
double f2;
// Первая и вторая переменная(надо было назвать firstVariable и secondVariable)
double x0 = 0;
double x1 = 0;
// Формулы
f = Math.Pow(2, a) - 2 * Math.Cos(a);
f2 = 2 * Math.Cos(a) + Math.Pow(Math.Log(2), 2) * Math.Pow(2, a);
// Первое ветвление
if (f < 0 && f2 < 0 || f > 0 && f2 > 0)
{
    x0 = a;
    min = Math.Abs(2 * Math.Sin(b) + Math.Log(2) * Math.Pow(2, b));
}
f = Math.Pow(2, b) - 2 * Math.Cos(b);
f2 = 2 * Math.Cos(b) + Math.Pow(Math.Log(2), 2) * Math.Pow(2, b);
// Второе ветвление
if (f < 0 && f2 < 0 || f > 0 && f2 > 0)
{
    x0 = b;
    min = Math.Abs(2 * Math.Sin(a) + Math.Log(2) * Math.Pow(2, a));
}
// Вывод на экран
Console.WriteLine("Метод хорд");
// Цикл
while (answer > 0.0001)
{
    x1 = x0 - ((Math.Pow(2, x0) - 2 * Math.Cos(x0)) / (2 * Math.Sin(x0) + Math.Log(2) * Math.Pow(2, x0)));
    answer = Math.Abs((Math.Pow(2, x1) - 2 * Math.Cos(x1))) / min;
    Console.WriteLine("x");
    Console.WriteLine("2^" + x0 + " - 2 * Cos(" + x0 + ") / 2 * Sin(" + x0 + ") + Log(2) * 2^" + x0 + " = " + x1);
    Console.WriteLine("Точность");
    Console.WriteLine("|2^" + x1 + " - 2 * Cos(" + x1 + ")| = " + answer);
    x0 = x1;
}
// Вывод на экран
Console.WriteLine("Ответ: " + x1);
Console.WriteLine("Метод касательных");
answer = 1;
// Цикл
while (answer > 0.0001)
{
    if (a > b)
    {
        x0 = b;
        b = a;
        a = x0;
    }
    x1 = (b * (Math.Pow(2, a) - 2 * Math.Cos(a)) - a * (Math.Pow(2, b) - 2 * Math.Cos(b))) / ((Math.Pow(2, a) - 2 * Math.Cos(a)) - (Math.Pow(2, b) - 2 * Math.Cos(b)));
    answer = Math.Abs((Math.Pow(2, x1) - 2 * Math.Cos(x1))) / min;
    Console.WriteLine("x");
    Console.WriteLine(b + " * 2^" + a + " - 2 * Cos(" + a + ") - " + a + " * 2^" + b + " - 2 * Cos(" + b + ") / 2^" + a + " - 2 * Cos(" + a + ") - 2^" + b + " - 2 * Cos(" + b + ") = " + x1);
    a = x1;
    Console.WriteLine("Точность");
    Console.WriteLine("|2^" + x1 + " - 2 * Cos(" + x1 + ") = " + answer);
}
// Вывод на экран
Console.WriteLine("Ответ: " + x1);