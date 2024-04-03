using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmu_uzduotis
{
    public class DFS
    {

        static string dfs(int start, List<bool> visited, Graph graph, string output)
        {

            Console.Write(start + " ");
            output += (start + " ");

            visited[start] = true;

            for (int i = 0; i < graph.v; i++)
            {
                if (graph.adj[start, i] == 1 && !visited[i])
                {
                    output = dfs(i, visited, graph, output);
                }
            }
            return output;
        }

        public static string executeDFS(int start, Graph graph)
        {
            string output = "";
            List<bool> visited = new List<bool>(graph.v);
            for (int i = 0; i < graph.v; i++)
            {
                visited.Add(false);
            }
            output += dfs(start, visited, graph, output);
            return output;
        }
    }
}
