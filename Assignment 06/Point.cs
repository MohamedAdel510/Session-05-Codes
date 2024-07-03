using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06
{
    internal struct Point
    {
        public int X;
        public int Y;
        
        public Point() { 
            X = 0; Y = 0;
        }
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
