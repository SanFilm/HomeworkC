// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача : 
Пример:
    
*/
// --------------------------------------------------------------

// Денис
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int countDel = 0, i, j, k, m;
for (i = 3; i <= n / 2; i += 2)
{
  countDel = 0;
  for (j = 2; j <= Math.Sqrt(i) + 1; j++)
  {
    if (i % j == 0)
      countDel++;
  }
  if (countDel == 0)
  {
    m = n - i;
    for (k = 2; k <= Math.Sqrt(m) + 1; k++)
    {
      if (m % k == 0)
        countDel++;
    }
    if (countDel == 0)
    {
      Console.WriteLine($"{i} {m}");
      // return;
    }
  }
}