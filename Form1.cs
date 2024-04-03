using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Algoritmu_uzduotis
{
    public partial class Form1 : Form
    {
        List<Node> nodes = new List<Node>();
        List<Edge> edges = new List<Edge>();

        bool isDrawingNode;
        bool isErasingNode;
        bool isDrawingEdge;
        bool isErasingEdge;

        bool isEdgeStartFound;

        Node startingNode;
        Node endNode;
        public Form1()
        {
            InitializeComponent();
            stopButton.Visible = false;

            isDrawingNode = false;
            isErasingNode = false;
            isDrawingEdge = false;
            isErasingEdge = false;
            isEdgeStartFound = false;

            selectedFirstNodeLabel.Visible = false;
        }

        private void panel_Click(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (isDrawingNode)
            {
                Graphics g = panel1.CreateGraphics();
                string id;
                if (nodes.Count == 0)
                {
                    id = "0";
                }
                else
                {
                    int tempId = Int32.Parse(nodes[nodes.Count - 1].Id) + 1;
                    id = tempId.ToString();
                }
                Node node = new Node(id, new Point(e.X, e.Y));
                nodes.Add(node);
                redrawPanel();
            } else if (isErasingNode)
            {
                bool isFound = false;
                int nodeIndex = 0;
                foreach (Node node in nodes)
                {
                    if (
                        (e.X > node.Location.X - 15 && e.X < node.Location.X + 15) &&
                        (e.Y > node.Location.Y - 15 && e.Y < node.Location.Y + 15)
                        )
                    {
                        isFound = true;
                        nodeIndex = nodes.IndexOf(node);
                        break;
                    }
                }
                if(canNodeBeErased(nodeIndex))
                {
                    if (isFound)
                    {
                        nodes.RemoveAt(nodeIndex);
                        redrawPanel();
                    }
                } else
                {
                    MessageBox.Show("Please erase connected edges first!!", "Error", MessageBoxButtons.OK);
                }
                


            } else if (isDrawingEdge)
            {
                if (!isEdgeStartFound)
                {
                    foreach (Node node in nodes)
                    {
                        if (
                            (e.X > node.Location.X - 15 && e.X < node.Location.X + 15) &&
                            (e.Y > node.Location.Y - 15 && e.Y < node.Location.Y + 15)
                            )
                        {
                            selectedFirstNodeLabel.Text = $"Selected node: {node.Id}";
                            selectedFirstNodeLabel.Visible = true;
                            isEdgeStartFound = true;
                            startingNode = node;
                            break;
                        }
                    }
                }
                else
                {
                    bool endFound = false;
                    foreach (Node node in nodes)
                    {
                        if (
                            (e.X > node.Location.X - 15 && e.X < node.Location.X + 15) &&
                            (e.Y > node.Location.Y - 15 && e.Y < node.Location.Y + 15)
                            )
                        {
                            endNode = node;
                            endFound = true;
                            break;
                        }
                    }

                    if (endFound)
                    {
                        Graphics g = panel1.CreateGraphics();
                        string id;
                        if (edges.Count == 0)
                        {
                            id = "0";
                        }
                        else
                        {
                            int tempId = Int32.Parse(edges[edges.Count - 1].Id) + 1;
                            id = tempId.ToString();
                        }
                        Edge edge = new Edge(id, startingNode, endNode);
                        edges.Add(edge);
                        redrawPanel();
                        selectedFirstNodeLabel.Visible = false;
                        isEdgeStartFound = false;
                        endFound = false;
                    }

                }
            } else if (isErasingEdge)
            {
                if (!isEdgeStartFound)
                {
                    foreach (Node node in nodes)
                    {
                        if (
                            (e.X > node.Location.X - 15 && e.X < node.Location.X + 15) &&
                            (e.Y > node.Location.Y - 15 && e.Y < node.Location.Y + 15)
                            )
                        {
                            isEdgeStartFound = true;
                            startingNode = node;
                            selectedFirstNodeLabel.Text = $"Selected node: {node.Id}";
                            selectedFirstNodeLabel.Visible = true;
                            break;
                        }
                    }
                }
                else
                {
                    bool endFound = false;
                    int edgeIndex = 0;
                    foreach (Node node in nodes)
                    {
                        if (
                            (e.X > node.Location.X - 15 && e.X < node.Location.X + 15) &&
                            (e.Y > node.Location.Y - 15 && e.Y < node.Location.Y + 15)
                            )
                        {
                            endNode = node;
                            endFound = true;
                            break;
                        }
                    }

                    if (endFound)
                    {
                        foreach (Edge edge in edges)
                        {
                            if (edge.StartLocation == startingNode && edge.EndLocation == endNode)
                            {
                                edgeIndex = edges.IndexOf(edge);
                            }
                        }
                        edges.RemoveAt(edgeIndex);
                        redrawPanel();
                        selectedFirstNodeLabel.Visible = false;
                        isEdgeStartFound = false;
                        endFound = false;
                    }

                }
            }
        }

        private void redrawPanel()
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.White);
            foreach (Edge edge in edges)
            {
                edge.Draw(g);
            }
            foreach (Node node in nodes)
            {
                node.Draw(g);
            }
        }

        private bool canNodeBeErased(int selectedNodeIndex)
        {
            foreach(Edge edge in edges)
            {
                if (edge.StartLocation.Equals(nodes[selectedNodeIndex]) || edge.EndLocation.Equals(nodes[selectedNodeIndex]))
                {
                    return false;
                }
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopButton.Visible = true;

            addNodeButton.Enabled = false;
            deleteNodeButton.Enabled = false;
            addEdgeButton.Enabled = false;
            deleteEdgeButton.Enabled = false;

            isErasingNode = true;
        }

        private void addEdgeButton_Click(object sender, EventArgs e)
        {
            stopButton.Visible = true;

            addNodeButton.Enabled = false;
            deleteNodeButton.Enabled = false;
            addEdgeButton.Enabled = false;
            deleteEdgeButton.Enabled = false;

            isDrawingEdge = true;
        }

        private void deleteEdgeButton_Click(object sender, EventArgs e)
        {
            stopButton.Visible = true;

            addNodeButton.Enabled = false;
            deleteNodeButton.Enabled = false;
            addEdgeButton.Enabled = false;
            deleteEdgeButton.Enabled = false;

            isErasingEdge = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopButton.Visible = true;

            addNodeButton.Enabled = false;
            deleteNodeButton.Enabled = false;
            addEdgeButton.Enabled = false;
            deleteEdgeButton.Enabled = false;

            isDrawingNode = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            stopButton.Visible = false;

            addNodeButton.Enabled = true;
            deleteNodeButton.Enabled = true;
            addEdgeButton.Enabled = true;
            deleteEdgeButton.Enabled = true;

            isDrawingNode = false;
            isErasingNode = false;
            isDrawingEdge = false;
            isErasingEdge = false;

            selectedFirstNodeLabel.Visible = false;

            isEdgeStartFound = false;
        }

        private void selectedFirstNodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void eraseAllButton_Click(object sender, EventArgs e)
        {
            nodes.Clear();
            edges.Clear();
            redrawPanel();

            label2.Text = "";
            label3.Text = "";
            startTextBox.Text = "";
            selectedFirstNodeLabel.Text = "";


            stopButton.Visible = false;

            addNodeButton.Enabled = true;
            deleteNodeButton.Enabled = true;
            addEdgeButton.Enabled = true;
            deleteEdgeButton.Enabled = true;

            isDrawingNode = false;
            isErasingNode = false;
            isDrawingEdge = false;
            isErasingEdge = false;

            selectedFirstNodeLabel.Visible = false;

            isEdgeStartFound = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string temp = "";
            Graph graph = new Graph(nodes.Count, edges.Count);
            foreach(Edge edge in edges)
            {

                graph.addEdge(Int32.Parse(edge.StartLocation.Id), Int32.Parse(edge.EndLocation.Id));
                temp += "\n" + edge.StartLocation.Id + ", " + edge.EndLocation.Id + ";";
            }
            Console.Write(temp);
            if(startTextBox.Text != "")
            {
                Stopwatch stopwatchBFS = Stopwatch.StartNew();
                string a = BFS.executeBFS(Int32.Parse(startTextBox.Text), graph);
                stopwatchBFS.Stop();
                Stopwatch stopwatchDFS = Stopwatch.StartNew();
                string b = DFS.executeDFS(Int32.Parse(startTextBox.Text), graph);
                stopwatchDFS.Stop();
                label2.Text = "BFS: " + a + ". Time: " + stopwatchBFS.ElapsedTicks + " ticks";
                label3.Text = "DFS: " + b + ". Time: " + stopwatchDFS.ElapsedTicks + " ticks";
            }
            else
            {
                MessageBox.Show("Start must not be empty!!", "Error", MessageBoxButtons.OK);
            }
            

        }

    }
}