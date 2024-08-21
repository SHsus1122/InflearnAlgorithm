using System;

namespace InflearnAlgorithm
{
    public static class CountingCellsInABlob
    {
        private static int N = 8;
        private static int[,] grid = new int[,]
            {
                { 1, 0, 0, 0, 0, 0, 0, 1 },
                { 0, 1, 1, 0, 0, 1, 0, 0 },
                { 1, 1, 0, 0, 1, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 1, 0, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 0 },
                { 1, 0, 0, 0, 1, 0, 0, 1 },
                { 0, 1, 1, 0, 0, 1, 1, 1 }
            };

        private static int BACKGROUND_COLOR = 0;
        private static int IMAGE_COLOR = 1;
        private static int ALREADY_COUNTED = 2;

        public static int CountCells(int x, int y)
        {
            if (x < 0 || x >= N || y < 0 || y >= N)
                return 0;   // 배열의 범위를 벗어나면 0 반환
            else if (grid[x, y] != IMAGE_COLOR)
                return 0;   // 현재 위치가 1이 아니면 0 반환
            else
            {
                grid[x, y] = ALREADY_COUNTED;   // 현재 위치를 이미 방문한 것으로 표시
                return 1 + CountCells(x - 1, y + 1) + CountCells(x, y + 1)
                    + CountCells(x + 1, y + 1) + CountCells(x - 1, y)
                    + CountCells(x + 1, y) + CountCells(x - 1, y - 1)
                    + CountCells(x, y - 1) + CountCells(x + 1, y - 1);
            }
        }
    }
}
