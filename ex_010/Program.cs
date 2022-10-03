int InputIntNumber()
{
    while (true)
    {
        Console.Write("Ведите трёхзначное число: ");
        int number = int.Parse(Console.ReadLine() ?? "0");
        while (number > 99 && number < 1000)
        return number;
    }
}
int Num = InputIntNumber();

int firstNum = Num / 100;
int secondNum = Num / 10 % 10;
int thirdNum = Num % 10;

Console.WriteLine(secondNum);