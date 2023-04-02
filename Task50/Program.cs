// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Пример:
    1, 4, 7, 2
    5, 9, 2, 3
    8, 4, 2, 4

    17 -> такого числа в массиве нет
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


// Запуск метода.
InputMatrix(matrix);
PrintMatrix(matrix);


// Проверка позиции в массиве и вывод результата.--------------//
void CnslOut()
{
  Console.Write("Введите позицию искомого числа в массиве (через пробел): ");
  int[] position = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

  while (position[0] >= size[0] || position[1] >= size[1])
  {
    // Console.Write($"siz: {size[0]}-0 ");
    // Console.WriteLine($"{size[1]}-1 ");
    // Console.Write($"pos: {position[0]}-0 ");
    // Console.WriteLine($"{position[1]}-1 ");

    Console.Write("Такого позиции в массиве нет!\n");
    Console.Write("Введите позицию искомого числа в массиве (через пробел): ");
    position = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
  }
  Console.WriteLine(matrix[position[0], position[1]]);
}
// --------------Проверка позиции в массиве и вывод результата.//

CnslOut();

// --------------------------------------------------------------


