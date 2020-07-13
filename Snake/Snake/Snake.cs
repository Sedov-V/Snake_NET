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
        Direction direction;

        public Snake(Point tale, int lenght, Direction direction)
        {
            this.direction = direction;

            pointList = new List<Point>();

            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tale);
                p.Move(i, direction);
                pointList.Add(p);
            }
        }
        internal void Move()
        {
            Point tail = pointList.First();
            pointList.Remove(tail);
            Point head = GetNextPoint();
            pointList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pointList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
