﻿// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
// --------------------------------------------------------------
/* э
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/
// --------------------------------------------------------------
// --------------------------------------------------------------

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 6 || n == 7)
  Console.WriteLine($"{n} -> yes");
else
  Console.WriteLine($"{n} -> no");