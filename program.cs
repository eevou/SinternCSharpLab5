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


//1.Rectangle r1 = new Rectangle();
//•	Calls Rectangle default constructor.
//•	Calls Geoshape default constructor (base).
//•	Prints: def constr of Geoshape
//•	Prints: def ctor of Rec
//---
//2. Rectangle r2 = new Rectangle(17.5, 33.5);
//•	Calls Rectangle parameterized constructor.
//•	Calls Geoshape parameterized constructor (base) with swapped parameters.
//•	Prints: param ctr of Geoshape
//•	Prints: param ctor of Rec
//---
//3. Console.WriteLine("-------------------------");
//•	Prints separator.
//---
//4.Square s1 = new Square();
//•	Calls Square default constructor.
//•	Calls Geoshape default constructor (base).
//•	Prints: def constr of Geoshape
//•	Prints: def constr of Square
//---
//5. Square s2 = new Square(2);
//•	Calls Square parameterized constructor.
//•	Calls Geoshape parameterized constructor (base).
//•	Prints: param ctr of Geoshape
//•	Prints: param ctor of square
//---
//6. Console.WriteLine("--------------------------");
//•	Prints separator.
//---
//7.SquareV2 s = new SquareV2();
//•	Calls SquareV2 default constructor.
//•	Calls Rectangle default constructor (base).
//•	Calls Geoshape default constructor (base).
//•	Prints: def constr of Geoshape
//•	Prints: def ctor of Rec
//•	Prints: def constr of squarev2
//---
//8. Console.WriteLine("_______________________");
//•	Prints separator.
//---
//9.Base b1 = new Base();
//•	Calls Base default constructor.
//---
//10. b1.Show();
//•	Calls Base.Show().
//•	Prints: Iam base
//-- -
//11.Base b2 = new Drived();
//•	Calls Drived constructor (inherits from Base).
//---
//12. b2.Show();
//•	Calls Drived.Show()(overrides Base.Show()).
//•	Prints: (whatever is implemented in Drived.Show())
//---
//13.Console.WriteLine("________________________");
//•	Prints separator.
//---
//14.Base b3 = new Drived();
//•	Calls Drived constructor.
//---
//15. b3.Show();
//•	Calls Drived.Show()(dynamic binding).
//•	Prints: (whatever is implemented in Drived.Show())
//---
//16.Sum of Areas
//•	Square sq = new Square(4);
//•	Calls Square parameterized constructor.
//•	Calls Geoshape parameterized constructor.
//•	Prints: param ctr of Geoshape
//•	Prints: param ctor of square
//•	Rectangle r = new Rectangle(3, 4);
//•	Calls Rectangle parameterized constructor.
//•	Calls Geoshape parameterized constructor.
//•	Prints: param ctr of Geoshape
//•	Prints: param ctor of Rec
//•	Circle c = new Circle(4);
//•	Calls Circle parameterized constructor.
//•	Calls Geoshape parameterized constructor.
//•	Prints: param ctr of Geoshape
//•	Prints: (Circle's constructor message)
//-- -
//17.Console.WriteLine(Utility.SumOfAreas(sq, r, c));
//•	Calls static method Utility.SumOfAreas.
//•	Calls Area() on each shape and sums the results.
//•	Prints the sum.
//---
//18. Geoshape[] shapes = { sq, r, c };
//•	Creates an array of shapes.
//---
//19. Console.WriteLine(Utility.SumOfAryasV2(shapes));
//•	Calls static method Utility.SumOfAryasV2.
//•	Iterates through array, calls Area() on each, sums, and prints the result.
//---
//Summary
//•	The code demonstrates object creation, constructor chaining, inheritance, polymorphism (both early and late binding), and static utility methods.
//•	Each step prints messages to the console, showing the order of constructor and method calls.
//•	The flow is strictly top-to-bottom as written in Main.
//If you need a visual flowchart or more details on any specific step, let me know!
