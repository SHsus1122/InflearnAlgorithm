using System;
using System.Security.Cryptography.X509Certificates;

namespace InflearnAlgorithm
{
    class Prog
    {
        public static void Main(string[] args)
        {
            int n = 4;
            Recursion1_1_2_3.RecursionTest(n);

            double result = Recursion1_1_2_3.GcdTest(100, 20);
            Console.WriteLine(result);

            Console.WriteLine(Recursion1_1_2_3.LengthTest("Ddd"));

            Recursion1_1_2_3.PrintChars("strtest");
            Console.WriteLine();
            Recursion1_1_2_3.PrintCharsReverse("abc");

            Console.WriteLine();

            Recursion1_1_2_3.PrintInBinary(8);

            Console.WriteLine();
            Console.WriteLine("int 배열 {1, 2, 3} 에서 모든 정수의 합 : " + Recursion1_1_2_3.SumTest(3, new int[] { 1, 2, 3 }));
            Console.WriteLine("int 배열 {1, 2, 3} 에서 정수 3의 위치 : " + Recursion1_1_2_3.Search(new int[] { 1, 2, 3 }, 0, 2, 3));

            int[] testAry = Enumerable.Range(1, 100).ToArray();
            int[] tAr = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            Console.WriteLine("int 배열 {0, ... 100} 에서 정수 50의 위치 : " +
                Recursion1_1_2_3.BinarySearch1(testAry, 0, testAry.Length, 50));

            Maze.PrintMaze();
            Maze.FindMazePath(0,0);
            Console.WriteLine();
            Maze.PrintMaze();
        }

        
    }
}
