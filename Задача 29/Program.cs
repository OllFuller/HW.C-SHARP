/*
Задача 29: Напишите программу, которая задаёт массив из 8
элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int[] GetArray()

{



    int[] a = new int[8];
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write("Введите число масcива: ");
        a[i] = int.Parse(Console.ReadLine()!);
    }

    Console.WriteLine();
    Console.Write(String.Join(",", a));
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i]);
    }
    return a;

}
Console.WriteLine(GetArray());
