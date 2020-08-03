using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReviews
{
    class Program
    {
        static void Main(string[] args)
        {
            // What is the value of result?
            var result = Question1(2, 3);

            // What does this function do?
            Question2(result);

            // Can you fix this function?
            Question3();
        }

        static int Question1(int number1, int number2)
        {
            return number1 + number2;
        }

        static void Question2(int result)
        {
            string message = "The result is: ";
            Console.WriteLine(message + result);
        }

        static void Question3()
        {
            {
                string world = "world";
            }

            {
                Console.WriteLine("Hello " + world);
            }
        }
    }
}
