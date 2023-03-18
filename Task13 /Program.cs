// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
// --------------------------------------------------------------
/* э
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/
// --------------------------------------------------------------
// --------------------------------------------------------------

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// // int n1 = n / 10 % 10;
// if (n / 100 == 0)
//   Console.Write("Третьей цифры нет !!!");

// int n1 = n / 100;
// int n2 = n1 % 10;
// Console.Write($"{n},, ");
// Console.Write($"{n1}, ");
// Console.WriteLine($"{n2}, ");

// --------------------------------------
// inet 1
Console.Write("Введи число: ");
int n = Convert.ToInt32(Console.ReadLine());
string nText = Convert.ToString(n);
if (nText.Length > 2)
{
  Console.WriteLine("Третья цифра слева: " + nText[2]);
}
else
{
  Console.WriteLine("Третьей цифры нет.");
}

// --------------------------------------
// inet 2
// 