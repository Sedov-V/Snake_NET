using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pointList;

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pointList = new List<Point>();

            for (int y = yUp; y <= yDown; y++)
                pointList.Add(new Point(x, y, sym));
        }

        public void Draw()
        {
            foreach (Point p in pointList)
                p.Draw();
        }
    }
}
