using System;

namespace Homework3App
{
    class Program
    {
        static void Main()
        {
            //Первое задание. Добавил вывод массива для проверки
            Console.WriteLine("Создаём двухмерный массив, с которым будем работать");
            
            bool result1 = false;
            int y = 0;
            while (result1==false)
            {
                Console.WriteLine("Введите количество строк в массиве");
                result1 = int.TryParse(Console.ReadLine(), out y);
                if (result1)
                {
                    if (y < 1 || y > 10)
                    {
                        Console.WriteLine("Не стоит вводить массив такой размерности!");
                        result1 = false;
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("Вы ввели не число!");
                    result1 = false;
                    continue;
                }
            
             }
            bool result2 = false;
            int x = 0;
            while (result2 == false)
            {
                Console.WriteLine("Введите количество столбцов в массиве");
                result2 = int.TryParse(Console.ReadLine(), out x);
                if (result2)
                {
                    if (x < 1 || x > 10)
                    {
                        Console.WriteLine("Не стоит вводить массив такой размерности!");
                        result2 = false;
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("Вы ввели не число!");
                    result2 = false;
                    continue;
                }

            }
            int MaxNum = 0;
             int MinNum = 99;
             int sum = 0;

             int[,] array = new int[y,x];
             Random rnd = new Random();

             for (int i = 0; i < y; i++)
                {
                 for (int j = 0; j < x; j++)
                   {
                    array[i, j] = rnd.Next(0, 99);
                    if (array[i,j]>MaxNum)
                    {
                         MaxNum = array[i, j];
                    }
                    if (array[i, j] < MinNum)
                    {
                         MinNum = array[i, j];
                    }
                    sum += array[i, j];
                    Console.Write("{0}\t", array[i, j]);
                    continue;
                    }
                 Console.WriteLine();
                 Console.WriteLine();
             }

             int MidNum = sum / (y * x);
             Console.WriteLine("Максимальное число в массиве: " + MaxNum);
             Console.WriteLine("Минимальное число в массиве: " + MinNum);
             Console.WriteLine("Среднее значение в массиве: " + MidNum);
             Console.WriteLine("---------------------------");
             Console.WriteLine("");


            //Второе задание
            //Возможно есть более простые и красивые алгоритмы, но я нашёл(не в интернете!) только эти
            bool result3 = false;
            int size = 0;
            while (result3==false)
            {
                Console.WriteLine("Создаём двухмерный массив для второй задачи");
                Console.WriteLine("Введите размер массива");
                result3 = int.TryParse(Console.ReadLine(), out size);
                if (result3)
                {
                    if (size < 1 || size > 10)
                    {
                        Console.WriteLine("Не стоит вводить массив такой размерности!");
                        result3 = false;
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("Вы ввели не число!");
                    result3 = false;
                    continue;
                }
            }
          
            Console.WriteLine("Вывод массива по алгориму 1");
            Console.WriteLine("---------------------------");
            int[,] array1 = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    array1[i, k] = (k - (size/2-1)) - (-(Math.Abs(size / 2 - i))) > 0 && size-(k +size/2) - (-(Math.Abs(size / 2 - i))) > 0? (k - (size/2-1)) - (-(Math.Abs(size / 2 - i))):0 ;
                    Console.Write("{0}\t", array1[i, k]);
                    continue;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("");

            Console.WriteLine("Вывод массива по алгориму 2");
            Console.WriteLine("---------------------------"); ;
            int[,] array2 = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    array2[i, k] = i*k == 0||(size-i-1)*k==0||(size-k-1)*i==0 ? 1 : 0;
                    Console.Write("{0}\t", array2[i, k]);
                    continue;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("");

            Console.WriteLine("Вывод массива по алгориму 3");
            Console.WriteLine("---------------------------");
            int[,] array3 = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    array3[i, k] = i == k || (size - i - 1) == k ? 1 : 0;
                    Console.Write("{0}\t", array3[i, k]);
                    continue;
                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}
