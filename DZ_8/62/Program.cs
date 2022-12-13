Console.WriteLine("Задача 62");
Random rand = new Random();
int m = rand.Next(2, 10);
int n = rand.Next(2, 10);
int[,] array = new int[n, m];
int row = 0, col = 0, dx = 1, dy = 0, dc = 0, gr = m;
for (int i = 0; i < array.Length; i++)
{
     array[row, col] = i + 1;
     if (--gr == 0)
     {
         gr = m * (dc % 2) + n * ((dc + 1) % 2) - (dc / 2 - 1) - 2;
         int temp = dx;
         dx = -dy;
         dy = temp;
         dc++;
     }
     col += dx;
     row += dy;
}

for (int i = 0; i < n; i++)
{
     for (int j = 0; j < m; j++)
     {
         Console.Write(array[i, j].ToString("00") + " ");
     }
     Console.WriteLine("");
}

