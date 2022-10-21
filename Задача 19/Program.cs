/*
Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/
Console.Clear();
Console.Write("Введите число: ");


void CheckingNumber (string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} - да, палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - нет, не палиндром.");
}
string number = (Console.ReadLine()!);
CheckingNumber(number);



