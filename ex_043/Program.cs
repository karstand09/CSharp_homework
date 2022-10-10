// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

void InterSection()
{
    Console.Write("\nEnter b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("\nEnter k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("\nEnter b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("\nEnter k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;

    Console.WriteLine("\nIntersection: [ {0} : {1} ]", Math.Round(x, 2), Math.Round(y,2));
}

InterSection();