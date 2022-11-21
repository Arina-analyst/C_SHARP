/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).

14212 -> нет

12821 -> да

23432 -> да

*/
Console.WriteLine("Задача 19");
Console.Write("Введите пятизначное число: ");
string a = Console.ReadLine();
string msg = "Да";
if (a.All(char.IsDigit) && a.Length == 5) {
    for (int i = 0, j = a.Length-1; i<j; i++, j--) {
        if (a[i]!=a[j]) { 
            msg = "НЕТ";  
            break;
            
        }
    }
}
else 
    msg = "Вы ввели непятизначное число";
Console.WriteLine(msg); 


