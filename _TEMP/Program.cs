// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

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


// Ввод размера массива.
Console.Write("Введите количество строк 1-го массива: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество колонок 1-го и строк 2-го массива: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество колонок 2-го массива: ");
int c = int.Parse(Console.ReadLine()!);

int[,] ara = new int[a, b];
int[,] arb = new int[b, c];
int[,] arc = new int[a, c];


// int[,] ara = new int[,] { { 2, 4}, { 3, 2} };         // Test
// int[,] arb = new int[,] { { 3, 4}, { 3, 3} };         // Test
// int[,] arc = new int[2, 2];                           // Test

InputMatrix(ara);
InputMatrix(arb);

PrintMatrix(ara);
Console.WriteLine();
PrintMatrix(arb);

// --------------------------------------------------------------
void MultiplyMatrix(int[,] ara, int[,] arb, int[,] arc)
{
  for (int i = 0; i < arc.GetLength(0); i++)
  {
    for (int j = 0; j < arc.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < ara.GetLength(1); k++)
      {
        sum += ara[i, k] * arb[k, j];
      }
      arc[i, j] = sum;
    }
  }
}
// --------------------------------------------------------------
MultiplyMatrix(ara, arb, arc);
Console.WriteLine($"\nПроизведение матриц:");
PrintMatrix(arc);
// --------------------------------------------------------------
