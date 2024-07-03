using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05
{
    internal struct Point
    {
        // Attributes
        public int x;
        public int y;
        // Constructor is a special method
        //- has the same name of the struct
        //- has no return type
        public Point()
        {
            x = 0;
            y = 0;
        }
        // parameterized constructor
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
