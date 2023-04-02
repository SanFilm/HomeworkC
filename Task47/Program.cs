﻿// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача : Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Пример:
    m = 3, n = 4
    0.5,    7, -2, -0.2
      1, -3.3,    8, -9.9
      8,  7.8, -7.1,    9
*/
// --------------------------------------------------------------
void InputMatrix(double[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
      matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;   // [-10, 9.9]
  }
}

void PrintMatrix(double[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
      Console.Write($"{matrix[i, j]} \t");
    Console.WriteLine();
  }
}


Console.Clear();
Console.Write("Введите размеры массива (через пробел): ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);

// --------------------------------------------------------------
