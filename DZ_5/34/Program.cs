Console.WriteLine("Задача 34");
try
{
     Console.Write("Введите число элементов массива: ");
     int a = Convert.ToInt32(Console.ReadLine());
     int[] array = GetArray(a);
     int k = 0;
     for (int i = 0; i < a; i++)
     {
         if (array[i] % 2 == 0)
             k++;
         Console.Write(array[i].ToString() + " ");
     }
     Console.Write("Число четных элементов: " + k.ToString());
}
catch
{
     Console.WriteLine("Вы ввели неверное число");
}

int[] GetArray(int n)
{
     int[] array = new int[n];
     Random rand = new Random();
     for (int y = 0; y < n; y++)
     {
         array[y] = rand.Next(100, 1000);
     }
     return array;
}

