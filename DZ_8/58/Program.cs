Console.WriteLine("Задача 58");
Random rand = new Random();
int m = rand.Next(2, 10);
int n = rand.Next(2, 10);
int l = rand.Next(2, 10);
int[,] a1 = GetArray(m, n);
Console.WriteLine("1-я матрица:");
for (int i = 0; i < m; i++)
{
     for (int j = 0; j < n; j++)
         Console.Write(a1[i, j].ToString() + " ");
     Console.WriteLine("");
}
Console.WriteLine("");
int[,] a2 = GetArray(n, l);
Console.WriteLine("2-я матрица:");
for (int i = 0; i < n; i++)
{
     for (int j = 0; j < l; j++)
         Console.Write(a2[i, j].ToString() + " ");
     Console.WriteLine("");
}
Console.WriteLine("");
Console.WriteLine("Произведение матриц:");
int[,] r = GetMultiplication(a1, a2);
for (int i = 0; i < r.GetLength(0); i++)
{
     for (int j = 0; j < r.GetLength(1); j++)
         Console.Write(r[i, j].ToString() + " ");
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
int[,] GetMultiplication(int[,] a, int[,] b)
{
     int[,] r = new int[a.GetLength(0), b.GetLength(1)];
     for (int i = 0; i < a.GetLength(0); i++)
     {
         for (int j = 0; j < b.GetLength(1); j++)
         {
             for (int k = 0; k < b.GetLength(0); k++)
             {
                 r[i, j] += a[i, k] * b[k, j];
             }
         }
     }
     return r;
}

