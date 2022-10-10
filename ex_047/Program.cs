// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int InputCol() // проверка на число
{
    while (true)
    try
        {
            Console.Write("\nEnter number of columns: ");
            int col = int.Parse(Console.ReadLine() ?? "0");
            return col;
        }
        catch 
        {
            Console.WriteLine("Something went wrong! Please, enter an integer number");
        }
}

int InputRow() // проверка на число
{
    while (true)
    try
        {
            Console.Write("\nEnter number of rows: ");
            int row = int.Parse(Console.ReadLine() ?? "0");
            return row;
        }
        catch 
        {
            Console.WriteLine("Something went wrong! Please, enter an integer number");
        }
}

void PrintArray(double[,] matr) // функция вывода массива
{
    for (int row = 0; row < matr.GetLength(0); row++)
    {
        for (int col = 0; col < matr.GetLength(1); col++)
            {
                Console.Write($"{matr[row, col]} ");
            }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr) // функция заполнения массива вещественными числами
{
    for (int row = 0; row < matr.GetLength(0); row++)
    {
        for (int col = 0; col < matr.GetLength(1); col++)
        {
            matr[row, col] = Math.Round(new Random().NextDouble() * 100, 2);
        }
    } 
}


int row = InputRow();
int col = InputCol();

double[,] matrix = new double[row, col];

FillArray(matrix);
PrintArray(matrix);