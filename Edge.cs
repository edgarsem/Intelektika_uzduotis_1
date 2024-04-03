using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmu_uzduotis
{
    public class Edge
    {
        public Node StartLocation { get; set; }

        public Node EndLocation { get; set; }
        public string Id { get; set; }

        public Edge(string id, Node startLocation, Node endLocation)
        {
            Id = id;
            StartLocation = startLocation;
            EndLocation = endLocation;
        }

        public void Draw(Graphics g)
        {
            g.DrawLine(Pens.Black, StartLocation.Location, EndLocation.Location);
        }

        public void getStartLoactionId()
        {

        }
    }
}
