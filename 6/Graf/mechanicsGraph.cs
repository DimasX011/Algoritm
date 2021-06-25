using System;
using System.Collections.Generic;
using System.Text;

namespace Graf
{
    public class mechanicsGraph
    {

        public Queue<string> Edge = new Queue<string>();
        public List<Graphvertex> Vertices { get; }

        public mechanicsGraph()
        {
            Vertices = new List<Graphvertex>();
        }
        public void nodevertex(string graf)
        {
            Vertices.Add(new Graphvertex(graf));
        }
        public void AddVertex(string vertexName)
        {
            Vertices.Add(new Graphvertex(vertexName));
        }
        public void BFS()
        {
            Console.WriteLine("Обход графа в ширину производится в следующем порядке:");
            Queue<string> graphvisited = new Queue<string>();
            
            while (Edge.Count!=0)
            {
                string Vertex = Edge.Dequeue();
                var vertex = FindVertex(Vertex);
                if (vertex.visited == false)
                {
                    graphvisited.Enqueue(Vertex);
                    vertex.visited = true;
                    Console.Write("=>" +Vertex+"|");
                }
            }
        }

        public void DFS()
        {
            Console.WriteLine();
            Console.WriteLine("Обход графа в глубину производится в следующем порядке:");
            Queue<string> graphvisites = new Queue<string>();
            Queue<string> allvertices = new Queue<string>();
            foreach(var v in Vertices)
            {
                allvertices.Enqueue(v.Name);
            }
            while (!(allvertices == null))
            {
                if (allvertices.Count == 0)
                {
                    return;
                }
                string Vertex = allvertices.Dequeue();
                var vertex = FindVertex(Vertex);
                if(vertex.visit == false)
                {
                    graphvisites.Enqueue(Vertex);
                    vertex.visit = true;
                    Console.Write("=>" + Vertex +"|");
                    if (allvertices.Count == 0)
                    {
                        return;
                    }
                    string nextlvl = allvertices.Dequeue();
                    var Nextlvl = FindVertex(nextlvl);
                    if(vertex.connectvertex == Nextlvl||Nextlvl.visit == false)
                    {
                        var nextvert = vertex.connectvertex;
                        graphvisites.Enqueue(nextlvl);
                        Console.Write("=>" + Nextlvl + "|");
                        Nextlvl.visit = true;  
                        while(vertex!= null)
                        {
                            vertex = nextvert;
                            if(vertex == null)
                            {
                                break;
                            }
                            if (vertex.visit == false)
                            {
                                graphvisites.Enqueue(vertex.Name);
                                Console.Write("=>" + vertex + "|");
                                vertex.visit = true;
                            }
                            nextvert = vertex.connectvertex;
                        }
                    }
                }
            }
        }


        public Graphvertex FindVertex(string vertexName)
        {
            foreach (var v in Vertices)
            {
                if (v.Name == vertexName)
                {
                    return v;
                }
            }
            return null;
        }

        public void AddEdge(string firstName, string secondName, int weight)
        {
            string[] adjacent = new string[2];
            var v1 = FindVertex(firstName);
            var v2 = FindVertex(secondName);
            if (v2 != null && v1 != null)
            {
                v1.AddEdge(v2, weight);            
                v2.AddEdge(v1, weight);
                v1.connectvertex = v2;
                adjacent[0] = v1.Name;
                adjacent[1] = v2.Name;
                Edge.Enqueue(adjacent[0]);
                Edge.Enqueue(adjacent[1]);
            }
        }
    }
}
