//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.WriteLine("Введите число.\nДля выхода из программы введите комунду exit.");

while(true)
{
    string num = Console.ReadLine();
    int strLen = num.Length;

    if(!num.Equals("exit"))
        Console.WriteLine("{0}->{1}",num, num[1]);

    else
        break;
}