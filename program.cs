using lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            //Calls Rectangle default constructor.
            //Calls Geoshape default constructor(base).
            //Prints: def constr of Geoshape
            //Prints: def ctor of Rec
            Rectangle r2 = new Rectangle(17.5, 33.5);
            //Calls Rectangle parameterized constructor.
            //Calls Geoshape parameterized constructor(base) with swapped parameters.
            //Prints: param ctr of Geoshape
            //Prints: param ctor of Rec
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

            Square s1 = new Square();
            //  Calls Square default constructor.
            //	Calls Geoshape default constructor (base).
            //	Prints: def constr of Geoshape
            //	Prints: def constr of Square

            Square s2 = new Square(2);

            //Calls Square parameterized constructor.
            //Calls Geoshape parameterized constructor(base).
            //Prints: param ctr of Geoshape
            //Prints: param ctor of square

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

            SquareV2 s = new SquareV2();

            //alls SquareV2 default constructor.
            //	Calls Rectangle default constructor (base).
            //	Calls Geoshape default constructor (base).
            //	Prints: def constr of Geoshape
            //	Prints: def ctor of Rec
            //	Prints: def constr of squarev2


            Base b1 = new Base();// Calls Base default constructor.
            b1.Show(); //Calls Base.Show().
                       //	Prints: Iam base

            #region earlybinding


            Base b2 = new Drived();  //	Calls Drived constructor (inherits from Base).
            b2.Show(); // Calls Drived.Show()(overrides Base.Show()).
                       //	Prints: (whatever is in Drived.Show())

            #endregion

            #region dynamic binding

            Base b3 = new Drived(); //Calls Drived constructor.
            b3.Show();  //	Calls Drived.Show()(dynamic binding).
                        //	Prints: (whatever is implemented in Drived.Show())
            #endregion
            #region SumOfAreas
            Square sq = new Square(4);
            //  Calls Square parameterized constructor.
            //	Calls Geoshape parameterized constructor.
            //	Prints: param ctr of Geoshape
            //	Prints: param ctor of square
            Rectangle r = new Rectangle(3, 4);
            //Calls Rectangle parameterized constructor.
            //Calls Geoshape parameterized constructor.
            //Prints: param ctr of Geoshape
            //Prints: param ctor of Rec
            Circle c = new Circle(4);
            // Calls Circle parameterized constructor.
            //Calls Geoshape parameterized constructor.
            //	Prints: param ctr of Geoshape
            //	Prints: (Circle's constructor message)
            Console.WriteLine(Utility.SumOfAreas(sq, r, c));
            Geoshape[] shapes = { sq, r, c };
            Console.WriteLine(Utility.SumOfAryasV2(shapes));

            #endregion


        }
    }
}


