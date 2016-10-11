using System.Collections.Generic;

namespace Hackerrank.io.KruskalAlgorithm
{
    /// <summary>
    ///     Definit un graphe
    /// </summary>
    public class Graph
    {
        public List<Edge> EdgeCollection = null;
        public Vertex v;
        public Vertex[] VertexCollection;

        /// <summary>
        /// Each graph is define by a edges collection and a vertices collection
        /// </summary>
        /// <param name="nodeNumber"></param>
        public Graph(int nodeNumber)
        {
            VertexCollection = new Vertex[nodeNumber];
            for (var i = 0; i < nodeNumber; i++)
            {
                v = new Vertex {Label = KruskalHelper.ConvertToText(i)};
                VertexCollection[i] = v;
            }
        }
    }
}