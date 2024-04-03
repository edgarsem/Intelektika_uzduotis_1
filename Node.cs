using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmu_uzduotis
{
    public class Node
    {
        public Point Location { get; set; }
        public string Id { get; set; }

        public Node(string id, Point location)
        {
            Id = id;
            Location = location;
        }

        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Black, Location.X - 15, Location.Y - 15, 30, 30);
            g.DrawString(Id, SystemFonts.DefaultFont, Brushes.White, Location - new Size(5, 7));
        }

        public void Erase(Graphics g)
        {


        }
    }
}
