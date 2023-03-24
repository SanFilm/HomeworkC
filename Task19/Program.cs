// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Пример:
    14212 -> нет
    12821 -> да
    23432 -> да
*/
// --------------------------------------------------------------
// Денис
Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 10000 || n > 99999)
{
  Console.Write("Вы ошиблись!\nВведите число: ");
  n = int.Parse(Console.ReadLine()!);
}
int n1 = n / 10000;
int n2 = (n / 1000) % 10;
int n4 = (n % 100) / 10;
int n5 = n % 10;
Console.WriteLine($"{n1}, {n2}, _, {n4}, {n5}");
if (n1 == n5 && n2 == n4)
  Console.WriteLine("Да, это палиндром.");
else
  Console.WriteLine("Нет, это не палиндром.");