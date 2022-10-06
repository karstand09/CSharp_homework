//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

int InputIntNumberA()
{
    while (true)
    try
        {
            Console.Write("Enter number A: ");
            int A = int.Parse(Console.ReadLine() ?? "0");
            return A;
        }
        catch 
        {
            Console.WriteLine("Something went wrong! Please, enter integer");
        }
}

int InputIntNumberB()
{
    while (true)
    try
        {
            Console.Write("Enter number B: ");
            int B = int.Parse(Console.ReadLine() ?? "0");
            return B;
        }
        catch 
        {
            Console.WriteLine("Something went wrong! Please, enter integer");
        }
}

int A = InputIntNumberA();
int B = InputIntNumberB();

int Pow(int A, int B)
{
    int result = 1;

    for(int i = 1; i<= B; i++)
    {
        result = result * A;
    }
    return result;
}

int pow = Pow(A, B);

Console.Write("Result is " + pow);