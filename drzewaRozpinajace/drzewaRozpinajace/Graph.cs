using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace drzewaRozpinajace
{
    internal class Graph
    {
        List<NodeG> nodes = new List<NodeG>();
        List<Edge> edges = new List<Edge>();
        public void sort()
        {
            edges = edges.OrderBy(o => o.weight).ToList();

        }
        public String write()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Edge edge in edges)
            {
                sb.Append(new string("("+edge.start.data.ToString() + ", " + edge.end.data.ToString() + ") " + edge.weight.ToString()+Environment.NewLine));
            }
            return sb.ToString();
        }
        public Graph(List<NodeG> nodes, List<Edge> edges)
        {
            this.nodes = nodes;
            this.edges = edges;
        }
    }
}
