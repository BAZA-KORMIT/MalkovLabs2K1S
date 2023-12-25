using System;
using System.Threading.Channels;

namespace P
{
    class P
    {
        static int[] Arr = new[] { 24, 453, 63, 345, 2358, 86, 2345, 86, 453, 245, 234 };
        static void Main()
        {
            Console.WriteLine("Лабораторная работа №4");
            string text = "Выберите тип поиска:@1.Линейный поиск@2.Двоичный поиск@3.Поиск в глубину@4.Поиск в ширину@5.Двоичный поиск (рукурсивный)";
            text = text.Replace("@", System.Environment.NewLine);
            Console.WriteLine(text);
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число для поиска:");
            int s = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine($"Позиция искомого числа {LinSearch(s)}");
                    break;
                case 2:
                    Console.WriteLine($"Позиция искомого числа {BinSearch(s)}");
                    break;
                case 3:
                    Jumpsearch(s, Arr);
                    break;
                case 4:
                    InterpolationSearch(s,Arr);
                    break;
                case 5:
                    Console.WriteLine($"Позиция искомого числа {RecBinSearch(0, Arr.Length-1, s)}");
                    break;
            }
        }

        static string RecBinSearch(int start, int final, int s)
        {
            if (final >= start)
            {
                int mid = start - (final - start) / 2;
                if (Arr[mid]==s)
                    return $"{mid+1}";
                if (Arr[mid] < s)
                    return RecBinSearch(start,mid-1,s);
                return RecBinSearch(mid + 1, final, s);

            }
            return "err";
        }

        static string BinSearch(int s)
        {
            int start = 0;
            int final = Arr.Length - 1;
            while (start <= final)
            {
                int middle = (start + final) / 2;
                if (Arr[middle]==s)
                    return $"{middle+1}"; 
                else if (Arr[middle] < s)
                    start = middle + 1;
                else
                    final = middle - 1;
                    
            }
            return "Числа нет!"; 
        }

        static string LinSearch(int s)
        {
            for (int i = 0;i<Arr.Length; i++)
                if (Arr[i]==s)
                    return $"{i+1}";
            
            return "Числа нет!";
        }
        
        static void InterpolationSearch(int p,int[] M)
        {
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
        static void Jumpsearch(int p,int[] M)
        {
            int len = M.Length;
            int jump = (int)Math.Sqrt(len);
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
    }
}