﻿// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
// --------------------------------------------------------------
/* 

*/
// --------------------------------------------------------------
// --------------------------------------------------------------





// --------------------------------------------------------------
// --------------------------------------------------------------
// --------------------------------------------------------------
// --------------------------------------------------------------
// --------------------------------------------------------------
// --------------------------------------------------------------
// --------------------------------------------------------------
// --------------------------------------------------------------
// --------------------------------------------------------------
// --------------------------------------------------------------
// --------------------------------------------------------------
// --------------------------------------------------------------
// --------------------------------------------------------------
// --------------------------------------------------------------


// _230325(s)-C# //


// --------------------------------------------------------------
/*
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
Пример:
    [1 2 3 4 5] -> [5 4 3 2 1]
    [6 7 3 6] -> [6 3 7 6]
*/
// --------------------------------------------------------------

// Вар.1 //

// void InputArray(double[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = Math.Round(new Random().NextDouble() * (100 - 50) + 50, 2); // [50, 100]
// }

// void ReplaceElements(double[] array)
// {
//   for (int i = 0; i < array.Length / 2; i++)
//   {
//     double temp = array[i];
//     array[i] = array[array.Length - 1 - i];
//     array[array.Length - 1 - i] = temp;
//   }
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// double[] array = new double[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ReplaceElements(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");

// вар.2 //

// void InputArray(double[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = Math.Round(new Random().NextDouble() * (50 + 50) - 50, 2); // [-50, 50]
// }

// void ReplaceElements(double[] array)
// {
//   for (int i = 0; i < array.Length / 2; i++)
//   {
//     double temp = array[i];
//     array[i] = array[array.Length - 1 - i];
//     array[array.Length - 1 - i] = temp;
//   }
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// double[] array = new double[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ReplaceElements(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");

// --------------------------------------------------------------

// --------------------------------------------------------------
/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
- Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. -
*/
// --------------------------------------------------------------

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 3-е число: ");
// int c = int.Parse(Console.ReadLine()!);
// if (a + b > c && b + c > a && a + c > b)
//   Console.WriteLine("yes");
// else
//   Console.WriteLine("no");

// --------------------------------------------------------------

// --------------------------------------------------------------
/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Пример:
    45 -> 101101
    3  -> 11
    2  -> 10
*/
// --------------------------------------------------------------

// вар.1 //
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// string result = string.Empty;
// while (n > 0)
// {
//   result = Convert.ToString(n % 2) + result;
//   n /= 2;
// }
// Console.WriteLine(result);

// вар.2 //
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int result = 0, count = 1;
// while (n > 0)
// {
//   result += (n % 2) * count;
//   n /= 2;
//   count *= 10;
// }
// Console.WriteLine(result);


// --------------------------------------------------------------

// --------------------------------------------------------------
/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Пример:
    Если N = 5 -> 0 1 1 2 3
    Если N = 3 -> 0 1 1
    Если N = 7 -> 0 1 1 2 3 5 8
*/
// --------------------------------------------------------------

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int a0 = 0, a1 = 1, x;
// for (int i = 0; i < n; i++)
// {
//   Console.Write($"{a0} ");
//   x = a0 + a1;
//   a0 = a1;
//   a1 = x;
// }

// --------------------------------------------------------------

// --------------------------------------------------------------
/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/
// --------------------------------------------------------------

// Не верно //

// int a = 10;
// int b = a;
// b = b + 5;
// Console.WriteLine(a);
// Console.WriteLine(b);
// int[] a = {1, 2, 3, 4, 5};
// int[] b = a;
// b[0] = b[0] + 10;
// Console.WriteLine(string.Join(" ", a));
// Console.WriteLine(string.Join(" ", b));

// ВЕРНО //

// int[] a = { 1, 2, 3, 4, 5 };
// int[] b = new int[a.Length];

// for (int i = 0; i < a.Length; i++)
//   b[i] = a[i];

// b[0] = b[0] + 20;
// Console.WriteLine(string.Join(" ", a));
// Console.WriteLine(string.Join(" ", b));

// --------------------------------------------------------------




