using System;

namespace Classes2
{
    internal class Circle
    {
        private int v;

        internal double area(int v)
        {
            return v * v * Math.PI;
        }

        internal string Greeting()
        {
            return "My name is circle";
        }
    }
}