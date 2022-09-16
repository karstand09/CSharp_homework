Console.Clear();

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int Max = Math.Max(a, b);
int Min = Math.Min(a, b);

Console.WriteLine($"Большее число: {Max}");
Console.WriteLine($"Меньшее число: {Min}");