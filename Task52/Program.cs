// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Пример:
    1 4 7 2
    5 9 2 3
    8 4 2 4

    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

// --------------------------------------------------------------

// Заполнение двухмерного массива.-----------------------------//
void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
      matrix[i, j] = new Random().Next(0, 21); // [-10, 10]
  }
}
// -----------------------------Заполнение двухмерного массива.//
// Вывод массива в консоль.------------------------------------//
void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
      Console.Write($"{matrix[i, j]} \t");
    Console.WriteLine();
  }
}
// ------------------------------------Вывод массива в консоль.//


// Ввод размера массива.
Console.Write("Введите размеры массива (через пробел): ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
// int m = 3, n = 5;
// int[,] matrix = new int[m, n];


// Запуск метода.
InputMatrix(matrix);
PrintMatrix(matrix);

// // Вывод количества строк.
// Console.Write($"Стрк - {string.Join(", ", matrix.GetLength(0))}, ");
// // Вывод количества колонок.
// Console.WriteLine($"Клнк - {string.Join(", ", matrix.GetLength(1))}");

Console.WriteLine();
// Нахождение среднего арифметического элементов каждого столбца.
for (int j = 0; j < matrix.GetLength(1); j++)
{
  double avarage = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    avarage = (avarage + matrix[i, j]);
  }
  avarage /= matrix.GetLength(0);
  Console.Write(Math.Round(avarage, 1) + "     ");
  // { Math.Round(s, 3)}
}
Console.WriteLine();

// --------------------------------------------------------------