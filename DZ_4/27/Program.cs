Console.WriteLine("Задача 27");
Console.Write("Введите число: ");
string a = Console.ReadLine();
if (a.All(char.IsDigit))
{
    Console.Write(" Сумма цифр в числе: " + GetSum(a));
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}
 
string GetSum(string n)
{
    int x = 0;
    for (int i = 0; i < n.Length; i++)
    {
        x += int.Parse(n[i].ToString());
    }
    return x.ToString();
}
