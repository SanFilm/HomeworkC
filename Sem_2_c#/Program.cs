﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.Clear();

// Console.Clear();
// int n = new Random().Next(10, 100); // [10, 99]
// Console.WriteLine($"Случаной сгенированное число {n}");
// int n1 = n / 10;
// int n2 = n % 10;
// if (n1 > n2)
//   Console.WriteLine(n1);
// else
//   Console.WriteLine(n2);

// Задача 11
// Console.Clear();
// int n = new Random().Next(100, 1000); // [10, 99]
// Console.WriteLine($"Случаной сгенированное число {n}");
// int n1 = n / 100;
// int n3 = n % 10;
// Console.WriteLine(n1 * 10 + n3);
// Console.Write(n1);
// Console.WriteLine(n3);


// Задача 12
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n % m == 0)
//   Console.WriteLine("кратно");
// else
//   Console.WriteLine($"не кратно, остаток {n % m}");

// Задача 14
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n % 161 == 0)
//   Console.WriteLine("yes");
// else
//   Console.WriteLine("no");

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n % 7 == 0 && n % 23 == 0)
//   Console.WriteLine("yes");
// else
//   Console.WriteLine("no");


// Задача 16
Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n * n == m || m * m == n)
  Console.WriteLine("yes");
else
  Console.WriteLine("no");
// && - и(одновременное выполнение условий)
// || - или(выполнение хотя бы одного из условий)