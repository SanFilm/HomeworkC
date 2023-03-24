// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Пример:
    3 -> 1, 8, 27
    5 -> 1, 8, 27, 64, 125
*/
// --------------------------------------------------------------

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= x; i++)
  Console.Write($"{Math.Pow(i, 3)} ");
Console.WriteLine();


// Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
  Console.Write($"{i * i * i} ");
Console.WriteLine();