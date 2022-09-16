Console.Clear();

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if(a == b)
{
    Console.WriteLine("Числа равны");
}
else
{
    int Max = Math.Max(a, b);
    int Min = Math.Min(a, b);

    Console.WriteLine($"Большее число: {Max}");
    Console.WriteLine($"Меньшее число: {Min}");
}