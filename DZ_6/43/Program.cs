Console.WriteLine("Задача 43");
int[] array = GetArray();
Console.Write("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
     Console.Write(array[i].ToString() + " ");
}
Console.WriteLine("");
Array.Sort(array);
Console.Write("Отсортированный массив: ");
for (int i = 0; i < array.Length; i++)
{
     Console.Write(array[i].ToString() + " ");
}

int[] GetArray()
{
     Random rand = new Random();
     int n = rand.Next(6, 100);
     int[] array = new int[n];
     for (int y = 0; y < n; y++)
     {
         array[y] = rand.Next(0, 101);
     }
     return array;
}
