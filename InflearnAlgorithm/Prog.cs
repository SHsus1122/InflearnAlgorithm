using System;

namespace InflearnAlgorithm
{
    class Prog
    {
        public static void Main(string[] args)
        {
            int n = 4;
            RecursionTest(n);

            double result = GcdTest(100, 20);
            Console.WriteLine(result);

            Console.WriteLine(LengthTest("Ddd"));

            PrintChars("strtest");
            Console.WriteLine();
            PrintCharsReverse("abc");

            Console.WriteLine();

            PrintInBinary(8);

            Console.WriteLine();
            Console.WriteLine(SumTest(3, new int[] { 1, 2, 3 }));
        }

        public static void RecursionTest(int k)
        {
            if (k == 0) return;
            else
            {
                Console.WriteLine("Hello");
                RecursionTest(k - 1);
            }
        }

        public static double GcdTest(int m, int n)
        {
            if (m < n)
            {
                int tmp = m;
                m = n;
                n = tmp;    // Swap m and n
            }
            if (m % n == 0) return n;
            else return GcdTest(n, m % n);
        }

        public static int LengthTest(string str)
        {
            if (str.Equals("")) return 0;
            else return 1 + LengthTest(str.Substring(1));
        }

        public static void PrintChars(string str)
        {
            if (str.Length == 0) return;
            else
            {
                Console.Write(str[0]);
                PrintChars(str.Substring(1));
            }
        }

        public static void PrintCharsReverse(string str)
        {
            if (str.Length == 0) return;
            else
            {
                PrintCharsReverse(str.Substring(1));
                Console.Write(str[0]);
            }
        }

        // 음이 아닌 정수 n을 2진수로 변환하여 출력한다.
        public static void PrintInBinary(int n)
        {
            if (n < 2)
                Console.WriteLine(n);
            else
            {
                PrintInBinary(n / 2);   // n을 2로 나눈 몫을 먼저 2진수로 변환하여 출력한 후
                Console.WriteLine(n);   // n을 2로 나눈 나머지를 인쇄한다.
            }
        }

        public static int SumTest(int n, int[] data)
        {
            if (n <= 0) return 0;
            else return SumTest(n - 1, data) + data[n - 1];
        }
    }
}
