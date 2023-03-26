// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача : Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Пример:
    [3,01 7,23 22,79 2,38 78,45] -> 76,07
*/
// --------------------------------------------------------------

Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
  array[i] = Math.Round(new Random().NextDouble() * (30 - 10) + 10, 2);
Console.WriteLine($"[{string.Join(", ", array)}] \n");

double max = array[0], min = array[0];

//   max
for (int i = 1; i < array.Length; i++)
{
  if (array[i] > max)
  {
    max = array[i];
  }
}
// Console.Write($"{max}");

//   min
for (int i = 1; i < array.Length; i++)
{
  if (array[i] < min)
  {
    min = array[i];
  }
}
// Console.Write($"{min}");
Console.WriteLine($"{max} - {min} = {max-min} \n");
