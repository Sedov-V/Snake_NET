using System;
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
            /*
            Point p1 = new Point(1, 4, '#');
            p1.Draw();

            Point p2 = new Point(6, 9, '*');
            p2.Draw();
            */

            List<int> numList = new List<int>();

            numList.Add(3);
            numList.Add(7);
            numList.Add(1);
            numList.Add(2);
            numList.Add(9);

            foreach (int num in numList)
                Console.WriteLine(num);

            Console.WriteLine();

            numList.Sort();
            foreach (int num in numList)
                Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
