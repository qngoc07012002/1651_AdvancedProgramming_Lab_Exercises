﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Exercises
{
    internal class PositionPB6
    {
        private int x;
        private int y;

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        public PositionPB6(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
