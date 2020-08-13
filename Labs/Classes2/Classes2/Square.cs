using System;

namespace Classes2
{
    class Square
    {
        int side;

        public Square(int s)
        {
            side = s;
        }
        public int area(int side)
        {
            return side * side;
        }
        
        public string Hello()
        {
            return $"This is square and my side {side}";
        }
    }
}
