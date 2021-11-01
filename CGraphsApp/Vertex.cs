using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGraphsApp
{
    public class Vertex
    {
        private List<Edge> Edges { get; set; }
        public bool IsIsolated => Edges?.Count == 0;

    }
}
