using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Utility
    {
        
        public static double SumOfAreas(Square s,Rectangle r, Circle c)
        {
            double sum =0;
            sum += s.Area();
            sum += r.Area();
            sum += c.Area();
            return sum;
        }

      public static double SumOfAryasV2(params Geoshape[] _shapes)
        {
            double sum = 0;
            for(int i=0; i< _shapes.Length; i++)
            {
                sum += _shapes[i].Area();
            }
            return sum;
        }
    }
}
