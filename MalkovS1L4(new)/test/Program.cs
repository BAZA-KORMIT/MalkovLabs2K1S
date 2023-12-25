using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MalkovS1L4;


namespace MalkovS1
{
    internal class Class1
    {
        static int[] FillArray(int n)
        {
            int[] M = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                M[i] = i;
            }
            return M;
        }
        public static void Main()
        {
            int[] M1 = FillArray(50000);
            int[] M2 = FillArray(100000);
            int[] M3 = FillArray(500000);
            int[] M4 = FillArray(1000000);
            Stopwatch time = new Stopwatch();
            for (int a = 1; a <= 2; a++)
            {

                switch (a)
                {
                    case 1:
                        string timeres = "";
                        time.Start();
                        MalkovLab4.InterpolationSort(M1);
                        time.Stop();
                        timeres += $" 50000 чисел:{time.ElapsedMilliseconds}\n";
                        time.Restart();
                        MalkovLab4.InterpolationSort(M2);
                        time.Stop();
                        timeres += $" 100000 чисел:{time.ElapsedMilliseconds}\n";
                        time.Restart();
                        MalkovLab4.InterpolationSort(M3);
                        time.Stop();
                        timeres += $" 500000 чисел:{time.ElapsedMilliseconds}\n";
                        time.Restart();
                        MalkovLab4.InterpolationSort(M4);
                        time.Stop();
                        timeres += $" 1000000 чисел:{time.ElapsedMilliseconds}\n";
                        Console.WriteLine($"Время  (мс): \n{timeres}");
                        time.Reset();
                        break;
                    case 2:
                        string timeres1 = "";
                        time.Start();
                        MalkovLab4.InterpolationSort(M1);
                        time.Stop();
                        timeres1 += $" 50000 чисел:{time.ElapsedMilliseconds}\n";
                        time.Restart();
                        MalkovLab4.InterpolationSort(M2);
                        time.Stop();
                        timeres1 += $" 100000 чисел:{time.ElapsedMilliseconds}\n";
                        time.Restart();
                        MalkovLab4.InterpolationSort(M3);
                        time.Stop();
                        timeres1 += $" 500000 чисел:{time.ElapsedMilliseconds}\n";
                        time.Restart();
                        MalkovLab4.InterpolationSort(M4);
                        time.Stop();
                        timeres1 += $" 1000000 чисел:{time.ElapsedMilliseconds}\n";
                        Console.WriteLine($"Время (мс): \n{timeres1}");
                        time.Reset();
                        break;
                }
            }
        }
    }
}