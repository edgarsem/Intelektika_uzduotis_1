using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmu_uzduotis
{
    public class Graph
    {
        public int v;

        public int e;

        public int[,] adj;

        public Graph(int v, int e)
        {
            this.v = v;
            this.e = e;

            adj = new int[v, v];
            for (int row = 0; row < v; row++)
                for (int col = 0; col < v; col++)
                    adj[row, col] = 0;
        }
        public void addEdge(int start, int e)
        {
            adj[start, e] = 1;
            adj[e, start] = 1;
        }

    }
}
