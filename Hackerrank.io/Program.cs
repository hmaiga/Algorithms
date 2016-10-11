using System;
using System.Collections.Generic;
using System.Linq;
using Hackerrank.io.KruskalAlgorithm;

namespace Hackerrank.io
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var k = 1;
            //vertexNum => Denoting the number of nodes(vertices:sommets) in the graph
            var vertexNum = 4;
            var e = 0;
            //Graph and vertices number initialization
            var graphObject = new Graph(vertexNum);
            var verterCollection = graphObject.VertexCollection;
            var result = new Edge[vertexNum];

            //initialize collection for storing created edges.
            var edgeCollection = new List<Edge>();
            var edgeObj = new Edge();

            for (var i = 0; i < vertexNum; i++)
            {
                for (var j = 0; j < vertexNum; j++)
                {
                    if (i != j)
                    {
                        Console.Write(
                            $"Type edge weight from source_{KruskalHelper.ConvertToText(i)} to destination_{KruskalHelper.ConvertToText(j)} : ");
                        var weight = Convert.ToInt32(Console.ReadLine());
                        if (weight == 0)
                        {
                            continue;
                        }

                        edgeObj = new Edge(verterCollection[i], verterCollection[j], weight);
                        edgeCollection.Add(edgeObj);
                        k++;
                        //Console.Write("\n");
                    }
                }
            }

            graphObject.EdgeCollection = edgeCollection.ToList().OrderBy(p => p.Weight).ToList();

            var sub = new Subset[vertexNum];
            Subset subobj;
            for (var i = 0; i < vertexNum; i++)
            {
                subobj = new Subset();
                subobj.ParentVertex = verterCollection[i];
                subobj.Rank = 0;
                sub[i] = subobj;
            }
            k = 0;
            while (e < vertexNum - 1)
            {
                edgeObj = graphObject.EdgeCollection.ElementAt(k);
                var x = KruskalHelper.Find(sub, edgeObj.FirstVertex,
                    Array.IndexOf(graphObject.VertexCollection, edgeObj.FirstVertex), verterCollection);
                var y = KruskalHelper.Find(sub, edgeObj.SecondVertex,
                    Array.IndexOf(graphObject.VertexCollection, edgeObj.SecondVertex), verterCollection);
                if (x != y)
                {
                    result[e] = edgeObj;
                    KruskalHelper.Union(sub, x, y, graphObject.VertexCollection);
                    e++;
                }
                k++;
            }

            for (var i = 0; i < e; i++)
            {
                Console.WriteLine(
                    $"edge from source: {result[i].FirstVertex.Label} to destination: {result[i].SecondVertex.Label} with weight:{result[i].Weight}");
            }

            Console.ReadKey();
        }
    }
}