// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Пример:
    1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/
// --------------------------------------------------------------

// --------------------------------------------------------------
int[] ar = new int[8];
for (int i = 0; i < ar.Length; i++)
{
  Console.Write($"{ar[i]} ");
}
Console.WriteLine($" -> [{string.Join(", ", ar)}]");
Console.WriteLine();

// --------------------------------------------------------------
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
Console.Write($"{arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]}, {arr[6]}, {arr[7]} -> ");

Console.Write($"[{arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]}, {arr[6]}, {arr[7]}]");
Console.WriteLine();
Console.WriteLine();

// --------------------------------------------------------------

// int[] arra = new int[8];
// for (int i = 0; i < arra.Length; i++)
// {
//   // Console.Write($"Введите {i + 1}-е число: ");
//   // int n = int.Parse(Console.ReadLine()!);
//   int n = Convert.ToInt32(Console.ReadLine());
//   arra[i] = n;
//   // Console.Write($"{arra[i]} ");
// }
// Console.WriteLine($" -> [{string.Join(", ", arra)}]");

// --------------------------------------------------------------
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(10, 100);    // [10, 99]
  Console.Write($"{array[i]}, ");
}
Console.WriteLine($" -> [{string.Join(", ", array)}]\n");

// --------------------------------------------------------------
int[] arrayA = new int[8];
for (int i = 0; i < arrayA.Length; i++)
{
  arrayA[i] = new Random().Next(10, 100);    // [10, 99]
  // Console.Write($"{arrayA[i]}, ");
}
Console.Write($"{string.Join(", ", arrayA)}");
Console.WriteLine($" -> [{string.Join(", ", arrayA)}]\n");

// --------------------------------------------------------------

