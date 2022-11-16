/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7
6 -> да
7 -> да
1 -> нет

*/
Console.WriteLine("Задача 15");
Console.Write("Введите номер дня недели: ");
string a = Console.ReadLine();
if (a.All(char.IsDigit) && a.Length == 1 && "1234567".Contains(a))
    if ("67".Contains(a)) 
        Console.WriteLine("Это выходной: ДА");
    else 
        Console.WriteLine("Это выходной: НЕТ");
else
    Console.WriteLine("Вы ввели неверное число");
