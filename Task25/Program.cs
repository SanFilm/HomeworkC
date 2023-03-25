// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача : Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Пример:
    3, 5 -> 243 (3⁵)
    2, 4 -> 16
*/
// --------------------------------------------------------------

//   for   //

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int b = Convert.ToInt32(Console.ReadLine());
// int a = 3, b = 5;
int c = 1;
for (int i = 1; i <= b; i++)
{
  c *= a;
  Console.Write($"{c} ");
}
Console.Write($"{c} ");
Console.WriteLine();


//   while   //

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int y = Convert.ToInt32(Console.ReadLine());
int z = 1, count = 1;
while (count <=y)
{
  z *= x;
  count++;
Console.Write($"{z} ");
}
Console.Write($"{z} ");
Console.WriteLine();
