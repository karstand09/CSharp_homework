// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

int [] arr = new int [8]; // создаём пустой массив на 8 ячеек


for (int i = 0; i < arr.Length; i++) // наполняем массив рандомными числами
{
    arr [i] = new Random().Next(0, 99);
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

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);