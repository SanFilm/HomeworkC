// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
// --------------------------------------------------------------
/* 

*/
// --------------------------------------------------------------
// --------------------------------------------------------------

// void f(ref int x)
// {
//   x = x + 10;
// }

// int n = 5;
// f(ref n);
// Console.WriteLine(n);

// --------------------------------------------------------------

// void f(int[] n)
// {
//   n[0] += 100;
// }

// Console.Clear();
// int[] array = { 1, 2, 3, 4, 5 };
// f(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");

// --------------------------------------------------------------

// int maxNumbers(int a, int b)
// {
//   if (a > b)
//     return a;
//   return b;
// }

// Console.Clear();
// int n = 5, m = 7;
// Console.WriteLine(maxNumbers(n, m));

// --------------------------------------------------------------
// --------------------------------------------------------------

// void InputArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-9, 10); // [-9; 9]
// }

// int SumPositiveInArray(int[] array)
// {
//   int summa = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] > 0)
//       summa += array[i];
//   }
//   return summa;
// }

// int SumNegativeInArray(int[] array)
// {
//   int summa = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] < 0)
//       summa += array[i];
//   }
//   return summa;
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Сумма положительных чисел равна {SumPositiveInArray(array)}");
// Console.WriteLine($"Сумма отрицательный чисел равна {SumNegativeInArray(array)}");

// --------------------------------------------------------------
// --------------------------------------------------------------

// void InputArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-9, 10); // [-9; 9]
// }

// int[] ReplaceNumbers(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] *= (-1);
//   return array;
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Конечный массив: [{string.Join(", ", ReplaceNumbers(array))}]");

// --------------------------------------------------------------
// --------------------------------------------------------------

// void InputArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-9, 10); // [-9; 9]
// }

// string CheckNumber(int[] array, int n)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] == n)
//       return "yes";
//   }
//   return "no";
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.Write("Введите число, которое Вы хотите найти: ");
// int number = int.Parse(Console.ReadLine()!);
// Console.WriteLine(CheckNumber(array, number));

// --------------------------------------------------------------
// --------------------------------------------------------------

// void InputArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-100, 101); // [-100; 100]
// }

// int CountNumbers(int[] array)
// {
//   int count = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] >= 10 && array[i] <= 99)
//       count++;
//   }
//   return count;
// }


// Console.Clear();
// int[] array = new int[123];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine();
// Console.WriteLine(CountNumbers(array));

// --------------------------------------------------------------
// --------------------------------------------------------------

// void InputArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 11); // [1, 10]
// }

// void MultiplicationNumbers(int[] array)
// {
//   for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
//     Console.Write($"{array[i] * array[array.Length - 1 - i]} ");
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// MultiplicationNumbers(array);

// --------------------------------------------------------------
// --------------------------------------------------------------
