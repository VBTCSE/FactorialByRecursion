using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialByRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculates the value of m! (m-factorial)
            // Which is equal to 1 * 2 * 3 * ... * m, if m > 0
            // and is equal to 1, if m = 0.
            // This version of the program calculates the factorial recursively.

            int factorial = 1;  // Initialize the result value.



            // Get input from the user.
            int m = ConsoleIO.getNumber();



            if (m < 0)
            {
                ConsoleIO.showError();

                ConsoleIO.waitForKeypress();
            }
            else if (m == 0)
            {
                ConsoleIO.showResult(m, factorial);

                ConsoleIO.waitForKeypress();
            }
            else
            {
                factorial = F(m);   // calculate the factorial of m, recursively

                ConsoleIO.showResult(m, factorial);

                ConsoleIO.waitForKeypress();
            }

        }



        private static int F(int num)
        {
            int retval = 1; // the return value

            // Add code here to test the value of num and execute either 
            // the guard clause or the recursive step.

            //vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
            // Add your code here.
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            return retval;
        }
    }
}
