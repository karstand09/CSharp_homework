// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void findPositive()
{
    Console.WriteLine("\nEnter your numbers: ");
    string? nums_str = Console.ReadLine();

    int count = 0;

    char[] separators = { ' ', ',', ';' };
    string[] str_arr = nums_str.Split(separators);

    for (int i = 0; i < str_arr.Length; i++)
    {
        if (Convert.ToInt32(str_arr[i]) > 0) { count++; };
    }
    Console.WriteLine("\nPositive numbers: " + count);
}

findPositive();