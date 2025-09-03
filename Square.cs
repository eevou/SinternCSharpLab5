using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Square : Geoshape
    {
        public Square()
        {
            Console.WriteLine("def constr of square");
        }
        public Square(double _dim1) : base(_dim1, _dim1)
        {

            Console.WriteLine("param of square");
        }
        public override double Area()
        {
            return dim1 * dim2;

        }

    }
    public class SquareV2 : Rectangle
    {
        public SquareV2()
        {
            Console.WriteLine("def cotor of squareV2");
        }
        public SquareV2(double _dim1) : base(_dim1, _dim1)
        {
            {
                Console.WriteLine("param ctor of squareV2");
            }

        }
    }
}
