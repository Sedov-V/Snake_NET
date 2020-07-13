using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point tale, int lenght, Direction direction)
        {
            pointList = new List<Point>();

            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tale);
                p.Move(i, direction);
                pointList.Add(p);
            }
        }
    }
}
