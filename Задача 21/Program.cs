/*
Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double GetLen( double  x1, double y1, double z1, double x2, double y2, double z2  )
{
   double result =  Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 -z1),2));
   return result;
}
Console.Clear();
double X1 = double.Parse(Console.ReadLine()!);
double Y1 = double.Parse(Console.ReadLine()!);
double Z1 = double.Parse(Console.ReadLine()!);
double X2 = double.Parse(Console.ReadLine()!);
double Y2 = double.Parse(Console.ReadLine()!);
double Z2 = double.Parse(Console.ReadLine()!);
double Z = GetLen(X1,Y1,Z1,X2,Y2,Z2);

Console.WriteLine(Z);