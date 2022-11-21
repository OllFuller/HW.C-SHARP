/*
Задача 50. Напишите программу, которая на вход принимает число и ищет его в двумерном массиве. 
Программа должна возвращать значение позиции (номер строки и столбца) этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void FindNumberInArray(int[,] array)



    
      {

        for (int i = 1; i < array.GetLength(0); i++)
        {
            for (int j = 1; j < array.GetLength(1); j++)
            {
                Console.WriteLine("Введите число!");
                int num = int.Parse(Console.ReadLine()!);

                if (num > array[i, j])

                {
                    num = array[i, j];
                }
                else
                {

                    num = num;
                }

                

                Console.WriteLine($" {num} -> такого числа нет");

                

            

        }
        
      }
      }
      





        Console.Clear();
        Console.Write("Введите кол-во строк: ");
        int rows = int.Parse(Console.ReadLine()!);
        Console.Write("Введите кол-во столбцов: ");
        int cols = int.Parse(Console.ReadLine()!);


        int[,] WorkingArray = GetArray(rows, cols, 0, 10);
        PrintArray(WorkingArray);
        

        FindNumberInArray(WorkingArray);

