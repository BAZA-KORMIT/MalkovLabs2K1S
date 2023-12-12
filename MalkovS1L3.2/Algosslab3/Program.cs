using System;

namespace L3
{
    class Lab3
    {
        static void str(string text,string pattern)
        {
            int n = text.Length;
            int m = pattern.Length;
            for (int i = 0; i < n-m+1; i++)
            {
                int p = 0;
                int q = i + p;
                while ((p < m) && (text[q] == pattern[p]))
                {
                    p++;
                    q++;
                }
                if (p == m)
                {
                    Console.WriteLine("Подстрока найдена в позиции {0}", i);
                }
            }
        }

        static int CalculateHash(string str)
        {
            int hash = 0;
            foreach (char c in str)
            {
                hash += (int)c;
            }
            return hash;
        }

        static void RabinAlg(string text, string pattern)
        {
            int n = text.Length;
            int m = pattern.Length;
            int patternHash = CalculateHash(pattern);

            for (int i = 0; i <= n - m; i++)
            {
                string currentSubstring = text.Substring(i, m);
                int currentHash = CalculateHash(currentSubstring);

                if (currentHash == patternHash && currentSubstring == pattern)
                {
                    Console.WriteLine("Подстрока найдена в позиции {0}", i);
                }
            }
        }

        static int[] KMPPREFIX(string pattern)
        {
            int m = pattern.Length; //длина подстроки
            int[] pi = new int[m]; //массив pi 
            pi[0] = 0;
            int k = 0;
            for (int q = 1; q < m; q++)
            {
                while (k > 0 && pattern[k] != pattern[q])
                {
                    k = pi[k - 1];
                }
                if (pattern[k] == pattern[q])
                {
                    k++;
                }
                pi[q] = k;
            }
            return pi;
        }

        static void KMP(string s, string pattern)
        {
            List<int> matches = new List<int>();
            int n = s.Length;
            int m = pattern.Length;
            int[] pi = KMPPREFIX(pattern);
            int q = 0;
            for (int i = 0; i < n; i++)
            {
                while (q > 0 && pattern[q] != s[i])
                {
                    q = pi[q - 1];
                }
                if (pattern[q] == s[i])
                {
                    q++;
                }
                if (q == m)
                {
                    matches.Add(i - m + 1);
                    q = pi[q - 1];
                }
            }
            foreach (int match in matches)
            {
                Console.WriteLine("Подстрока найдена в позиции {0}", match);
            }
        }

        static string Stamming(string word)
        {
            word=Porter.TransformingWord(word);
            return word;
        }      
        static void Main()
        {
            string pattern;
            Console.Write("Введите строку (Для стемминга только одно слово): ");
            string text = Console.ReadLine();
            Console.Write($"\nВаша строка: '{text}'\n1) Поиск подстроки \n2) Алгоритм Рабина\n3) Алгоритм Кнута-Морриса-Пратта\n4) Стемминг\nВаш выбор: ");
            int n = int.Parse(Console.ReadLine());
            while (true)
            switch (n)
            {
                case 1:
                    Console.Write("Введите подстроку: ");
                    pattern = Convert.ToString(Console.ReadLine());
                    str(text, pattern);
                    break;
                case 2:
                    Console.WriteLine("Введите подстроку: ");
                    pattern = Convert.ToString(Console.ReadLine());
                    RabinAlg(text, pattern);
                    break;
                case 3:
                    Console.WriteLine("Введите подстроку: ");
                    pattern = Convert.ToString(Console.ReadLine());
                    KMP(text, pattern);
                    break;
                case 4:
                    string word=Stamming(text);
                    Console.WriteLine(word);
                    break;
                default:
                    Console.WriteLine("Такого варианта нет в списке!");
                    break;
            }
        }
    }
}