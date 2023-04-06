// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
// --------------------------------------------------------------
/*  _230402(s)-C#  Рекурсия.*/
// --------------------------------------------------------------
// --------------------------------------------------------------

// Необходимо сложить 2 числа с помощью рекурсии
// int f(int a, int b)
// {
//   if (a == 0)
//     return b;
//   return f(a - 1, b + 1);
// }

// Console.Clear();
// Console.WriteLine(f(5, 4));

/*
f(5, 4) -> f(4, 5) -> f(3, 6) -> f(2, 7) -> f(1, 8) -> f(0, 9) -> 9
*/

// --------------------------------------------------------------
/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
Пример:
    N = 5 -> "1, 2, 3, 4, 5"
    N = 6 -> "1, 2, 3, 4, 5, 6"
*/
// --------------------------------------------------------------
// // Необходимо сложить 2 числа с помощью рекурсии
// string f(int n)
// {
//   if (n == 1)
//     return "1 ";
//   return f(n - 1) + $"{n} ";
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(f(n));

// Консоль:
// N = 5 -> "1, 2, 3, 4, 5"
/*
f(5) -> f(4) + "5 "
          |
          f(3) + "4 "
            |
            f(2) + "3 "
              |
              f(1) + "2 "
                |
                "1 "
*/
// --------------------------------------------------------------
// // Необходимо сложить 2 числа с помощью рекурсии
// string f(int n)
// {
//   if (n == 1)
//     return "1";
//   return $"{n} " + f(n - 1);
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(f(n));

// Консоль:
// N = 5 -> "5, 4, 3, 2, 1"
/*
f(5) -> f(4) + "5 "
          |
          f(3) + "4 "
            |
            f(2) + "3 "
              |
              f(1) + "2 "
                |
                "1 "
*/
// --------------------------------------------------------------
/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Пример:
    M = 1; N = 5 -> "1, 2, 3, 4, 5"
    M = 4; N = 8 -> "4, 6, 7, 8"
*/
// --------------------------------------------------------------
// string f(int m, int n)
// {
//   if (m == n)
//     return $"{m} ";
//   return f(m, n - 1) + $"{n} ";
// }


// Console.Clear();
// Console.Write("Введите начальное число: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите конечное число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(f(m, n));

// --------------------------------------------------------------
// void f(int a, int b)
// {
//   Console.WriteLine($"{a} + {b} = {a + b}");
// }

// f(5, 10);
// // a = 5
// // b = 10
// --------------------------------------------------------------
/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
Пример:
    453 -> 12
    45 -> 9
*/
// --------------------------------------------------------------
// Inet
// int digitsSum(int n)
// {
//   if (n == 0) return 0;
//   return n % 10 + digitsSum(n / 10);
// }

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(digitsSum(n));
// --------------------------------------------------------------
// int f(int n)
// {
//   if (n / 10 == 0 || n < 10 || n % 10 == n)
//     return n;
//   return f(n / 10) + n % 10;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Результат: {f(n)}");
// --------------------------------------------------------------
/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
Пример:
    A = 3; B = 5 -> 243 (3⁵)
    A = 2; B = 3 -> 8
*/
// --------------------------------------------------------------
// Inet
// Console.Clear();
// int a = GetNumberFromUser($"Введите число ", "Ошибка ввода!");  //  вызов метода
// int b = GetNumberFromUser($"Введите степень числа ", "Ошибка ввода!");  //  вызов метода
// int result = GetResult(a, b);
// Console.WriteLine($"A = {a}; B = {b} -> {result}");

// int GetNumberFromUser(string message, string errorMessage)
// {
//   while (true)
//   {
//     Console.Write(message);
//     bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
//     if (isCorrect)
//       return userNumber;
//     Console.WriteLine(errorMessage);
//   }
// }

// int GetResult(int a, int b)
// {
//   if (b == 1) return a;
//   {
//     return a * GetResult(a, b - 1);
//   }
// }
// --------------------------------------------------------------
// int f(int a, int b)
// {
//   if (b == 0)
//     return 1;
//   return f(a, b - 1) * a;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите степень: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Результат: {f(a, b)}");
// --------------------------------------------------------------