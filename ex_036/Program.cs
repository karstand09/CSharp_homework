// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

Console.Clear();

int [] arr = new int [10]; // создаём пустой массив на 10 ячеек


for (int i = 0; i < arr.Length; i++) // наполняем массив рандомными числами
{
    arr [i] = new Random().Next(0, 100);
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

void SumOddElements(int[] array) // функция суммы элементов, стоящих на нечетных позициях
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) 
        {
            result = result + array[i];
        }
    }
    Console.Write($"Sum  = {result} ");
}

PrintArray(arr);
SumOddElements(arr);