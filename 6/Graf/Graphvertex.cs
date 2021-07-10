using System;
using System.Collections.Generic;
using System.Text;

namespace Graf
{
    public class Graphvertex
    {
        public string Name { get; }

        public bool visited = false;

        public bool visit = false;

        public List<Graf> Edges { get; }

        public Graphvertex connectvertex { get; set; }

   
        public Graphvertex(string vertexName)
        {
            Name = vertexName;
            Edges = new List<Graf>();
        }

        

        public void AddEdge(Graf newEdge)
        {
            Edges.Add(newEdge);
        }

        public void AddEdge(Graphvertex vertex, int edgeWeight)
        {
            AddEdge(new Graf(vertex, edgeWeight));
        }

        public override string ToString() => Name;
    }
}
