using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1__Classes_and_Objects_.Task_4
{
    class Point
    {
        int x;
        int y;
        string type;
        //---------------------

        public Point(string type) 
        {
            this.type = type; 
        }
        //----------------------------------------------

        public Point(int x, int y, string type)
        {
            this.x = x;
            this.y = y;
            this.type = type;
        }
        //----------------------------------------------

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string Type { get { return type; } }
        //----------------------------------------------
    }
}
