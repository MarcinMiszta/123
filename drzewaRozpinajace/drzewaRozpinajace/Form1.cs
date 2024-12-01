namespace drzewaRozpinajace
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        
           
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            List<NodeG> punkty = new List<NodeG>();
            List<Edge> krawedzie = new List<Edge>();

            punkty.Add(new NodeG(0));
            punkty.Add(new NodeG(1));
            punkty.Add(new NodeG(2));
            punkty.Add(new NodeG(3));
            punkty.Add(new NodeG(4));
            punkty.Add(new NodeG(5));
            punkty.Add(new NodeG(6));
            punkty.Add(new NodeG(7));

            krawedzie.Add(new Edge(punkty[0], punkty[1], 5));
            krawedzie.Add(new Edge(punkty[0], punkty[3], 9));
            krawedzie.Add(new Edge(punkty[0], punkty[6], 3));
            krawedzie.Add(new Edge(punkty[1], punkty[4], 8));
            krawedzie.Add(new Edge(punkty[1], punkty[2], 9));
            krawedzie.Add(new Edge(punkty[1], punkty[5], 6));
            krawedzie.Add(new Edge(punkty[1], punkty[7], 7));
            krawedzie.Add(new Edge(punkty[2], punkty[3], 9));
            krawedzie.Add(new Edge(punkty[2], punkty[4], 4));
            krawedzie.Add(new Edge(punkty[2], punkty[6], 5));
            krawedzie.Add(new Edge(punkty[2], punkty[7], 3));
            krawedzie.Add(new Edge(punkty[3], punkty[6], 8));
            krawedzie.Add(new Edge(punkty[4], punkty[6], 1));
            krawedzie.Add(new Edge(punkty[4], punkty[5], 2));
            krawedzie.Add(new Edge(punkty[5], punkty[6], 6));
            krawedzie.Add(new Edge(punkty[6], punkty[7], 9));
            Graph graf = new Graph(punkty, krawedzie);
            graf.sort();
            graf.write();
            textBox1.Text = graf.write();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}