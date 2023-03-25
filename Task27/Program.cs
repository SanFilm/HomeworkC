// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача : Напишите программу, которая принимает на вход число и выдаёт сумму цифр этого числа.
Пример:
    452 -> 11
    82 -> 10
    9012 -> 12
*/
// --------------------------------------------------------------

//   for   //

Console.Write("Введите ЦИФРЫ: ");
string p = Console.ReadLine()!;
int sum = 0;
for (int i = 0; i < p.Length; i++)
  // sum = sum + Convert.ToInt32(p[i].ToString());
  sum += Convert.ToInt32(p[i].ToString());
Console.WriteLine($"Сумма ведённых цифр = {sum}");


//   while   //

Console.Write("Введите ЦИФРЫ: ");
string pp = Console.ReadLine()!;
int summ = 0, count = 0;
while (count < pp.Length)
{
  summ += Convert.ToInt32(pp[count].ToString());
  count++;
}
Console.WriteLine($"Сумма ведённых цифр = {summ}");