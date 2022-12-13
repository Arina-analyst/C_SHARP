Console.WriteLine("Задача 54");
Random rand = new Random();
int m = rand.Next(2, 10);
Console.Write("m = " + m.ToString() + ", ");
int n = rand.Next(2, 10);
Console.WriteLine("n = " + n.ToString());
int[,] array = GetArray(m, n);
for (int i = 0; i < m; i++)
{
     for (int j = 0; j < n; j++)
         Console.Write(array[i, j].ToString("#0.#") + " ");
     Console.WriteLine("");
}
Console.WriteLine("Сортируем строки по убыванию: ");
for (int i = 0; i < m; i++)
{
     int[] str = new int[n];
     for (int j = 0; j < n; j++)
         str[j] = array[i, j];
     Array.Sort(str);
     for (int j = n-1; j >=0 ; j--)
         Console.Write(str[j].ToString() + " ");
     Console.WriteLine("");
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
