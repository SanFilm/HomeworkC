// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
// --------------------------------------------------------------
/*  _230401(s)-C#  */
// --------------------------------------------------------------
// --------------------------------------------------------------


// --------------------------------------------------------------
/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Пример:
    
    
*/
// --------------------------------------------------------------
// void InputMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//       matrix[i, j] = new Random().Next(-10, 11); // [-10; 10]
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

// void ReplaceRow(int[,] matrix)
// {
//   for (int j = 0; j < matrix.GetLength(1); j++)
//   {
//     int temp = matrix[0, j];
//     matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
//     matrix[matrix.GetLength(0) - 1, j] = temp;
//   }
// }

// Console.Clear();
// Console.Write("Введите размеры двумерного массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// ReplaceRow(matrix);
// PrintMatrix(matrix);
// --------------------------------------------------------------

// --------------------------------------------------------------
/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Пример:
    
    
*/
// --------------------------------------------------------------
// void InputMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//       matrix[i, j] = new Random().Next(-10, 11); // [-10; 10]
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

// void ReplaceRow(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = i + 1; j < matrix.GetLength(1); j++)
//     {
//       int temp = matrix[i, j];
//       matrix[i, j] = matrix[j, i];
//       matrix[j, i] = temp;
//     }
//   }
// }

// Console.Clear();
// Console.Write("Введите размеры двумерного массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// while (size[0] != size[1])
// {
//   Console.Write("Вы ошиблись!\nВведите размеры двумерного массива: ");
//   size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// }
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// ReplaceRow(matrix);
// PrintMatrix(matrix);
// --------------------------------------------------------------

// --------------------------------------------------------------
/*
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Пример:
    Набор данных                      Частотный массив
  { 1, 9, 9, 0, 2, 8, 0, 9 }        0 встречается 2 раза 
                                    1 встречается 1 раз 
                                    2 встречается 1 раз 
                                    8 встречается 1 раз 
                                    9 встречается 3 раза.

  1, 2, 3                           1 встречается 3 раза 
  4, 6, 1                           2 встречается 2 раз 
  2, 1, 6                           3 встречается 1 раз 
                                    4 встречается 1 раз 
                                    6 встречается 2 раза
*/
// --------------------------------------------------------------
// bool checkElement(int[] array, int number)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] == number)
//       return false;
//   }
//   return true;
// }

// int inputMatrix(int[,] matrix, int[] array)
// {
//   int k = 0;
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//       if (checkElement(array, matrix[i, j]))
//       {
//         array[k] = matrix[i, j];
//         k++;
//       }
//       Console.Write($"{matrix[i, j]} \t");
//     }
//     Console.WriteLine();
//   }
//   return k;
// }


// void SwapFirstLastString(int[,] matrix, int[] array, int countArray)
// {
//   for (int k = 0; k < countArray; k++)
//   {
//     int count = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//         if (array[k] == matrix[i, j])
//           count++;
//       }
//     }
//     Console.WriteLine($"Элемент {array[k]} встречается {count} раз");
//   }

// }

// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] coord = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[coord[0], coord[1]];
// int[] array = new int[coord[0] * coord[1]];
// Console.WriteLine("Начальный массив: ");
// int countArray = inputMatrix(matrix, array);
// Console.WriteLine();
// Console.WriteLine($"[{string.Join(", ", array)}]");
// SwapFirstLastString(matrix, array, countArray);
// --------------------------------------------------------------
/*
Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Пример:
    Задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
    Наименьший элемент = 1.
    На выходе получим следующий массив:
9 4 2
2 2 6
3 4 7
*/
// --------------------------------------------------------------
// void InputMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//       Console.Write($"{matrix[i, j]} \t");
//     }
//     Console.WriteLine();
//   }
// }


// void SwapFirstLastString(int[,] matrix)
// {
//   int minValue = matrix[0, 0], minRow = 0, minColumn = 0;
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       if (matrix[i, j] < minValue)
//       {
//         minValue = matrix[i, j];
//         minRow = i;
//         minColumn = j;
//       }
//     }
//   }
//   Console.WriteLine($"Минимум {minValue} на позиции({minRow + 1}, {minColumn + 1})");
//   Console.WriteLine();
//   Console.WriteLine("Конечный массив");
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     if (i != minRow)
//     {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//         if (j != minColumn)
//           Console.Write($"{matrix[i, j]} \t");
//       }
//       Console.WriteLine();
//     }
//   }
// }

// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] coord = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[coord[0], coord[1]];
// Console.WriteLine("Начальный массив");
// InputMatrix(matrix);
// SwapFirstLastString(matrix);
// --------------------------------------------------------------
