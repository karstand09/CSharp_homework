// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

int [] arr = new int [8];

int i = 0;
while (i < arr.Length)
{
  arr [i] = new Random().Next(0, 99);
  Console.Write(arr[i] + " ");
  i++;
}

Console.WriteLine();

void PrintArray(int[] array) // функция вывода массива на экран
{
  int count = array.Length;

  for (int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

void SelectionSort(int[] array) // функция сортировки из лекции
{
  for (int i = 0; i < array.Length - 1; i++)
  {
    int minPosition = i;

    for (int j = i + 1 ; j < array.Length; j++)
    {
      if (array[j] < array[minPosition]) 
      {
        minPosition = j;
      }  
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
  }
}

SelectionSort(arr);
PrintArray(arr);