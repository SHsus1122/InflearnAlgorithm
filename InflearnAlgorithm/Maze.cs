using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InflearnAlgorithm
{
    public static class Maze
    {
        // 수동적으로 테스트를 위해서 미로구조를 직접 만듭니다. 0은 다닐수 있는 통로이며 1은 벽에 해당합니다.
        private static int N = 8;
        private static int[,] maze = new int[,]
            {
                { 0, 0, 0, 0, 0, 0, 0, 1 },
                { 0, 1, 1, 0, 1, 1, 0, 1 },
                { 0, 0, 0, 1, 0, 0, 0, 1 },
                { 0, 1, 0, 0, 1, 1, 0, 0 },
                { 0, 1, 1, 1, 0, 0, 1, 1 },
                { 0, 1, 0, 0, 0, 1, 0, 1 },
                { 0, 0, 0, 1, 0, 0, 0, 1 },
                { 0, 1, 1, 1, 0, 1, 0, 0 }
            };
        private static int PATHWAY_COLOR = 0;  // white
        private static int WALL_COLOR = 1;     // blue
        private static int BLOCKED_COLOR = 2;  // red, 이 셀은 이미 방문했으며 출구까지의 경로상에 있지 않을 경우입니다.
        private static int PATH_COLOR = 3;     // green, 이 셀은 이미 방문했으며 출구까지의 경로가 될 가능성이 있는 셀입니다.

        public static bool FindMazePath(int x, int y)
        {
            // 미로가 8 x 8 의 범위를 벗어난 경우 즉시 false를 반환
            if (x < 0 || y < 0 || x >= N || y >= N)
                return false;
            else if (maze[x, y] != PATHWAY_COLOR)   // 이동할 수 없는 모든 경우(벽, 이미 방문 등) false를 반환
                return false;
            else if (x == N - 1 && y == N - 1)      // x와 y가 모두 N-1 이면 출구이기 때문에 해당 위치를 PATH_COLOR로 변경하고 true를 반환
            {
                maze[x, y] = PATH_COLOR;
                return true;
            }
            else
            {
                // 그렇지 않은 일반적인 경우에는 우선 이미 방문한 경우이기에 해당 위치를 PATH_COLOR로 변경합니다.
                maze[x, y] = PATH_COLOR;

                // 이후 해당 위치의 셀들을 검증하기 위해서 또다시 FindMazePath를 호출합니다. (4방향)
                if (FindMazePath(x - 1, y) || FindMazePath(x, y + 1) || FindMazePath(x + 1, y) || FindMazePath(x, y - 1))
                    return true;

                // 위 모든 경우에 해당하지 않은 경우 어느 방향으로도 갈 수 없다는 의미이기에 해당 위치를 BLOCKED_COLOR로 변경하고 false를 반환합니다.
                maze[x, y] = BLOCKED_COLOR;     // dead end
                return false;
            }
        }

        public static void PrintMaze()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(maze[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
