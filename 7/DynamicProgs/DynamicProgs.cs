using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgs
{
    public class DynamicProgs
    {
        public int Dynamicprogs(int N, int M)
        {
            bool[,] map = new bool[N, M];
            int[,] A = new int[N, M];
            int i, j;

            for (int q = 0; q < M; q++)
            {
                for (int c = 0; c < N; c++)
                {
                    map[q, c] = true;
                }
            }
            map[2, 5] = false;
            map[6, 5] = false;
            map[7, 5] = false;

            for (j = 0; j < M; j++)
                A[0, j] = 1;

            for (i = 1; i < N; i++)
            {
                A[i, 0] = 1;
                for (j = 1; j < M; j++)
                    if (map[i, j] == true)
                    {
                        A[i, j] = A[i, j - 1] + A[i - 1, j];
                    }
            }
            return Print2(N, M, A); ;
        }

        public int Print2(int n, int m, int[,] a)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++) ;
            }
            int answer = a[i - 1, n - 1];
            return answer;
        }

    }
}
