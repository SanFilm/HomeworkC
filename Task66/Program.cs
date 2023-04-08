// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Пример:
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
*/
// --------------------------------------------------------------

// int SumFor(int n)
// {
//   int result = 0;
//   for (int i = 1; i <= n; i++) result += i;
//   return result;
// }
// int SumRec(int n)
// {
//   if (n == 0) return 0;
//   else return n + SumRec(n - 1);
// }
// Console.WriteLine(SumFor(10)); // 55
// Console.WriteLine(SumRec(10)); // 55


Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\n");
Console.Write("Задайте значение M > 0: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Задайте значение N > M: ");
int n = int.Parse(Console.ReadLine()!);

// Итеративно, через 'For'                                        //
int SumFor(int m, int n)
{
  int result = 0;
  for (int i = m; i <= n; i++) result += i;
  return result;
}
Console.WriteLine(SumFor(m, n));
//                                        Итеративно, через 'For' //
// ! Через Рекурсию.  -  НА УМЕНЬШЕНИЕ                            //
int result = n;
int SumRecMN_1(int m, int n)
{
  if (m == n) return 0;
  else return result = n + SumRecMN_1(m, n - 1);    // ! НА УМЕНЬШЕНИЕ
}
Console.WriteLine(SumRecMN_1(m - 1, n));
//                                                Через Рекурсию. //


/*         if    (m == n) ...;    // !    ( m )
...(SumRecMN_1   (m - 1, n));     // !    ( m - 1 )
*/
// ! Если уменьшать число 'N', можно писать как верхний, так и нижний вар.

/*         if    (m - 1 == n) ... // !    ( m - 1 )
...(SumRecMN_2   (m, n));         // !    ( m )
*/


// ! Через Рекурсию.  -  НА УМЕНЬШЕНИЕ                            //
int resultat = n;
int SumRecMN_2(int m, int n)
{
  if (m - 1 == n) return 0;
  else return resultat = n + SumRecMN_2(m, n - 1);    // ! НА УМЕНЬШЕНИЕ
}
Console.WriteLine(SumRecMN_2(m, n));
//                                                Через Рекурсию. //
// ! Через Рекурсию.  -  НА УВЕЛИЧЕНИЕ                            //
int res = m;
int SumRecNM(int m, int n)
{
  if (m == n) return 0;
  else
  {
    m++;                                          // ! НА УВЕЛИЧЕНИЕ
    return result = m + SumRecNM(m, n);
  }
}
Console.WriteLine(SumRecNM(m - 1, n));
//                                                Через Рекурсию. //
