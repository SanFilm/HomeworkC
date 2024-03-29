﻿// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Пример:
    N = 5 -> "5, 4, 3, 2, 1"
    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
// --------------------------------------------------------------

string f(int n)
{
  if (n == 1)
    return "1 ";
  return $"{n} " + f(n - 1);
}

Console.WriteLine("Задача 64: Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.(Рекурсия)\n");
Console.Write("Задайте значение N > 0: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(n));
// --------------------------------------------------------------