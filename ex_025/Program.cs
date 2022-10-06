//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

int Pow(int A, int B)
{
    int result = 1;

    for(int i = 1; i<= B; i++)
    {
        result = result * A;
    }
    return result;
}

Console.Write("Enter number A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number B: ");
int B = Convert.ToInt32(Console.ReadLine());

int pow = Pow(A, B);

Console.Write("Result is " + pow);