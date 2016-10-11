using System;
using System.Linq;

namespace Hackerrank.io.KruskalAlgorithm
{
    public class KruskalHelper
    {
        public static Vertex Find(Subset[] sub, Vertex vertex, int k, Vertex[] vertdic)
        {
            if (sub[k].ParentVertex != vertex)
            {
                sub[k].ParentVertex = Find(sub, sub.ElementAt(k).ParentVertex,
                    Array.IndexOf(vertdic, sub.ElementAt(k).ParentVertex), vertdic);
                    // find(sub, vertex, Array.IndexOf(vertdic,vertex),vertdic);//sub.Select(j => j.parent).Where(v => v.Label == vertex.Label).FirstOrDefault();
            }

            return sub[k].ParentVertex;
        }

        public static void Union(Subset[] sub, Vertex xr, Vertex yr, Vertex[] vertcoll)
        {
            var x = Find(sub, xr, Array.IndexOf(vertcoll, xr), vertcoll);
            var y = Find(sub, yr, Array.IndexOf(vertcoll, yr), vertcoll);

            if (sub[Array.IndexOf(vertcoll, x)].Rank < sub[Array.IndexOf(vertcoll, y)].Rank)
            {
                sub[Array.IndexOf(vertcoll, x)].ParentVertex = y;
            }
            else if (sub[Array.IndexOf(vertcoll, x)].Rank > sub[Array.IndexOf(vertcoll, y)].Rank)
            {
                sub[Array.IndexOf(vertcoll, y)].ParentVertex = x;
            }
            else
            {
                sub[Array.IndexOf(vertcoll, y)].ParentVertex = x;
                sub[Array.IndexOf(vertcoll, x)].Rank++;
            }
        }

        public static string ConvertToText(int x)
        {
            var xToText = "";
            switch (x)
            {
                case 0:
                    xToText = "A";
                    break;
                case 1:
                    xToText = "B";
                    break;
                case 2:
                    xToText = "C";
                    break;
                case 3:
                    xToText = "D";
                    break;
                default:
                    xToText = "Error";
                    break;
            }

            return xToText;
        }
    }
}