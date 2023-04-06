// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Пример:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7

    Наименьшая сумма элементов: 1 строка.
*/
// --------------------------------------------------------------
// Заполнение двухмерного массива.-----------------------------//
void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
      matrix[i, j] = new Random().Next(0, 10); // [0, 9)
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

// Ввод размера и объявление массива.
Console.Write("Введите размеры квадратного массива (1 цифра): ");
int size = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[size, size];
int[] matrRow = new int[size];

// Подсчёт суммы строк.----------------------------------------//
void SummRowElements(int[,] matrix)
{
  int count = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int summ = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
      summ += matrix[i, j];
    // Console.Write($"{summ} ");
    matrRow[i] = summ;
  }
}
// ---------------------------------------Подсчёт суммы строк.//

// Запуск метода.
InputMatrix(matrix);
// Console.WriteLine("Первоначальный массив:");
PrintMatrix(matrix);
SummRowElements(matrix);
Console.WriteLine($"[{string.Join(", ", matrRow)}]");

int count = 0, temp = matrRow[0];
for (int i = 1; i < matrRow.GetLength(0); i++)
{
  if (temp > matrRow[i])
  {
    temp = matrRow[i];
    count = i;
  }
}
Console.WriteLine($"Наименьшую сумму элементов имеет {count + 1} строка.");
// --------------------------------------------------------------