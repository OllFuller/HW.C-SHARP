﻿/*
Задача 23: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
*/

void GetString( int n )

{
    int index = 1;
    
    while ( index <= n )
    {
        Console.Write($"{index * index * index},");
        index++;
    }
     

    
    
} 
Console.Clear();
Console.Write("Введите число N:");
int num = int.Parse(Console.ReadLine()!);
Console.Write($" {num} -> {num}");
GetString(num);