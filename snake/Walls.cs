using SnakeOOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Walls
    {
        private int v1;
        private int v2;

        public Walls(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        internal void Draw() => throw new NotImplementedException();

        internal bool IsHit(Snake snake)
        {
            throw new NotImplementedException();
        }
    }
}
