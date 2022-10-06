//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

int InputIntNumber()
{
    while(true)
    try
    {
        Console.WriteLine("Please, enter an integer number ");
        int num = int.Parse(Console.ReadLine() ?? "0");
        return num;
    }

    catch
    {
        Console.WriteLine("Something went wrong, please enter an integer number");
    }
}

int num = InputIntNumber();

int sum(int num)
{
    int counter = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = num - num % 10;
        result = result + (num - advance);
        num = num / 10;
    }
   return result;
}

int answer = sum(num);
Console.WriteLine("Sum is " + answer);