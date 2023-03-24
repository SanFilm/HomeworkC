// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

формула: AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Пример:
    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53
*/
// --------------------------------------------------------------

Console.Write("Введите координату X(a): ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y(a): ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z(a): ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X(b): ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y(b): ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z(b): ");
double zb = Convert.ToDouble(Console.ReadLine());
double s = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));    // AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
double q = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));    // AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
//         кв.корень(возв.стпнь(что, стпнь)
Console.WriteLine($"Расстояние между двумя точками в 3D = {Math.Round(s, 3)}");
Console.WriteLine($"Расстояние между двумя точками в 3D = {Math.Round(q, 3)}");
