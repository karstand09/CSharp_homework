//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

int InputIntNumber()
{
    while (true)
    try
        {
            Console.Write("Ведите число от 10000 до 99999: ");
            int number = int.Parse(Console.ReadLine() ?? "0");
            while (number > 9999 && number < 100000)
            return number;
        }
        catch 
        {
            Console.WriteLine("Ошибка, введите целое число!");
        }
}

int num = InputIntNumber();

void isPalindrome()
{
    string chars = num.ToString();
    if (chars[0] == chars[4] && chars[1] == chars[3])
    {
        Console.Write("Palindrome");
    }
    else
    {
        Console.Write("No palindrome");
    }
}

isPalindrome();