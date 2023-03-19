// Очистка консоли.
Console.Clear();
// --------------------------------------------------------------

/* Sem_3_c# */

// --------------------------------------------------------------
// Console.Clear();
// string n = Console.ReadLine()!;
// // Необходимо сумму цифр числа
// int sum = 0;
// for (int i = 0; i < n.Length; i++)
//     sum = sum + Convert.ToInt32(n[i].ToString());
// Console.WriteLine(sum);
// --------------------------------------------------------------
// Задача 17 - DEMO 3
// Console.Clear();
// Console.Write("Введите координату X: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// double y = Convert.ToDouble(Console.ReadLine());
// while (x == 0)
// {
//   Console.Write("Вы ошиблись!\nВведите координату X: ");
//   x = Convert.ToDouble(Console.ReadLine());
// }
// while (y == 0)
// {
//   Console.Write("Вы ошиблись!\nВведите координату Y: ");
//   y = Convert.ToDouble(Console.ReadLine());
// }
// if (x > 0 && y > 0)
//   Console.WriteLine("I");
// else if (x < 0 && y > 0)
//   Console.WriteLine("II");
// else if (x < 0 && y < 0)
//   Console.WriteLine("III");
// else
//   Console.WriteLine("IV");
// --------------------------------------------------------------
// Задача 18
// Мой код.
// Console.Write("Введите четверть плоскости: ");
// int x = Convert.ToInt32(Console.ReadLine());

// if (x == 1)
//   Console.WriteLine("x > 0 && y > 0");
// else if (x == 2)
//   Console.WriteLine("x < 0 && y > 0");
// else if (x == 3)
//   Console.WriteLine("x < 0 && y < 0");
// else
//   Console.WriteLine("x > 0 && y < 0");

// Учитель

// Console.Clear();
// Console.Write("Введите номер четверти: ");
// int x = Convert.ToInt32(Console.ReadLine());
// while (x < 1 || x > 4)
// {
//   Console.Write("Вы ошиблись!\nВведите номер четверти: ");
//   x = Convert.ToInt32(Console.ReadLine());
// }
// if (x == 1)
//   Console.WriteLine("x > 0 and y > 0");
// else if (x == 2)
//   Console.WriteLine("x < 0 and y > 0");
// else if (x == 3)
//   Console.WriteLine("x < 0 and y < 0");
// else
//   Console.WriteLine("x > 0 and y < 0");
// --------------------------------------------------------------
// Console.Clear();
// Console.Write("Введите координату X(1): ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату X(1): ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату X(1): ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату X(1): ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// double s = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
// Console.WriteLine($"Расстояние между двумя точками равно {Math.Round(s, 2)}");
// --------------------------------------------------------------
// Задача 22
// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < x; i++)
// {
//   Console.Write($"{i} ");
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
//   Console.Write($"{i * i} ");
// --------------------------------------------------------------

// Sem 4
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (n > 0)
{
  n = n / 10;
  i++;
}

Console.WriteLine(i);