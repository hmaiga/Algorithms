namespace Hackerrank.io.KruskalAlgorithm
{
    /// <summary>
    ///     Definit un sous graphe, i.e un arbre d'un graphe
    /// </summary>
    public class Subset
    {
        public Vertex ParentVertex { get; set; }
        public int Rank { get; set; }
    }
}