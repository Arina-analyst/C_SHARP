

Console.WriteLine("Задача 50");
Random rand = new Random();
int m = rand.Next(1, 10);
Console.Write("m = " + m.ToString() + ", ");
int n = rand.Next(1, 10);
Console.WriteLine("n = " + n.ToString());
int[,] array = GetArray(m, n);
for (int i = 0; i < m; i++)
{
     for (int j = 0; j < n; j++)
         Console.Write(array[i, j].ToString("#0.#") + " ");
     Console.WriteLine("");
}
try
{
     Console.Write("Введите первую позицию элемента в массиве: ");
     int a = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("");
     Console.Write("Введите вторую позицию элемента в массиве: ");
     int b = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("");
     Console.Write("i = " + a.ToString() + "; ");
     Console.Write("j = " + b.ToString() + " -> ");
     if (a < m && b < n)
         Console.Write(array[a, b].ToString("#0.#") + " ");
     else
         Console.Write("такого числа в массиве нет");
}
catch
{
     Console.Write("Вы ввели неверное число");
}

int[,] GetArray(int m, int n)
{
     Random rand = new Random();
     int[,] array = new int[m, n];
     for (int i = 0; i < m; i++)
     {
         for (int j = 0; j < n; j++)
             array[i,j] = rand.Next(1,10);
     }
     return array;
}


