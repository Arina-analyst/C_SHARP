Console.WriteLine("Задача 37");
try
{
     Console.Write("Введите число элементов массива: ");
     int a = Convert.ToInt32(Console.ReadLine());
     int[] array = GetArray(a);
     int l = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(array.Length)
/ 2));
     int[] result = new int[l];
     int k = 0;
     Console.Write("Массив: ");
     for (int i = 0; i < a; i++)
         Console.Write(array[i].ToString() + " ");
     for (int i = 0; i < l; i++)
     {
         if (i != l - i + 1)
             result[i] = array[i] * array[a - i - 1];
         else
             result[i] = array[i];
     }
     Console.WriteLine("");
     Console.Write("Произведение пар чисел: ");
     for (int i = 0; i < l; i++)
         Console.Write(result[i].ToString() + " ");
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
         array[y] = rand.Next(1, 10);
     }
     return array;
}