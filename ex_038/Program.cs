// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double [] arr = new double [10]; // создаём пустой массив на 10 ячеек

for (int i = 0; i < arr.Length; i++) // наполняем массив рандомными числами
{
    arr [i] = new Random().NextDouble();
}

void PrintArray(double[] array) // функция вывода массива на экран
{
  int count = array.Length;

  for (int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

void DiffMaxMin(double[] array) // функция нахождения разницы, между максимальным и минимальным значением элементов массива
{
    double Max = arr.Max();
    double min = arr.Min();
    double diff = Max - min;
    Console.Write($"Diff  = {diff} ");
}

PrintArray(arr);
DiffMaxMin(arr);