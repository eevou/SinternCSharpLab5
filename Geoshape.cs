using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public  abstract class Geoshape
    {
        protected double dim1;
        protected double dim2;
        public double Dim1
        {

            get { return dim1; }
            set { dim1 = value; }
        }
        public double Dim2
        {

            get { return dim2; }
            set { dim2 = value; }
        }
        public  Geoshape()
        {
            dim1 = 0;
            dim2 = 0;
            Console.WriteLine("def constr of Geoshape");
        }
        public Geoshape(double _dim1,double _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
            Console.WriteLine("param ctr of Geoshape");
        }
        public abstract double Area();

    }
}
