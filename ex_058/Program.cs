/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Clear();

int[,] matrix1 = new int[,] // создаём двумерный массив 1
{
{2, 4},
{3, 2}
};

int[,] matrix2 = new int[,] // создаём двумерный массив 2
{
{3, 4},
{3, 3}
};

int[,] matrix3 = new int[2,2]; // создаём двумерный массив 2


void PrintArray(int[,] matr) // функция вывода двумерного массива
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

void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] matrix3) // функция перемножения
{
  for (int i = 0; i < matrix3.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        sum += matrix1[i,k] * matrix2[k,j];
      }
      matrix3[i,j] = sum;
    }
  }
}

PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);

MultiplyMatrix(matrix1, matrix2, matrix3);
Console.WriteLine($"\nПроизведение первой и второй матриц:");

PrintArray(matrix3);