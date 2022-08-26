// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите угловой коэффициент первой прямой (k1):  ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свободный коэффициент первой прямой (b1):  ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите угловой коэффициент второй прямой (k2):  ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свободный коэффициент второй прямой (b2):  ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

double x = new double();
double y = new double();

if ((k1 == k2) && (b1 == b2)) Console.WriteLine("Прямые совпадают");

if ((k1 == k2) && (b1 != b2)) Console.WriteLine("Решений нет");

else
{

    x = (b2 - b1) / (k1 - k2);
    y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> (x = {x}, y = {y})");
}