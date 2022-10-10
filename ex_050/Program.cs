/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

int[,] matrix = new int[,] 
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
};

void PrintArray(int[,] matr) // функция вывода массива
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

void searchPosition(int[,] matr) // функция поиска элемента массива
{
    Console.Write("\nПоиск элемента в заданном массиве:\n");
    bool repeat = true;
    while (repeat)
    {
        Console.Write("\nВведите индекс строки: ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nВведите индекс столбца: ");
        int col = Convert.ToInt32(Console.ReadLine());

        try
        {
            Console.Write("\nЭлемент с заданным индексом: {0} \n", (matr[row, col]));
        }
        catch (IndexOutOfRangeException)
        {
            Console.Write("\nЭлемент с таким индексом не существует!");
        }
        Console.WriteLine("\n");
    }
}
PrintArray(matrix);
searchPosition(matrix);