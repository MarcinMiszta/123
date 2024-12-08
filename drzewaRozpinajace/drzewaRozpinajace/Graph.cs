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
                sb.Append(new string("(" + edge.start.data.ToString() + ", " + edge.end.data.ToString() + ") " + edge.weight.ToString() + Environment.NewLine));
            }
            return sb.ToString();
        }
        public void Add(Edge k)
        {
            if (!this.edges.Contains(k))
            {
                this.edges.Add(k);
            }
            if (!this.nodes.Contains(k.start))
            {
                this.nodes.Add(k.start);
            }
            if (!this.nodes.Contains(k.end))
            {
                this.nodes.Add(k.end);
            }
        }
        public int ileNowychWezlow(Edge k)
        {
            int wynik = 0;
            if (!this.nodes.Contains(k.start))
            {
                wynik++;
            }
            if (!this.nodes.Contains(k.end))
            {
                wynik++;
            }
            return wynik;
        }
        void Graf(Edge k)
        {
            this.Add(k);
        }

        void Join(Graph g)
        {
            foreach(var k in g.edges)
            {
                this.Add(k);
            }
        }

        public Graph(List<NodeG> nodes, List<Edge> edges)
        {
            this.nodes = nodes;
            this.edges = edges;
        }
    } 

        
       
    
}
