// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// Необходимо сложить 2 числа с помощью рекурсии
int f(int a, int b)
{
  if (a == 0)
    return b;
  Console.WriteLine((a - 1, b + 1));
  return f(a - 1, b + 1);
}

Console.Clear();
Console.WriteLine(f(5, 4));

/*
f(5, 4) -> f(4, 5) -> f(3, 6) -> f(2, 7) -> f(1, 8) -> f(0, 9) -> 9
*/