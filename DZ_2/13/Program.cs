/*
Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, 
что третьей цифры нет. Берем числа до 100000
645 -> 5
78 -> третьей цифры нет
32679 -> 6

*/
Console.WriteLine("Задача 13");
Console.Write("Введите число: ");
string a = Console.ReadLine();
if (a.All(char.IsDigit) && a.Length >= 3)
    Console.WriteLine("Третья цифра: " + a.Substring(2,1));
else
    Console.WriteLine("Третьей цифры нет");
