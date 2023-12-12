using System;
using System.ComponentModel.Design;

namespace lab3
{
    class P
    {
        static string s;
        static void Main()
        {
            Console.Write("Введите строку для работы: ");
            s = Console.ReadLine();
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            string text = ($"Ваша строка: {s}@Выберите номер операции над строкой:@1. Поиск подстроки в тексте.@2. Алгоритм Рабина.@3. Алгоритм Кнута - Морриса - Пратта.@4. Стемминг.@Ваш выбор: ");
            text = text.Replace("@", Environment.NewLine);
            Console.Write(text);
            int n = Convert.ToInt16(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Итог (Вхождение, выход): "+String.Join(", ", SubStringSearch().ToArray())+"\nНажмите любую кнопку для выхода в меню");
                    Console.ReadLine();
                    Menu();
                    break;
                case 2:
                    Console.WriteLine("Итог ( Вхождение(-я) ): "+String.Join(", ", RabinAlg().ToArray())+"\nНажмите любую кнопку для выхода в меню");
                    Console.ReadLine();
                    Menu();
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
            }
        }

        static List<int> RabinAlg()
        {
            Console.Write("Введите слово: ");
            string SubString = Console.ReadLine();
            
            List<int> subStringIndexList = new List<int>();
            long sLen = 0; // s длина
            long SubStringLen = 0; // substring длина
            long Q = 100007;
            long D = 256;
            
            for (int i = 0; i < SubString.Length; ++i)
            {
                sLen = (sLen * D + s[i]) % Q;
                SubStringLen = (SubStringLen * D + SubString[i]) % Q;
            }

            if (sLen == SubStringLen)
                subStringIndexList.Add(0);

            long pow = 1;

            for (int k = 1; k <= SubString.Length - 1; ++k)
                pow = (pow * D) % Q;

            for (int j = 1; j <= s.Length - SubString.Length; ++j)
            {
                sLen = (sLen + Q - pow * s[j - 1] % Q) % Q;
                sLen = (sLen * D + s[j + SubString.Length - 1]) % Q;

                if (sLen == SubStringLen)
                    if (s.Substring(j, SubString.Length) == SubString)
                        subStringIndexList.Add(j);
            }
            
            return subStringIndexList;
        }

        static List<int> SubStringSearch()
        {
            List<int> subStringIndexList = new List<int>();
            int startIndex;
            int endIndex = 0;
            bool breakFlag;

            Console.Write("Введите искомое слово: ");
            string subString = Console.ReadLine();
            
            for (int i = 0; i < s.Length; i++)
            {
                startIndex = i;
                breakFlag = false;
                for (int j = 0; j < subString.Length; j++)
                {
                    if (subString[j] != s[j + i])
                    {
                        breakFlag = true;
                        break;
                    }
                    endIndex = j + i;
                }
                if (breakFlag == false)
                {
                    subStringIndexList.Add(startIndex);
                    subStringIndexList.Add(endIndex);
                }
            }
            
            return subStringIndexList;
        }
    }
}