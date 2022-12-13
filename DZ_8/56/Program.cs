Console.WriteLine("Задача 56");
Random rand = new Random();
int m = rand.Next(2, 10);
Console.Write("m = " + m.ToString() + ", ");
int n = rand.Next(2, 10);
Console.WriteLine("n = " + n.ToString());
int[,] array = GetArray(m, n);
int str = 0;
int sum = 100;
for (int i = 0; i < m; i++)
{
     int ssum = 0;
     for (int j = 0; j < n; j++)
     {
         Console.Write(array[i, j].ToString("#0.#") + " ");
         ssum += array[i, j];
     }
     if (ssum < sum)
     {
         sum = ssum;
         str = i;
     }
     Console.WriteLine("");
}
Console.WriteLine("Строка с наименьшей суммой элементов: " + (str +
1).ToString() + " строка");

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
