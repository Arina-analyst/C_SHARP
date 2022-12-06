Console.WriteLine("Задача 41");
int[] array = new int[0];
int p = 0;
try
{
     while (1 == 1)
     {
         Console.Write("Введите число или любой символ для выхода из программы: ");
         p += GetRes(ref array, Convert.ToInt32(Console.ReadLine()));
     }
}
catch
{
     Console.Write("Вы ввели числа: ");
     for (int i = 0; i < array.Length; i++)
         Console.Write(array[i] + " ");
     Console.WriteLine("Из них больше нуля: " + p.ToString());
}

int GetRes(ref int[] array, int n)
{
     Array.Resize(ref array, array.Length + 1);
     array[array.Length-1] = n;
     if (n > 0) return 1;
     else return 0;
}
