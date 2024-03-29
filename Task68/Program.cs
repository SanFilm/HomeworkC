﻿// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Пример:
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29
*/
// --------------------------------------------------------------

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0 && m > 0) return Akkerman(m - 1, 1);
  else return (Akkerman(m - 1, Akkerman(m, n - 1)));
}

Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N.\n");

Console.Write("Введите число M : ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N : ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"\nИскомое число: {Akkerman(m, n)}\n");
// --------------------------------------------------------------
