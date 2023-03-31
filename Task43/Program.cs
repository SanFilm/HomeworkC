// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача : Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Пример:
    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Write("Задайте значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1) / (-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Координаты пересечения двух прямых: X: {Math.Round(x, 2)}, Y: {Math.Round(y, 2)}");
Console.WriteLine($"\nРешение я нашёл в Инете, как решается и почему не понял ...\n");

// --------------------------------------------------------------
