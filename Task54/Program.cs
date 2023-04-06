// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Пример:
    1 4 7 2
    5 9 2 3
    8 4 2 4

    7 4 2 1
    9 5 3 2
    8 4 4 2
*/
// --------------------------------------------------------------
// Заполнение двухмерного массива.-----------------------------//
void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
      matrix[i, j] = new Random().Next(10, 100); // [10, 99)
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
// Сортировка массива по убыванию, по строчно.-----------------//
void ReplaceRow(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        if (matrix[i, k] < matrix[i, k + 1])
        {
          int temp = matrix[i, k + 1];
          matrix[i, k + 1] = matrix[i, k];
          matrix[i, k] = temp;
        }
      }
    }
  }
}
// -----------------Сортировка массива по убыванию, по строчно.//

// Ввод размера массива.
Console.Write("Введите размеры массива (2 цифры через пробел): ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

// Запуск метода.
InputMatrix(matrix);
Console.WriteLine("Первоначальный массив:");
PrintMatrix(matrix);
// --------------------------------------------------------------

ReplaceRow(matrix);
Console.WriteLine("Отсортированный массив по убыванию, по строчно:");
PrintMatrix(matrix);
// --------------------------------------------------------------

// --------------------------------------------------------------