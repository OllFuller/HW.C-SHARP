/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).*/

Console.WriteLine("Вас приветствует программа ЧЕТ/НЕЧЕТ");
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
if (a % 2==1)
{
    Console.WriteLine("ЧЕТ");
}
else 
{
    Console.WriteLine("НЕЧЕТ");
}
