// See https://aka.ms/new-console-template for more information
// Очистка консоли.
// Console.Clear();
// Console.WriteLine("Hello, World!");


Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// // Console.Write("Результат: " + (n + m));
// // Интерполяция строк
// Console.WriteLine($"Результат: {n} + {m} = {n + m}");


// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// // можно не ставить фигурные скобки внутри операторов ветвления или циклов в том случае, 
// //если внутри находится всего лишь одно строчка кода
// if (n > m)
//   Console.WriteLine(n);
// else if (n < m)
//   Console.WriteLine(m);
// else
//   Console.WriteLine("=");

// for (int i = 0; i < 10; i++)
//   Console.Write($"{i} ");

// for (int i = 0; i < 10; i += 2)
//   Console.Write($"{i} ");

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Результат: {n} * {n} = {n * n}");

// acmp
// informatics
// e-olymp
// codewars
// codeforce


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


// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

// Console.Clear();
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


// Задача №5.Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int m = n;
int l = -n;
while (n < -l || m > n) // || - или(or) дизъюнкция
  n = n + 1;
Console.WriteLine(n);

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!), i = (-1) * n;
// n = Math.Abs(n); // модуль числа
// // for (int i = (-1) * n; i <= n; i++)
// //     Console.Write($"{i} ");
// while (i <= n)
// {
//   Console.Write($"{i} ");
//   i++; // i = i + 1
// }

// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8


// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(n % 10);