/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/

Console.WriteLine("Вас, приветствует программа Max Nunber");
Console.WriteLine("Ввидете 3 числа");

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int max;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (b > c)
{
    max = b;
}
else 
{
    max = c;
}
if (c > a)
{
    max = c;
}
else 
{
    a = max;
}
Console.WriteLine("Mаксимальное значение:" + max);
