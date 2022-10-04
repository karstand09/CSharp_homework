//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.Write("Введите AX: ");
double AX = double.Parse(Console.ReadLine());

Console.Write("Введите AY: ");
double AY = double.Parse(Console.ReadLine());

Console.Write("Введите AZ: ");
double AZ = double.Parse(Console.ReadLine());

Console.Write("Введите BX: ");
double BX = double.Parse(Console.ReadLine());

Console.Write("Введите BY: ");
double BY = double.Parse(Console.ReadLine());

Console.Write("Введите BZ: ");
double BZ = double.Parse(Console.ReadLine());

double coord = Math.Sqrt(Math.Pow(AX - BX, 2) + Math.Pow(AY - BY, 2) + Math.Pow(AZ - BZ, 2));

Console.WriteLine("расстояние между двумя точками " + (Math.Round(coord, 2)));