/* Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Clear();

Console.WriteLine("Введите номер дня недели");
int num = int.Parse(Console.ReadLine()!);

if (num > 1 || num < 5)
{
    Console.WriteLine($"{num} -> Нет");
}



while (num > 6 || num < 7)
{
    Console.WriteLine($"{num} -> Да");
}









