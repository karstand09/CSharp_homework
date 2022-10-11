/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */


Console.Clear();

int[,] matrix = new int[,] // создаём двумерный массив
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
};

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

void SortMatrix(int[,] matr) // функция сортировки двумерного массива
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      for (int k = 0; k < matr.GetLength(1) - 1; k++)
      {
        if (matr[i, k] < matr[i, k + 1])
        {
          int temp = matr[i, k + 1];
          matr[i, k + 1] = matr[i, k];
          matr[i, k] = temp;
        }
      }
    }
  }
}


PrintArray(matrix);
Console.WriteLine();
SortMatrix(matrix);
PrintArray(matrix);