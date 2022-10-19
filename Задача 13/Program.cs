/* Задача 13: Напишите программу, которая выводит
третью цифру (справа налево) заданного числа или
сообщает, что третьей цифры нет.
645 -> 6
78 -> третьей цифры нет
32679 -> 6 
*/

Console.Clear();
Console.WriteLine("Введите число!");

int number = int.Parse(Console.ReadLine()!);
int third = number / 100 % 10;
int result = third;
if (third < number)
{
    Console.WriteLine("-> третьей цифры нет");
}
Console.WriteLine($"третья цифра в числе {number} -> {result}");


.
