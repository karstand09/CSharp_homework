/* Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.

M = 28; N = 7 -> 7 */

Console.Clear();

int InputIntNumberM()
{
    while (true)
    try
        {
            Console.Write("Enter number M: ");
            int M = int.Parse(Console.ReadLine() ?? "0");
            return M;
        }
        catch 
        {
            Console.WriteLine("Something went wrong! Please, enter an integer number");
        }
}

int InputIntNumberN()
{
    while (true)
    try
        {
            Console.Write("Enter number N: ");
            int N = int.Parse(Console.ReadLine() ?? "0");
            return N;
        }
        catch 
        {
            Console.WriteLine("Something went wrong! Please, enter an integer number");
        }
}

int M = InputIntNumberM();
int N = InputIntNumberN();

void Recursion(int M, int N)
{
    if (M > N)
    {
        M = M % N;
    }
    else
    {
        N = N % M;
    }
    if (M != 0 && N != 0)
    {
        Recursion(M, N);
    }
    else
    {
        Console.WriteLine("NOD "+ (M+N).ToString());
    }
}

Recursion(M, N);