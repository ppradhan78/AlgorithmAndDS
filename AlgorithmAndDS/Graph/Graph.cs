using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Graph
{
    public class Graph
    {

        // inner class to keep track of edges
        public class Edge
        {
            public int src, dest;
        }
        // number of vertices and edges
        public int vertices, edges;
        // array to store all edges
        public Edge[] edge;

        public Graph(int vertices, int edges)
        {
            this.vertices = vertices;
            this.edges = edges;

            // initialize the edge array
            edge = new Edge[edges];
            for (int i = 0; i < edges; i++)
            {
                // each element of the edge array is an object of Edge type
                edge[i] = new Edge();
            }
        }
    }
}
