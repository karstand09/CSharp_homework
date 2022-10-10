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

void CountPositive(int[] array) // функция подсчёта положительных чисел
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 1) 
        {
            count = count + 1;
        }
    }
    Console.Write($"Count of positive numbers = {count} ");
}

PrintArray(arr);
CountPositive(arr);