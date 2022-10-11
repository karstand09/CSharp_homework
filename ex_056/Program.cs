/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Clear();

int[,] matrix = new int[,] // создаём двумерный массив
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
{5, 2, 6, 7},
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
PrintArray(matrix);

int SumLineElements(int[,] matrix, int i)
{
  int sumLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumLine += matrix[i,j];
  }
  return sumLine;
}

int minSumLine = 0;
int sumLine = SumLineElements(matrix, 0);

for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(matrix, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - Minumal sum of row {sumLine} ");