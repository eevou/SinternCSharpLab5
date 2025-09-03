using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    /* public class Derived2:Derived
     {

         int a;
         public Derived2()
         {
             a = 0;
         }
         public Derived2(int _x, int _y, int _z, int _a) : base(_x, _y, _z)
         {
             a = _a;
         }
         public void Show()
         {
             Console.WriteLine("Iam derived2");
         }
     }
 }
    */
    class Drived2 : Drived
    {
        int a;
        public Drived2()
        {
            a = 0;
        }
        public Drived2(int _x, int _y, int _z, int _a) : base(_x, _y, _z)
        {
            a = _a;
        }
        public void Show()
        {
            Console.WriteLine("Iam derived2");
        }
    }
}





