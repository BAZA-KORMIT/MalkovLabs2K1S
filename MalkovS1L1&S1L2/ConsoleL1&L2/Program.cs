using SparceArray;
using SymmetricMatrix;
using System.Threading.Channels;

namespace MalkovS1L1andL2
{
    class Program
    {
        static void Main()
        {
            CheckLab2();
            /*while (true) 
            {
                Console.Clear();
                Console.Write("Список: \n1) Symmetric Matrix \n2) Sparce Array\n Введите номер лабораторной работы: ");
                int n = Convert.ToInt16(Console.ReadLine());
                switch (n)
                {
                    case 1: Console.Clear(); CheckLab1(); Console.ReadKey(); break;
                    case 2: Console.Clear(); CheckLab2(); Console.ReadKey(); break;
                    default: Console.WriteLine("Такого нет :("); break;
                }
            }*/
        }

        static void CheckLab1()
        {
            int[,] val = { { 1, 2, 2 }, { 2, 1, 2 }, { 2, 2, 1 } }; //sym mat
            SymMastrix m = new(val);
            int[] vec = m.PackingOperation(m);
            for (int i = 0; i < vec.Length; i++)
            {
                Console.Write(vec[i] + " ");
            }
            Console.WriteLine("\n");
            Print(val);
            int[] vector = { 1, 2, 1, 2, 2, 1 };
            int[,] result = m.UnpackingOperation(vector);
            Console.WriteLine("\n");
            Print(result);
        }

        static void CheckLab2()
        {
            double[,] test = { {0,9,0,10 }, { 1, 2, 0, 0 }, { 0, 0, 0, 1 }, { 0, 6, 2, 0 } };
            SparseArr r = new(test); 
        }


        static void Print(int[,] val)
        {
            for (int i = 0; i < val.GetLength(0); i++)
            {
                for (int j = 0; j < val.GetLength(1); j++)
                    Console.Write(val[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}