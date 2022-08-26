// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите количество чисел M = ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrayM = new int[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"введите число {i+1}: ");
    arrayM[i] = int.Parse(Console.ReadLine());
}
int count = 0;
for (int i = 0; i < size; i++)
{
    if (arrayM[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($" {String.Join("; ", arrayM)} -> {count}");