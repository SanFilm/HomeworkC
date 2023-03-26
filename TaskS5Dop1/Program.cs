// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
Задача : Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть, чтобы оставаться ударником. В текущей четверти Вася заметил следующую закономерность: по нечетным дням месяца он получал тройки, а по четным – четверки. Так же он помнит, в какие дни он получал эти оценки. Поэтому он выписал на бумажке все эти дни для того, чтобы оценить, сколько у него троек и сколько четверок. Помогите Васе это сделать, расположив четные и нечетные числа в разных строчках. Вася может рассчитывать на оценку 4, если четверок не меньше, чем троек.

Подробнее: https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=114&id_problem=703
Пример:
    5                       |   19 31
    4 16 19 31 2            |   4 16 2
                            |   YES

    8                       |   29 7 15 17 1
    29 4 7 12 15 17 24 1    |   4 12 24
                            |   NO
*/
// --------------------------------------------------------------

// Денис //
int n = Convert.ToInt32(Console.ReadLine());
int[] array = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int countEven = 0, countOdd = 0;
foreach (int element in array)
{
  if (element % 2 == 1)
  {
    Console.Write($"{element} ");
    countEven++;
  }
}
Console.WriteLine();
foreach (int element in array)
{
  if (element % 2 == 0)
  {
    Console.Write($"{element} ");
    countOdd++;
  }
}
Console.WriteLine();
if (countOdd >= countEven)
  Console.WriteLine("YES");
else
  Console.WriteLine("NO");
