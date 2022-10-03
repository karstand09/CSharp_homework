Console.Clear();

Console.WriteLine("Введите трехзначное число.\nДля выхода из программы введите комунду exit.");

while(true)
{
    string num = Console.ReadLine();
    if(!num.Equals("exit"))
        Console.WriteLine("{0}->{1}",num, num[1]);
    else
        break;
}