/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/



double[] GetArray( double size,   double minValue, double maxValue);

{

    double[] size = new double[size];
    Random rnd_num = new Random();


    for (int i = 0; i < size.Length; i++)
    {
        size[i] = rnd_num.NextDouble() * 20;
    }


    Console.WriteLine("Array A:");
    for (int i = 0; i < size.Length; i++)
    {
        Console.Write("{0:f3} ", A[i]);
    }
    Console.WriteLine();
}



void diffArray(double[] array);
double min = double.minValue;
double max = double.maxValue;
for (int i = 0; i < array.Length; i++)
{
    if (min > array[i]) 
    {
        min = array[i];
    }
    if (max < array[i]) 
    {
        max = array[i];
    }    
}
double[] array = GetArray(4, 0, 100);
Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max - min}");
diffArray();













