// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// 7/2 = 3(1)
// 3/2 = 1(1)
// 1/2 = 0(1)
///111

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int temp;
string result = "";
while (number >= 1)
{
    temp = number / 2;
    result += (number % 2);
    number = temp;
}
Console.WriteLine($"{result}");