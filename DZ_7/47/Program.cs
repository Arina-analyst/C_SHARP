Console.WriteLine("Задача 47");
Random rand = new Random();
int m = rand.Next(1, 10);
Console.Write("m = " + m.ToString() + ", ");
int n = rand.Next(1, 10);
Console.WriteLine("n = " + n.ToString());
double[,] array = GetArray(m, n);
for (int i = 0; i < m; i++)
{
     for (int j = 0; j < n; j++)
         Console.Write(array[i, j].ToString("#0.#") + " ");
     Console.WriteLine("");
}

double[,] GetArray(int m, int n)
{
     Random rand = new Random();
     double[,] array = new double[m, n];
     for (int i = 0; i < m; i++)
     {
         for (int j = 0; j < n; j++)
             array[i,j] = rand.NextDouble() * (10 + 10) - 10;
     }
     return array;
}
