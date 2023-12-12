using AlgosLab5;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace tester
{
    class Program
    {
        public static int[] M1 = Array.Empty<int>();//100 чисел
        public static int[] M2 = Array.Empty<int>();//1000 чисел
        public static int[] M3 = Array.Empty<int>();//10000 чисел
        public static int[] M4 = Array.Empty<int>();//100000 чисел

        static void Main(string[] args)
        {
            Stopwatch swtest = new();
            swtest.Start();
            Thread.Sleep(1000);
            swtest.Stop();
            Console.WriteLine("Тиков в 1 секунде: "+ swtest.ElapsedTicks);
            Stopwatch sw = new();
            //WriteArray(0, M4);
            
            //Console.WriteLine("\nВведите число от 1 до 5:\n1) Проверка Bubble Sort\n2) Проверка Selection Sort\n3) Проверка Insert Sort\n4) Проверка Quick Sort\n5) Проверка Merge Sort");
            //int a = int.Parse(Console.ReadLine());
            for (int a =1; a<=5; a++)
            {
                FillAllMas();
                switch (a)
                {
                    case 1:
                        string timeres = "";
                        sw.Start();
                        AlgosLab5.Program.BubbleSort(M1, 0);
                        sw.Stop();
                        timeres += $" 1000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        sw.Restart();
                        AlgosLab5.Program.BubbleSort(M2, 0);
                        sw.Stop();
                        timeres += $" 5000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        sw.Restart();
                        AlgosLab5.Program.BubbleSort(M3, 0);
                        sw.Stop();
                        timeres += $" 10000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        sw.Restart();
                        AlgosLab5.Program.BubbleSort(M4, 0);
                        sw.Stop();
                        timeres += $" 25000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        Console.WriteLine($"Время сортировки (сек): \n{timeres}");
                        sw.Reset();
                        break;
                    case 2:
                        string timeres1 = "";
                        sw.Start();
                        AlgosLab5.Program.Vibor(M1, 0);
                        sw.Stop();
                        timeres1 += $" 1000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        sw.Restart();
                        AlgosLab5.Program.Vibor(M2, 0);
                        sw.Stop();
                        timeres1 += $" 5000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        sw.Restart();
                        AlgosLab5.Program.Vibor(M3, 0);
                        sw.Stop();
                        timeres1 += $" 10000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        sw.Restart();
                        AlgosLab5.Program.Vibor(M4, 0);
                        sw.Stop();
                        timeres1 += $" 25000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        Console.WriteLine($"Время сортировки (сек): \n{timeres1}");
                        sw.Reset();
                        break;
                    case 3:
                        string timeres2 = "";
                        sw.Start();
                        AlgosLab5.Program.Vstavka(M1, 0);
                        sw.Stop();
                        timeres2 += $" 1000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        sw.Restart();
                        AlgosLab5.Program.Vstavka(M2, 0);
                        sw.Stop();
                        timeres2 += $" 5000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        sw.Restart();
                        AlgosLab5.Program.Vstavka(M3, 0);
                        sw.Stop();
                        timeres2 += $" 10000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        sw.Restart();
                        AlgosLab5.Program.Vstavka(M4, 0);
                        sw.Stop();
                        timeres2 += $" 25000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        Console.WriteLine($"Время сортировки (сек): \n{timeres2}");
                        sw.Reset();
                        break;
                    case 4:
                        string timeres3 = "";
                        sw.Start();
                        AlgosLab5.Program.QuickSort(M1, 0);
                        sw.Stop();
                        timeres3 += $" 1000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        sw.Restart();
                        AlgosLab5.Program.QuickSort(M2, 0);
                        sw.Stop();
                        timeres3 += $" 5000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        sw.Restart();
                        AlgosLab5.Program.QuickSort(M3, 0);
                        sw.Stop();
                        timeres3 += $" 10000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        sw.Restart();
                        AlgosLab5.Program.QuickSort(M4, 0);
                        sw.Stop();
                        timeres3 += $" 25000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        Console.WriteLine($"Время сортировки (сек): \n{timeres3}");
                        sw.Reset();
                        break;
                    case 5:
                        string timeres4 = "";
                        sw.Start();
                        AlgosLab5.Program.Sliyaniesort(M1, 0);
                        sw.Stop();
                        timeres4 += $" 1000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        sw.Restart();
                        AlgosLab5.Program.Sliyaniesort(M2, 0);
                        sw.Stop();
                        timeres4 += $" 5000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        sw.Restart();
                        AlgosLab5.Program.Sliyaniesort(M3, 0);
                        sw.Stop();
                        timeres4 += $" 10000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        sw.Restart();
                        AlgosLab5.Program.Sliyaniesort(M4, 0);
                        sw.Stop();
                        timeres4 += $" 25000 чисел:{Math.Round((double)sw.ElapsedTicks / swtest.ElapsedTicks, 4)}\n";
                        Console.WriteLine($"Время сортировки (сек): \n{timeres4}");
                        sw.Reset();
                        break;
                    default: Console.WriteLine("Такого варианта нет. Выход из программы...."); break;
                }
            }
        }

        static void FillAllMas()
        {
            int min = 0; int max = 100;
            M1 = AlgosLab5.Program.Filling(1000, min, max);
            M2 = AlgosLab5.Program.Filling(5000, min, max);
            M3 = AlgosLab5.Program.Filling(10000, min, max);
            M4 = AlgosLab5.Program.Filling(25000, min, max);
        }

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
    }
}