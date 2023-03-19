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

// --------------------------------------
// inet 1
Console.Write("Введи число: ");
int m = Convert.ToInt32(Console.ReadLine());
string mText = Convert.ToString(m);
if (mText.Length > 2)
{
  Console.WriteLine("Третья цифра слева: " + mText[2]);
}
else
{
  Console.WriteLine("Третьей цифры нет.");
}

  Console.WriteLine("");
// --------------------------------------
// Денис
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
  Console.WriteLine("Третьей цифры нет");
else
{
  while (n > 1000)
  {
    n = n / 10;
    Console.WriteLine($"{n}");         // Как это работает.
  }
  Console.WriteLine($"Третья цифра слева: {n % 10}");
}