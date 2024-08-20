using System;

namespace InflearnAlgorithm
{
    public static class Recursion1_1_2_3
    {
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

        public static int Search(int[] data, int begin, int end, int target)
        {
            if (begin > end)
                return -1;
            else if (target == data[begin])
                return begin;
            else
                return Search(data, begin + 1, end, target);
        }

        /* 이진탐색 대략적인 작동방식
         * 1. 우선 구하고자 하는 값의 시작점과 끝점을 2로 나누어서 대략적인 중간위치를 찾습니다.
         * 2. 이후 해당 위치의 값이 찾고자 하는 값과 같다면 해당 위치를 반환합니다.
         * 3. 만약 일치하지 않는다면 시작점 기준에서 끝점의 위치를 -1해서(탐색 방향이 좌측 먼저) 다시 찾아서 index 값을 가져옵니다.
         * 4. 이후 가져온 index값(위치)이 -1이 아니라면 값을 찾은 것이기에 찾은 위치값을 반환하고
         * 5. 결과가 -1이 아니라면 이번에는 시작점을 middle + 1로(탐색 방향을 우측으로 전환) 하고 다시 찾기 시작합니다.
         * 6. 이렇게 해서 탐색 범위를 절반씩 줄여가며 탐색하면서 맨 처음 -1이 반환될 때마다 방향을 바꿔가며 찾습니다.
         */
        public static int BinarySearch1(int[] data, int begin, int end, int target)
        {
            if (begin > end)
                return -1;
            else
            {
                int middle = (begin + end) / 2;
                
                if (data[middle] == target)
                    return middle;

                int index = BinarySearch1(data, begin, middle - 1, target);

                if (index != -1)
                    return index;
                else
                    return BinarySearch1(data, middle + 1, end, target);
            }
        }

        public static int BinarySearch2(string[] items, string target, int begin, int end)
        {
            if (begin > end)
                return -1;
            else
            {
                int middle = (begin + end) / 2;
                int compResult = target.CompareTo(items[middle]);
                if (compResult == 0)
                    return middle;
                else if (compResult < 0)
                    return BinarySearch2(items, target, begin, middle - 1);
                else
                    return BinarySearch2(items, target, middle + 1, end);
            }
        }


        public static int FindMax1(int[] data, int begin, int end)
        {
            if (begin == end) 
                return data[begin];
            else 
                return Math.Max(data[begin], FindMax1(data, begin + 1, end));
        }

        public static int FindMax2(int[] data, int begin, int end)
        {
            if (begin == end)
                return data[begin];
            else
            {
                int middle = (begin + end) / 2;
                int max1 = FindMax2(data, begin, middle);
                int max2 = FindMax2(data, middle + 1, end);
                return Math.Max(max1, max2);
            }
        }
    }
}

