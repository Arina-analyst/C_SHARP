Console.WriteLine("Задача 68");
Console.Write("Введите первое неотрицательное число: ");
try
{
    long n = Convert.ToInt64(Console.ReadLine());
    Console.Write("Введите второе неотрицательное число: ");
    long m = Convert.ToInt64(Console.ReadLine());
    if (n < 0 || m < 0)
        Console.Write("Вы ввели неверное число: ");
    else
    {
        Console.Write("Значение функции Аккермана A(" + n.ToString() + ", " + m.ToString() + ") = ");
        Console.Write(A(n, m).ToString());
    }
}
catch
{
    Console.Write("Вы ввели неверное число: ");
}
long A(long n, long m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return A(n - 1, 1);
    else
        return A(n - 1, A(n, m - 1));
}
