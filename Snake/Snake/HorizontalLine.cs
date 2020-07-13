using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pointList;

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pointList = new List<Point>();

            for (int x = xLeft; x <= xRight; x++)
                pointList.Add(new Point(x, y, sym));
        }

        public void Draw()
        {
            foreach (Point p in pointList)
                p.Draw();
        }
    }
}
