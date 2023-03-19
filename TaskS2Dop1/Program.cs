// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
// --------------------------------------------------------------
/*
-- Второй максимум --
Задана последовательность натуральных чисел, завершающаяся числом 0. Требуется определить значение второго по величине элемента в этой последовательности, то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.

https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=3&id_topic=35&id_problem=223
*/
// --------------------------------------------------------------
// --------------------------------------------------------------



Console.Clear();
int n = Convert.ToInt32(Console.ReadLine()), max1 = n, max2 = 0;
while (n != 0)
{
  n = Convert.ToInt32(Console.ReadLine());
  if (n > max1)
  {
    max2 = max1;
    max1 = n;
  }
  else if (n > max2)
  {
    max2 = n;
  }
}
Console.WriteLine(max2);