// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

double[,] matrix = new double[,] 
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
};

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

void columnAverage(double[,] matr) // функция нахождения среднего арифметического по столбцам
{   
    for (int row = 0; row < matrix.GetLength(1); row++)
    {
    double average = 0;
    for (int col = 0; col < matrix.GetLength(0); col++)
    {
        average = average + matrix[col, row];
    }
    Console.Write(Math.Round(average / matrix.GetLength(0), 1));
    Console.Write(" ");
    }
}

PrintArray(matrix);
Console.WriteLine();
columnAverage(matrix);