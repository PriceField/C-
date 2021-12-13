using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice
{
    internal class EightQueens
    {
        int count = 0;
        public IEnumerable<char[,]> GetResult(int n)
        {
            char[,] graph = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Reset(n, graph);
                    count = n;
                    if (GetOneSolution(n, graph, i, j))
                    {
                        yield return graph;
                    }
                }
            }
        }

        private void Reset(int n, char[,] graph)
        {
            for (int k = 0; k < n; k++)
            {
                for (int l = 0; l < n; l++)
                {
                    graph[k, l] = '.';
                }
            }
        }

        private bool GetOneSolution(int n, char[,] graph, int x, int y)
        {
            graph = LocateQueen(n, graph, x, y);

            Console.WriteLine();
            PrintGraph(n, graph);
            return count == 0;
        }

        private char[,] LocateQueen(int n, char[,] graph, int x, int y)
        {
            if (count <= 0 || y >= n)
            {
                return graph;
            }

            if (x >= n)
            {
                return LocateQueen(n, graph, 0, y + 1);
            }

            //set backup
            char[,] copy = (char[,])graph.Clone();

            // check left right
            for (int i = 0; i < n; i++)
            {
                if (graph[i, y] == 'Q')
                {
                    return LocateQueen(n, graph, 0, y + 1);
                }
            }

            //check up down
            for (int i = 0; i < n; i++)
            {
                if (graph[x, i] == 'Q')
                {
                    return LocateQueen(n, graph, x + 1, y);
                }
            }

            //manipulate var
            int p = 0, q = 0;

            p = x;
            q = y;
            //check leftup
            while (p >= 0 && q >= 0)
            {
                if (graph[p, q] == 'Q')
                {
                    return LocateQueen(n, graph, x + 1, y);
                }
                p--;
                q--;
            }

            p = x;
            q = y;
            //check rightdown
            while (p < n && q < n)
            {
                if (graph[p, q] == 'Q')
                {
                    return LocateQueen(n, graph, x + 1, y);
                }
                p++;
                q++;
            }

            p = x;
            q = y;
            //check leftdown
            while (p >= 0 && q < n)
            {
                if (graph[p, q] == 'Q')
                {
                    return LocateQueen(n, graph, x + 1, y);
                }
                p--;
                q++;
            }

            p = x;
            q = y;
            //check rightup
            while (p < n && q >= 0)
            {
                if (graph[p, q] == 'Q')
                {
                    return LocateQueen(n, graph, x + 1, y);
                }
                p++;
                q--;
            }

            graph[x, y] = 'Q';
            count--;
            return LocateQueen(n, graph, 0, y + 1);
        }

        void PrintGraph(int n, char[,] graph)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(graph[i, j]);
                }
                Console.WriteLine();
            }

        }

    }
}
