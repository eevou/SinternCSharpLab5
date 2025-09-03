using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Circle:Geoshape
    {
        public Circle() 
        {
            Console.WriteLine("def constr of Circle");
        }
        public Circle(double _radis):base(_radis,_radis)
        {

            Console.WriteLine("def constr of Circle");
        }
        public override double Area()
        {
            return (22 / 7) * dim1 * dim1;
        }

    }
}
