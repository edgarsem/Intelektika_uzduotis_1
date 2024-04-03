using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmu_uzduotis
{
    public class BFS
    {

        public static string executeBFS(int start, Graph graph)
        {
            string output = "";

            bool[] visited = new bool[graph.v];
            List<int> q = new List<int>();
            q.Add(start);

            visited[start] = true;

            int vis;
            while (q.Count != 0)
            {
                vis = q[0];

                output += (vis + " ");
                Console.Write(vis + " ");
                q.Remove(q[0]);

                for (int i = 0; i < graph.v; i++)
                {
                    if (graph.adj[vis, i] == 1 && (!visited[i]))
                    {
                        q.Add(i);
                        visited[i] = true;
                    }
                }
            }
            return output;
        }


    }
}
