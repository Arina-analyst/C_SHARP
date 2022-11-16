/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/


Console.WriteLine("Определение максимума трех чисел");
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a < b) a = b;
Console.Write("Введите третье число: ");
b = Convert.ToInt32(Console.ReadLine());
if (a < b) a = b;
Console.WriteLine("Мах: " + a.ToString());
