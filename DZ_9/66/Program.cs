Console.WriteLine("Задача 66");
Console.Write("Введите первое натуральное число: ");
try
{
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе натуральное число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    if (n <= 0 || m <= 0)
        Console.Write("Вы ввели неверное число: ");
    else
    {
        if (n > m) (m, n) = (n, m);
        Console.Write("Сумма натуральных чисел в промежутке от " + n.ToString() + " до " + m.ToString() + ": ");
        SumAllNatural(n, m);
    }
}
catch
{
    Console.Write("Вы ввели неверное число: ");
}
void SumAllNatural(int min, int max, int sum = 0)
{
    int s = sum + min;
    if (min < max)
    {
        SumAllNatural(min+1, max, s);
    }
    else
        Console.Write(s.ToString());
}
 
