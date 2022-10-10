// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int [] arr = new int [10]; // создаём пустой массив на 10 ячеек


for (int i = 0; i < arr.Length; i++) // наполняем массив рандомными трехзначными числами
{
    arr [i] = new Random().Next(100, 999);
}

void PrintArray(int[] array) // функция вывода массива на экран
{
  int count = array.Length;

  for (int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

void SumPositive(int[] array) // функция суммы положительных чисел
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 1) 
        {
            result = result + array[i];
        }
    }
    Console.Write($"Sum of positive numbers = {result} ");
}

PrintArray(arr);
SumPositive(arr);