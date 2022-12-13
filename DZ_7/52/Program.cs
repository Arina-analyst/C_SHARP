
Console.WriteLine("Задача 52");
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
Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < n; j++)
{
     int sum = 0;
     for (int i = 0; i < m; i++)
         sum += array[i, j];
     Console.Write((Convert.ToDouble(sum) / m).ToString("#0.#") + " ");
}

int[,] GetArray(int m, int n)
{
     Random rand = new Random();
     int[,] array = new int[m, n];
     for (int i = 0; i < m; i++)
     {
         for (int j = 0; j < n; j++)
             array[i,j] = rand.Next(2,10);
     }
     return array;
}


