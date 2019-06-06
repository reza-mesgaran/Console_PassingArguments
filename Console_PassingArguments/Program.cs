using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_PassingArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            int x =1;
            Console.WriteLine("The x Initialized to 1");

            byVal(x);
            Console.WriteLine("Passing Arguments by value (default):"+x);

            byIn(in x);
            Console.WriteLine("Passing Arguments by In: (Read-Only) " + x);

            byRef(ref x);
            Console.WriteLine("Passing Arguments by reference:"+ x);

            byOut(out x);
            Console.WriteLine("Passing Arguments by Out:"+ x);



            Console.ReadKey();

        }


        //------------ value
        static void byVal(int x)
        {
            x = 10;
        }

        //------------ In
        static void byIn(in int x)
        {
            // x = 40;  Cause an error  (-In- parameter is Read-Only) 
        }

        //------------ Ref
        static void byRef(ref int x)
        {
            x = 20;
        }
        //------------ Out
        static void byOut(out int x)
        {
            x = 30;  //
        }
    }

}

/* Note : out parameter doesn't need to be initialized BUT
 ref parameter should initialized  */
