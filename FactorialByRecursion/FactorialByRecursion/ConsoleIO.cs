using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialByRecursion
{
    class ConsoleIO
    {
        public static int getNumber()
        {
            // Input a non-negative 32-bit integer from the user.
            // Return this value.


            int n = -1;  // Initial, default return value.  Returning -1 signals an error in this method.

            // Ask the user to enter a non-negative integer.
            // Reference: https://msdn.microsoft.com/en-us/library/system.console.write(v=vs.110).aspx
            Console.Write("Enter a non-negative integer: ");

            // Start a do-while loop to ensure that the input integer is non-negative.
            do
            {

                // Read in a line from the console.
                // Reference: https://msdn.microsoft.com/en-us/library/system.console.readline(v=vs.110).aspx
                string input = Console.ReadLine();


                // Parse the input string to an integer inside a try-catch block.
                // In the catch block, output the exception message and immediately return the initial, default value of n.
                // Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
                try
                {
                    // Try to convert the input string to an integer.
                    n = Int32.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);   // Output an error message if parsing cannot be done.
                    return n;   // Return the value n = -1, to signal an error.
                }

                // If n is negative, tell the user to enter a non-negative value.
                if (n < 0)
                {
                    // Reference: https://msdn.microsoft.com/en-us/library/system.console.write(v=vs.110).aspx
                    Console.WriteLine("The entered value is negative.  Enter a non-negative value.");
                }

            } while (n < 0);


            return n;   // Return the non-negative input integer n.
        }


        public static void showResult(int m, int f)
        {
            // Displays on the console the value of the input parameter f.

            Console.WriteLine("The value of {0} factorial is {1}.", m, f);
        }


        public static void showError()
        {
            Console.WriteLine("Error: could not resolve user's input.");
        }


        public static void waitForKeypress()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
