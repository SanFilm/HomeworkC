// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");
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

