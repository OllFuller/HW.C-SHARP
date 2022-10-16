/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Вас, приветствует программа Min/Max");
Console.WriteLine("Ввидете 2  числа");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int max,min;

if (a > b)
{
    max =a;
}
else
{
    max = b;
}
if (a < b)
{
   min = a; 
}
else
{
    min = b;
}

Console.WriteLine("Минимальное значение:" + min);
Console.WriteLine("Максимальное значение:" + max );