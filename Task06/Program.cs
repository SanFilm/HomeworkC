﻿// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
// --------------------------------------------------------------
/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).*/
// --------------------------------------------------------------
// --------------------------------------------------------------

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n % 2 == 0)
{
  Console.WriteLine($"{n} -> YES ");
}
else
{
  Console.WriteLine($"{n} -> NO");
}