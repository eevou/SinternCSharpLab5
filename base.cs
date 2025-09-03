using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{

    //class Base
    //{
    //    protected int x;
    //    protected int y;

    //    public Base()
    //    {
    //        x = y = 0;
    //    }
    //    public Base(int _x, int _y)
    //    {
    //        x = _x;
    //        y = _y;
    //    }
    //    public void Show()
    //    {
    //        Console.WriteLine("Iam base");
    //    }
    //}

    class Base
    {
        protected int x;
        protected int y;

        public Base()
        {
            x = y = 0;
        }
        public Base(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public virtual void Show()
        {
            Console.WriteLine("Iam base");
        }
    }
}

      

