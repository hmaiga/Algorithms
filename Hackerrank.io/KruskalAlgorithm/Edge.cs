namespace Hackerrank.io.KruskalAlgorithm
{
    /// <summary>
    ///     Definit une arête ou un ensemble d'arêtes dans un graphe
    /// </summary>
    public class Edge
    {
        /// <summary>
        ///     Edge contructor
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="weight"></param>
        public Edge(Vertex source, Vertex destination, int weight)
        {
            FirstVertex = source;
            SecondVertex = destination;
            Weight = weight;
        }


        /// <summary>
        ///     Edge default contructor
        /// </summary>
        public Edge()
        {
        }

        public Vertex FirstVertex { get; set; }
        public Vertex SecondVertex { get; set; }
        public int Weight { get; set; }
    }
}