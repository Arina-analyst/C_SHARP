Console.WriteLine("Задача 60");
Random rand = new Random();
int m = rand.Next(2, 4);
int n = rand.Next(2, 4);
int l = rand.Next(2, 4);
int[,,] array = GetArray(m, n, l);
Console.WriteLine("Трехмерный массив размером " + m.ToString() + " x " +
n.ToString() + " x " + l.ToString() + " :");
for (int i = 0; i < m; i++)
{
     for (int j = 0; j < n; j++)
         for (int k = 0; k < l; k++)
             Console.Write(array[i, j, k].ToString() + "(" +
i.ToString() + "," + j.ToString() + "," + k.ToString() + ") ");
     Console.WriteLine("");
}

int[,,] GetArray(int m, int n, int l)
{
     HashSet<int> hs = new HashSet<int>();
     Random rand = new Random();
     int count = m * n * l;
     while (hs.Count < count)
     {
         int c = rand.Next(10, 100);
         if (!hs.Contains(c))
             hs.Add(c);
     }
     int[] col = hs.ToArray();
     int[,,] array = new int[m, n, l];
     int num = 0;
     for (int i = 0; i < m; i++)
     {
         for (int j = 0; j < n; j++)
             for (int k = 0; k < l; k++)
             {
                 array[i, j, k] = col[num];
                 num++;
             }
     }
     return array;
}

