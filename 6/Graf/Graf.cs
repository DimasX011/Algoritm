using System;
using System.Collections.Generic;
using System.Text;

namespace Graf
{
    public class Graf
    {

        public Graphvertex ConnectedVertex { get; }

        public int EdgeWeight { get;  }


        public Graf(Graphvertex connectedVertex, int weight)
        {
            ConnectedVertex = connectedVertex;
            EdgeWeight = weight;
        }



    }
}
