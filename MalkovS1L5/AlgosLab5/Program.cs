using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AlgosLab5
{
    public class Program
    {
       
        static void WriteArray(int q, int[] M)
        {
            if (q == 1)
                for (int i = 0; i < M.Length; i++)
                    Console.Write($"{M[i]} ");
            if (q == 0)
                for (int i = M.Length - 1; i >= 0; i--)
                    Console.Write($"{M[i]} ");
            Console.WriteLine();
            return;
        }
        public static int[] Filling(int n1, int amin, int amax)
        {
            int count = 0;
            int[] M = Array.Empty<int>();
            M = new int[n1];
                Random r = new Random();
                for (int i = 0; i < n1; i++)
                {
                    M[i] = r.Next(amin, amax + 1);
                //Console.Write(" {0}", M[i]);
                count++;
                }
            //Console.WriteLine(count);
            return M;

        }
        public static void BubbleSort(int[] M, int? q)
        {
            if (M.Length == 0)
            {
                Console.WriteLine("нужно заполнить массив");
                return;
            }
            
            if (q != 0 && q != 1)
            {
                Console.WriteLine("Выберите направление из списка");
                return;
            }
            for (int i = 0; i < M.Length; i++)
            {

                for (int j = 0; j < M.Length - 1; j++)
                {
                    if (q == 1)
                    {
                        if (M[j] > M[j + 1])
                            (M[j], M[j + 1]) = (M[j + 1], M[j]);               
                    }
                    else if (q == 0)
                    {
                        if (M[j] < M[j + 1])
                            (M[j + 1], M[j]) = (M[j], M[j + 1]);
                    }
                }
                //WriteArray(q, M);
            }
        }
        public static void QuickSort(int[] M, int? q)
        {
            if (M.Length == 0)
            {
                Console.WriteLine(" нужно заполнить массив ");
                return;
            }
           
            
            if (q != 0 && q != 1)
            {
                Console.WriteLine("Введите значеине от 0 до 1!");
                return;
            }
            int left = 0;
            int right = M.Length - 1;
            SortArray(M, left, right);
            static void SortArray(int[] M, int left, int right)
            {
                int i = left;
                int j = right;
                int mid = M[(left + right) / 2];
                while (i < j)
                {
                    while (M[i] < mid)
                        i++;
                    while (M[j] > mid)
                        j--;
                    if (i <= j)
                    {
                        (M[i], M[j]) = (M[j], M[i]);
                        i++;
                        j--;
                    }
                }
                if (left < j)
                    SortArray(M, left, j);
                if (i < right)
                    SortArray(M, i, right);
                
            }
            //WriteArray(q, M);
            return;
        }
        public static void Sliyaniesort(int[] M, int? q)
        {
            if (M.Length == 0)
            {
                Console.WriteLine("нужно заполнить массив ");
                return;
            }
             // Очищение консоли
          
            //int q = int.Parse(Console.ReadLine());
            if (q != 0 && q != 1)
            {
                Console.WriteLine("Введите значеине от 0 до 1!");
                return;
            }
            int left = 0;
            int right = M.Length - 1;
            Mergesort(M, left, right);
            static void Mergesort(int[] M, int left, int right)
            {
                if (right - left > 1)
                {
                    int a1 = left;
                    int b1 = (left + right) / 2;
                    int a2 = (left + right) / 2 + 1;
                    int b2 = right;
                    Mergesort(M, a1, b1);
                    Mergesort(M, a2, b2);
                    int[] t = new int[right - left + 1];
                    for (int k = left; k <= right; k++)
                        t[k - left] = M[k];
                    int i = a1;
                    int j = a2;
                    for (int k = left; k <= right; k++)
                    {
                        if (i <= b1 && j <= b2)
                        {
                            if (t[i - left] < t[j - left])
                            {
                                M[k] = t[i - left];
                                i++;
                            }
                            else
                            {
                                M[k] = t[j - left];
                                j++;
                            }
                        }
                        else
                        {
                            if (i > b1)
                            {
                                M[k] = t[j - left];
                                j++;
                            }
                            else
                            {
                                M[k] = t[i - left];
                                i++;
                            }
                        }
                    }
                }
                else
                {
                    if (right - left == 1)
                        if (M[left] > M[right])
                            (M[left], M[right]) = (M[right], M[left]);
                }
                

            }
            //WriteArray(q, M);
            return;
        }
        public static void Vstavka(int[] M, int? q)
        {
            if (M.Length == 0)
            {
                Console.WriteLine(" нужно заполнить массив ");
                return;
            }

            
            if (q != 0 && q != 1)
            {
                Console.WriteLine("выберите направление из списка");
                return;
            }
            for (int i = 1; i < M.Length; i++)
            {
                int k = M[i];
                int j = i - 1;
                if (q == 1)
                {
                    while (j >= 0 && M[j] > k)
                    {
                        M[j + 1] = M[j];
                        j--;
                    }
                    M[j + 1] = k;
                    
                }
                else if (q == 0)
                {
                    while (j >= 0 && M[j] < k)
                    {
                        M[j + 1] = M[j];
                        j--;
                    }
                    M[j + 1] = k;
                    
                }
            }
        }
        public static void Vibor(int[] M, int? q)
        {
            if (M.Length == 0)
            {
                Console.WriteLine("Нужно заполнить массив ");
                return;
            }
            
            int imin;
            // = int.Parse(Console.ReadLine());
            for (int i = 0; i < M.Length - 1; i++)
            {
                imin = i;
                for (int j = i + 1; j < M.Length; j++)
                {
                    if (q == 1)
                        imin = (M[j] < M[imin]) ? j : imin;
                    else if (q == 0)
                        imin = (M[j] > M[imin]) ? j : imin;
                    else
                    {
                        Console.WriteLine("Выберите направление из списка!");
                        return;
                    }
                }
                (M[i], M[imin]) = (M[imin], M[i]);
               
            }
            //Console.WriteLine("После сортировки получаем следущее: ");
            
        }

        static void Main()
        {
            int[] M = Array.Empty<int>();
            
        }
    }
}
