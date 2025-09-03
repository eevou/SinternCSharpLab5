using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{

    class Drived : Base
    {
        int z;
        public Drived()
        {
            z = 0;
        }
        public Drived(int _x, int _y, int _z) : base(_x, _y)
        {
            z = _z;
        }
        public override void Show()
        {
            Console.WriteLine("Iam derived");
        }
    }
}
