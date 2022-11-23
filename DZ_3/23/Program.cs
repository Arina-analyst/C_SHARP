/* Задача 23

Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */


Console.WriteLine("Задача 23");
try 
{
    Console.Write("Введите целое число больше 0: ");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
        Console.Write(Math.Pow(i, 3).ToString() + " ");
    }
}
catch
{
    Console.WriteLine("Вы ввели неверное число");
}

