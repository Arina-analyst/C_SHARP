Console.WriteLine("Задача 29"); 
int[] array = GetArray();
for (int i = 0; i < 8; i++)
{
    Console.Write(array[i].ToString() + " ");
}
 
int[] GetArray()
{
    int[] array = new int[8];
    Random rand = new Random();
    for (int y = 0; y < 8; y++)
    {
        array[y] = rand.Next(1, 100);
    }
    return array;
}

