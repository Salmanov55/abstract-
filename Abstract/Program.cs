using System;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square();
            Rectangular r =new Rectangular();
            Console.WriteLine();
        }
    }
    abstract class Figure
    {
        public abstract float CalcArea();
     
    }
    class Square: Figure
    {
        public Square()
        {
        }

        public Square(int side)
        {
            this.side = side;
        }

        public int side 
        {
            get { return side; }
            set
            {
                if (value > 0)
                side = value;
            }
        }

        public override float CalcArea();
        class Rectangular: Figure
        {
            public Rectangular( int width, int length)
            {
                this.width = width;
                this.length = length;
            }

            public int width
            {
                get { return width; }
                set
                {
                    if (value > 0)
                    width = value;
                }
            }
            public int length
            {
                get { return length; }
                set
                {
                    if(value > 0)
                    length = value;
                }
            }

            public override float CalcArea()
            {
                Console.WriteLine();
            }
        }
    }
}
