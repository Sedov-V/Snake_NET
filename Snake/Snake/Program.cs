﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Point p1 = new Point(1, 4, '#');
            p1.Draw();

            Point p2 = new Point(6, 9, '*');
            p2.Draw();

            HorizontalLine hLine = new HorizontalLine(3, 10, 2, '-');
            hLine.Draw();

            VerticalLine vLine = new VerticalLine(0, 20, 7, '|');
            vLine.Draw();

            Console.ReadLine();
        }
    }
}
