Console.WriteLine("Задача 64");
Console.Write("Введите целое положительное число: ");
try
{
    int n = Convert.ToInt32(Console.ReadLine());
    if (n > 0 )
    {
        Console.Write("Натуральные числа от " + n.ToString() + " до 1: ");
        PrintAllNatural(n);
    }
    else
        Console.Write("Вы ввели неверное число: ");
}
catch
{
    Console.Write("Вы ввели неверное число: ");
}
void PrintAllNatural(int i)
{
    if (i>1)
    {
        Console.Write(i.ToString() + ", ");
        PrintAllNatural(i- 1);
    }
    else
        Console.Write("1");
}
