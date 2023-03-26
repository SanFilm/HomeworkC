// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача : Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Пример:
    3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
*/
// --------------------------------------------------------------

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
  array[i] = new Random().Next(0, 11);                 // [0, 10]
Console.WriteLine($"[{string.Join(", ", array)}] -> ");

int sum = 0;
for (int i = 1; i < array.Length; i++)
{
  if (i % 2 != 0)
  {
    Console.Write($"{i}-");
    Console.Write($"{array[i]}, ");
    sum += array[i];
  }
// Console.WriteLine(sum);
}
Console.WriteLine($"\n{sum}");