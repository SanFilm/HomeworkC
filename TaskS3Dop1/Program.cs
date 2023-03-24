// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/* 
Задача + ( доп. ):
В фермерском хозяйстве в Карелии выращивают чернику. Она растет на круглой грядке, причем кусты высажены только по окружности. Таким образом, у каждого куста есть ровно два соседних. Всего на грядке растет N кустов...

Подробнее: https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=113&id_problem=695
Пример:
*/
// --------------------------------------------------------------

// Денис
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int max = 0;
for (int i = 1; i < array.Length - 1; i++)
{
    if (max < array[i - 1] + array[i] + array[i + 1])
        max = array[i - 1] + array[i] + array[i + 1];
}
if (max < array[0] + array[array.Length - 1] + array[array.Length - 2])
    max = array[0] + array[array.Length - 1] + array[array.Length - 2];
if (max < array[0] + array[1] + array[array.Length - 1])
    max = array[0] + array[1] + array[array.Length - 1];
Console.WriteLine(max);
