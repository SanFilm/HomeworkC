// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Пример:
    [345, 897, 568, 234] -> 2
*/
// --------------------------------------------------------------

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
  array[i] = new Random().Next(100, 1001);                 // [100, 1000]
Console.Write($"[{string.Join(", ", array)}] -> ");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i] % 2 == 0)
  {
    count++;
  }
}
Console.WriteLine($"{count}");
