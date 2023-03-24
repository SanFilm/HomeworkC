﻿// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");


/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */
/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */
//                    ||     Sem_1_c#     ||
//                    Семинар от 05.03.23 г.
/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */
/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */

/*
Задача:
Необходимо ввести 2 числа и узнать их сумму.
*/
// // Очистка консоли.
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine()!);

// Console.WriteLine("Результат: " + n + " + " + m + " = " + (n + m));
// // Интерполяция строк
// Console.WriteLine($"Результат: {n} + {m} = {n + m}");


/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */
//       Ветвление. →     { if } { else if } { else }
/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */

/*
Задача:
Пользователь вводит 2 числа. Необходимо вывести наибольшее из них.
*/
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
/* можно не ставить фигурные скобки внутри операторов ветвления или циклов в том случае, если внутри находится всего лишь одно строчка кода.*/
// if (n > m)
//   Console.WriteLine(n);
// else if (n < m)
//   Console.WriteLine(m);
// else
//   Console.WriteLine("=");

/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */
//       Циклы. →     { for } { while }
/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */

// for (int i = 0; i < 10; i++)
//   Console.Write($"{i} ");
// /* 0 1 2 3 4 5 6 7 8 9 */

// int i = 0;
// while (i < 10)
// {
//   Console.Write($"{i} ");
//   i++;
// }
// /* 0 1 2 3 4 5 6 7 8 9 */

// for (int i = 10; i > 0; i--)
//   Console.Write($"{i} ");
// /* 10 9 8 7 6 5 4 3 2 1 */

// Console.Write("Результат: ");
// for (int i = 0; i < 10; i++)
//   Console.Write($"{i} ");
// Console.Write("\n");
// /* Результат: 0 1 2 3 4 5 6 7 8 9 */

// for (int i = 0; i < 10; i += 2)
//   Console.Write($"{i} ");
// /* 0 2 4 6 8 */

/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */
/*
Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное само на себя).
Пример:
    4 -> 16 
    -3 -> 9 
    -7 -> 49
*/

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Результат: {n} * {n} = {n * n}");
// /* Введите число: -25
// Результат: -25 * -25 = 625 */

/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */
//       Задачки (ссылки)
/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */

// acmp.ru
// informatics.ru
// https://www.eolymp.com/ru/problems
// codewars.com
// codeforces.com

/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */
//       Задачки (ссылки)
/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */

// Задача №1.Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5->да 
// a = 2, b = 10->нет 
// a = 9, b = -3->да 
// a = -3 b = 9 -> нет

// Console.Write("Введите 1-ое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int b = Convert.ToInt32(Console.ReadLine()!);
// if (a * a == b)
//   Console.WriteLine("Правда");
//   else
//   Console.WriteLine("Лож");
// /* Введите 1-ое число: -3
// Введите 2-ое число: 9
// Правда
// -- или --
// Введите 1-ое число: 9
// Введите 2-ое число: -3
// Лож */

/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */

// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.Write("Введите день недели: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 1 || n > 7) // || - или(or) дизъюнкция
// {
//   Console.Write("Вы ошиблись!\nВведите день недели: ");
//   n = int.Parse(Console.ReadLine()!);
// }
// if (n == 1)
//   Console.WriteLine("Понедельник");
// else if (n == 2)
//   Console.WriteLine("Вторник");
// else if (n == 3)
//   Console.WriteLine("Среда");
// else if (n == 4)
//   Console.WriteLine("Четверг");
// else if (n == 5)
//   Console.WriteLine("Пятница");
// else if (n == 6)
//   Console.WriteLine("Суббота");
// else
//   Console.WriteLine("Воскресенье");

/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */

// Задача №5.Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Я-1:

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n <= 0)
// {
//   Console.Write("Вы ошиблись!\nВведите ЦЕЛОЕ, ПОЛОЖИТЕЛЬНОЕ число: ");
//   n = int.Parse(Console.ReadLine()!);
// }
// int m = -n;
// for (int i = m; i <= n; i++)
// {
//   Console.Write($"{i}, ");
// }
// Console.WriteLine();

// Я-2:

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// for (int i = -n; i <= n; i++)
//   Console.Write($"{i}, ");
// Console.WriteLine();

// Учитель:

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!), i = (-1) * n;
// n = Math.Abs(n); // модуль числа
// // for (int i = (-1) * n; i <= n; i++)
// //     Console.Write($"{i} ");
// while (i <= n)
// {
//   Console.Write($"{i}, ");
//   i++; // i = i + 1
// }

/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */

// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8


// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(n % 10);



/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */
/* -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+ */

/* SF OK */