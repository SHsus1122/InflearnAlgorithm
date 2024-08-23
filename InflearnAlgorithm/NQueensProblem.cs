using System;

namespace InflearnAlgorithm
{
    // Back-Tracking 대표 예제, 탐색 방식 : 깊이 우선 탐색
    // level 은 행(row)번호를 의미, 여기서는 몇 번째 행 까지 퀸을 배치했는지에 대한 의미입니다.
    public static class NQueensProblem
    {
        public static int N = 4;    // 체스칸 사이즈 4 : 4*4, 8 : 8*8 
        public static int[] cols = new int[N + 1];

        public static bool Queens(int level)
        {
            if (!Promising(level))
                return false;
            // 최댓값일시 종료
            else if (level == N)
            {
                for (int i = 1; i <= N; i++)
                    Console.WriteLine("(" + i + ", " + cols[i] + ")");

                return true;
            }
            else
            {
                // (재귀 시작) 배치 유효 확인 후 유효한 배치라면 다음 행으로 넘어갑니다.
                for (int i = 1; i <= N; i++)
                {
                    cols[level + 1] = i;    // level + 1 은 현재 배치하려는 행, i 는 배치하려는 열

                    if (Queens(level + 1))
                        return true;
                }
                return false;
            }
        }

        // 유효성 검사
        public static bool Promising(int level)
        {
            for (int i = 1; i < level; i++)
            {
                // 같은 행이 아닌 퀸들이 같은 열에 있는지 검사
                if (cols[i] == cols[level])
                    return false;
                // 대각선 검사 ((절대값 x-y열의 차), 대각선 방향에 따라 값의 비교가 양수 음수일 수 있기 때문에 절댓값(Abs)를 사용합니다.
                else if (level - i == Math.Abs(cols[level] - cols[i]))
                    return false;
            }
            return true;
        }
    }
}
