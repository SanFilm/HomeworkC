// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача 60: ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Пример:
    Задан массив размером: 2x2x2

    66(0,0,0); - 25(0,1,0)
    34(1,0,0); - 41(1,1,0)
    27(0,0,1); - 90(0,1,1)
    26(1,0,1); - 55(1,1,1)
*/
// --------------------------------------------------------------

// Вывод массива в консоль.------------------------------------//
void PrintMatrix(int[,,] matrix3D)
{
  for (int i = 0; i < matrix3D.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3D.GetLength(1); j++)
    {
      for (int k = 0; k < matrix3D.GetLength(2); k++)
      {
        Console.Write($"{matrix3D[i, j, k]}({i},{j},{k}); ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
// ------------------------------------Вывод массива в консоль.//
// Заполнение трёхмерного массива.-----------------------------//
void InputMatrix(int[,,] matrix3D)
{
  int[] temp = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
  int number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
        number = temp[i];
      }
    }
  }
  int count = 0;
  for (int x = 0; x < matrix3D.GetLength(0); x++)
  {
    for (int y = 0; y < matrix3D.GetLength(1); y++)
    {
      for (int z = 0; z < matrix3D.GetLength(2); z++)
      {
        matrix3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
// -----------------------------Заполнение трёхмерного массива.//

// Ввод параметров массива.
Console.WriteLine($"Введите размер трёхмерного массива:");
Console.Write($"Введите X: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write($"Введите Y: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write($"Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] matrix3D = new int[x, y, z];
// Запуск методов.
InputMatrix(matrix3D);
PrintMatrix(matrix3D);

// --------------------------------------------------------------
