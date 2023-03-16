// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
// --------------------------------------------------------------
/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/
// --------------------------------------------------------------
// --------------------------------------------------------------

Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a != b)
{
  if (a > b)
  {
    Console.WriteLine($"Результат: {a} > {b}");
  }
  else
  {
    Console.WriteLine($"Результат: {b} > {a}");
  }
}
else
{
  Console.WriteLine($"Результат: {b} = {a}");
}

