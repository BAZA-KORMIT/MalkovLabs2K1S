using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Lab4
{
    public class AlgLab4
    { 
        /// <summary>
        /// линейный поиск
        /// </summary>
        /// <param name="M">Массив</param>
        public static void LinSearch(int[] M)
        {
            try
            {
                bool flag = false;
                Console.WriteLine("Введите число,которое хотите найти");
                int p = int.Parse(Console.ReadLine());
                for (int i = 0; i < M.Length; i++)
                {
                    if (M[i] == p)
                    {
                        Console.WriteLine("Число найдено по индексу {0}", i);
                        flag = true;
                    }
                }
                if (!flag)
                    Console.WriteLine("число не найдено");
            }
            catch (Exception)
            {
                Console.WriteLine("Введено не число");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="M"></param>
        static void BinarySearch(int[] M)
        {
            try
            {
                Console.Write("Введите число для поиска: ");
                int p = int.Parse(Console.ReadLine());
                int left = 0;
                int right = M.Length - 1;
                while (left <= right)
                {
                    int mid = (left + right) / 2;
                    if (p < M[mid])
                        right = mid - 1;
                    else if (p > M[mid])
                        left = mid + 1;
                    else if (p == M[mid])
                    {
                        Console.WriteLine($"Число найдено по индексу {mid}");
                        return;
                    }
                }
                Console.WriteLine("не нашли");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Вводите числа!");
                return;
            }
        }
        /// <summary>
        /// jumpsearch
        /// </summary>
        /// <param name="M"></param>
        public static void Jumpsearch(int[] M)
        {
            Console.Write("Введите число для поиска: ");
            int p = int.Parse(Console.ReadLine());
            //Random r = new Random();
            //int p=r.Next(2,100000);
            int len=M.Length;
            int jump = (int)Math.Sqrt(len);
            int left = 0;int right = 0;
            while (left < len && M[left] <= p) {
                right = Math.Min(len - 1, left + jump);
                if (M[left] <= p && M[right] >= p)
                    break;
                left += jump;
            }
            if (left >= len || M[left] > p)
                Console.WriteLine("Число не найдено"); 
            right = Math.Min(len - 1, right);
            int i = left;
            while (i <= right && M[i] <= p)
            {
                if (M[i] == p)
                {
                    Console.WriteLine($"Число найдено по индексу {i}");
                    return;
                }
                i += 1;
            }
            Console.WriteLine("Число не найдено");
        }
        /// <summary>
        /// рекурентный алгоритм бинарноого поиска
        /// </summary>
        /// <param name="M">массив</param>
        /// <param name="p">число,которое ищем</param>
        /// <param name="left">начальный индекс</param>
        /// <param name="right">конечный индекс</param>
        static void recBinarySearch(int[] M,int p,int left,int right)
        {
            if (left>right)
                Console.WriteLine("Число не найдено");
            int mid = (left + right) / 2;
            if (left == mid || mid == right)
                Console.WriteLine($"Число найдено по индексу {mid}");
            else if (M[mid] > p)
                recBinarySearch(M, p, left, mid-1);
            else
                recBinarySearch(M, p, mid+1, right);
        }
        /// <summary>
        /// интерполяционный поиск
        /// </summary>
        /// <param name="M">массив</param>
        static void InterpolationSearch(int[] M)
        {
            Console.Write("Введите число для поиска: ");
            int p = int.Parse(Console.ReadLine());
            int left = 0;
            int right = M.Length - 1;

            while (left <= right && p >= M[left] && p <= M[right])
            {
                int mid = left + ((p - M[left]) * (right - left)) / (M[right] - M[left]);

                if (M[mid] == p)
                {
                    Console.WriteLine($"Число найдено по индексу {mid}");
                    return; // Элемент найден
                }
                else if (M[mid] < p) //правая часть
                {
                    left = mid + 1; 
                }
                else //левая
                {
                    right = mid - 1; 
                }
            }
            Console.WriteLine("Число не найдено"); 
        }
        public static void JumpSearch(int[] M)
        {
            Console.Write("Введите число для поиска: ");
            int p = int.Parse(Console.ReadLine());
            //Random r = new Random();
            //int p = r.Next(2, 100);
            int len = M.Length;
            int jump = (int)Math.Pow(len,1/3);
            int left = 0; int right = 0;
            while (left < len && M[left] <= p)
            {
                right = Math.Min(len - 1, left + jump);
                if (M[left] <= p && M[right] >= p)
                    break;
                left += jump;
            }
            if (left >= len || M[left] > p)
                Console.WriteLine("Число не найдено");
            right = Math.Min(len - 1, right);
            int i = left;
            while (i <= right && M[i] <= p)
            {
                if (M[i] == p)
                {
                    Console.WriteLine($"Число найдено по индексу {i}");
                    return;
                }
                i += 1;
            }
            Console.WriteLine("Число не найдено");
        }
        public static void Main()
        {
                int[] M = Array.Empty<int>();
                int n1, amin, amax;
            try
            {
                Console.WriteLine("введите количество чисел ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите минимальный элемент массива");
                amin = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите максимальный элемент массива");
                amax = int.Parse(Console.ReadLine());
            
                M = new int[n1];
                if ((amin > amax || n1 <= 0))
                {
                    Console.WriteLine("Неверно введённые данные");
                }
                else
                {
                    Random r = new Random();
                    for (int i = 0; i < n1; i++)
                    {
                        M[i] = r.Next(amin, amax + 1);
                        Console.Write(" {0}", M[i]);
                    }
                }
            
            Array.Sort(M);
                Console.WriteLine("\nОтсортированный массив");
                for (int i = 0; i < n1; i++)
                {
                    Console.Write(" {0}", M[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("введено не число");
                return;
            }
            Console.WriteLine("\n1LinSearch\n2BinarySearch\n3JumpSearch\n4recBinarySearch\n5InterpolationSearch");
                Console.WriteLine("Введите n");
                int n = int.Parse(Console.ReadLine());
            Stopwatch sw=new Stopwatch();
            switch (n)
            {
                case 1:
                    sw.Start();
                    LinSearch(M);
                    sw.Stop();
                    var resulttime = sw.ElapsedMilliseconds;
                    Console.WriteLine("Время: {0} мс",resulttime);
                    sw.Reset();
                    break;
                    sw.Reset ();
                case 2:
                    
                    sw.Start();
                    BinarySearch(M);
                    sw.Stop();
                    var result = sw.ElapsedMilliseconds;
                    Console.WriteLine("Время: {0} мс", result);
                    break;
                    sw.Reset();
                case 3:
                    Stopwatch swatch = new();
                    swatch.Start();
                    Jumpsearch(M);
                    swatch.Stop();
                    var time = swatch.ElapsedMilliseconds;
                    Console.WriteLine("Время: {0} мс", time);
                    break;
                    sw.Reset();
                case 4:
                    Console.Write("Введите число для поиска: ");
                    int p = int.Parse(Console.ReadLine());
                    
                    sw.Start();
                    recBinarySearch(M,p,0,M.Length-1);
                    sw.Stop();
                    var restime = sw.ElapsedMilliseconds;
                    Console.WriteLine("Время: {0} мс", restime);
                    break;
                    sw.Reset();
                case 5:
                   
                    sw.Start();
                    InterpolationSearch(M);
                    sw.Stop();
                    var res = sw.ElapsedMilliseconds;
                    Console.WriteLine("Время: {0} мс", res);
                    break;
                    sw.Reset();
                case 6:
                    sw.Start();
                    Jumpsearch(M);
                    sw.Stop();
                    var result1 = sw.ElapsedMilliseconds;
                    Console.WriteLine("Время: {0} мс", result1);
                    break;
                default:
                    Console.WriteLine("Введено не то число");
                    break;
                    sw.Reset();
            }
        }
    }
}