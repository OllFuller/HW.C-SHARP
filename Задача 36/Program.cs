/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void OddNumArray(int[] array)
{
    
    int sum = 0;
    for (int i = 0; i < array.Length-1; i+=2)
    {
        if ( array[i] > sum );
        {
            sum = sum + array[i];
        }

    }
    Console.WriteLine($"Сумма нечет. чисел -> {sum}");
    

   


    
}
int[] array = GetArray(4, 0, 100);
Console.WriteLine($"[{string.Join(", ", array)}]");
OddNumArray(array);
