/*
Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B. Реализовать функцию возведения в степень
самостоятельно!
*/

int GetNum(int a, int b)
{
    
	int result = a;
	for (int i = 0; i < b; i++)
	{
		result *= a;
	}
	return result;
}


Console.Clear();

Console.Write("Введите чсло A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите чсло B: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetNum(a,b));