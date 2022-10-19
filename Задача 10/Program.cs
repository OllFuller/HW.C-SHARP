/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Clear();
Console.WriteLine("Введите число!");
int num = int.Parse(Console.ReadLine()!);

if (num < 10)

{
    num = num / 10;
}

int result = num / 10 % 10;

Console.Write($"вторая цифра в числе {num} -> {result}");



