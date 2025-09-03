using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Rectangle:Geoshape
    {
        public Rectangle()
        {
            //  useless
            // dim1 = dim1 = 0;
            Console.WriteLine("def ctor of Rec");
        }
        public Rectangle(double _dim1, double _dim2) : base(_dim2, _dim1)
        {
           
            Console.WriteLine("param ctor of Rec");
        }
        //public Rectangle(double _dim1, double _dim2)
        //{
        //    dim1 = _dim1;
        //    dim2 = _dim2;
        //    Console.WriteLine("param ctor of Rec");
        //}
        public override double Area()
        {
            return dim1 * dim2;

        }
          

    }
}
