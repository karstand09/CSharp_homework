﻿Console.Clear();

Console.Write("Введите ваше число: ");
int a = int.Parse(Console.ReadLine());

if(a % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Не четное");
}