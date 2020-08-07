using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        /**************\
|* Functions  *|
\**************/
        // Practice 1: Write a function that outputs text


        // Practice 2: Write a function that takes a string and outputs it
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Practice 3: Write a function that takes two integers, adds them together and outputs the result
        static void Addition(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        // Practice 4: Write a function that takes two integers and returns the result
        static int Addition2(int number1, int number2)
        {
            return  number1 + number2;
        }

        // Practice 5: Write a function that takes two strings, concatenates them and returns a new string
        static string AddStrings(string word1, string word2)
        {
            return word1 + word2;
        }

        /*********\
        |* Logic *|
        \*********/
        // Practice 1: Write a function that compares two integers and returns the bigger one
        static int Max(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        // Practice 2: Write a function that compares two integers are returns the smaller one
        static int Min(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        // Practice 3: Write a function that compares two integers and returns true if they are equal and false if not


        /**************\
        |* While Loop *|
        \**************/
        // Practice 1: Write a function that outputs the same text 10 times

        // Practice 2: Write a function that takes an integer and outputs the same text the number of times provided

    }
}
