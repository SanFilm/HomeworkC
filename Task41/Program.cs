// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача : Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Пример:
    0, 7, 8, -2, -2 -> 2
    -1, -7, 567, 89, 223-> 3
*/

// --var.1 - БЕЗ МАССИВА-----------------------------------------

Console.Write("Введите кол-во элементов: ");
int m = int.Parse(Console.ReadLine()!);
  // Console.WriteLine(m);
int r = 0, cnt=0;
for (int i = 0; i < m; i++)
{
  r = new Random().Next(-10, 10);
  Console.Write($"{r}, ");
  if (r>0)
    cnt++;
}
Console.WriteLine($"\n{cnt} - количество значений больше 0\n");
// --------------------------------------------------------------

// --var.2 - С МАССИВОМ------------------------------------------

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
  array[i] = new Random().Next(-10, 11);              // [-10, 10]
Console.WriteLine($"[{string.Join(", ", array)}] -> ");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array [i] > 0)
  {
    Console.Write($"{i}-");
    Console.Write($"{array[i]}, ");
    count++;
  }
}
    Console.WriteLine($" - индексы и их значения больше 0.");
// Console.WriteLine($"\n{count}");
Console.WriteLine($"\n{count} - количество значений больше 0\n");

// --------------------------------------------------------------
