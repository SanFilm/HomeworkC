// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
// --------------------------------------------------------------
/*  _230326(s)-C#  */
// --------------------------------------------------------------
// --------------------------------------------------------------


// --------------------------------------------------------------
// int[] size = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();

// int[] size = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();
// // Складывает 4 введённых числа.
// Console.WriteLine(size[0] + size[1] + size[2] + size[3]);

// --------------------------------------------------------------
// void InputMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//       matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
//   }
// }

// void PrintMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//       Console.Write($"{matrix[i, j]} \t");
//     Console.WriteLine();
//   }
// }


// Console.Clear();
// Console.Write("Введите размеры массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);

// --------------------------------------------------------------

// --------------------------------------------------------------
/*
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
Пример:
    m = 3, n = 4.
    0 1 2 3
    1 2 3 4
    2 3 4 5
*/

// void InputMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//       matrix[i, j] = i + j;
//   }
// }

// void PrintMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//       Console.Write($"{matrix[i, j]} \t");
//     Console.WriteLine();
//   }
// }


// Console.Clear();
// Console.Write("Введите размеры массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);

// --------------------------------------------------------------

// --------------------------------------------------------------
/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
Пример:
    Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
    Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

// void InputMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//       matrix[i, j] = i + j;
//   }
// }

// void PrintMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//       Console.Write($"{matrix[i, j]} \t");
//     Console.WriteLine();
//   }
// }


// void ReleaseMatrix(int[,] matrix)
// {
//   for (int i = 1; i < matrix.GetLength(0); i += 2)
//   {
//     for (int j = 1; j < matrix.GetLength(1); j += 2)
//       matrix[i, j] *= matrix[i, j];
//   }
// }


// Console.Clear();
// Console.Write("Введите размеры массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.WriteLine("Начальный массив");
// PrintMatrix(matrix);
// ReleaseMatrix(matrix);
// Console.WriteLine("Конечный массив");
// PrintMatrix(matrix);

// --------------------------------------------------------------

// --------------------------------------------------------------
/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Пример:
    1 4 7 2
    5 9 2 3
    8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

// void InputMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//       matrix[i, j] = i + j;
//   }
// }

// void PrintMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//       Console.Write($"{matrix[i, j]} \t");
//     Console.WriteLine();
//   }
// }


// int ReleaseMatrix(int[,] matrix)
// {
//   int summa = 0;
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       if (i == j)
//         summa += matrix[i, j];
//     }
//   }
//   return summa;
// }


// Console.Clear();
// Console.Write("Введите размеры массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.WriteLine("Начальный массив");
// PrintMatrix(matrix);
// Console.WriteLine($"Результат {ReleaseMatrix(matrix)}");

// --------------------------------------------------------------