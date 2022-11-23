/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

Console.WriteLine("Задача 25");
try 
{
    Console.Write("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите степень: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write(a.ToString() + " в степени " + b.ToString() + " = " + GetPov(a, b) + " ");
}
catch
{
    Console.WriteLine("Вы ввели неверное число");
}
 
string GetPov(int n, int m)
{
    int x = 1;
    for (int i = 0; i < m; i++)
    {
        x *= n;
    }
    return x.ToString();
}






