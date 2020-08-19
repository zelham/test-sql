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
            DisplayMessage("text");

            Add1(5, 1);
            int result = Add2(3, 6);
        }

        /**************\
        |* Functions  *|
        \**************/
        // Practice 1: Write a function that outputs text
        static void DisplayMessage()
        {
            Console.WriteLine("message");
        }

        // Practice 2: Write a function called DisplayMessage that takes a string and outputs it
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Practice 3: Write a function called Add1 that takes two integers, adds them together and outputs the result
        static void Add1(int int1, int int2)
        {
            int result = int1 + int2;
            Console.WriteLine(result);
        }

        // Practice 4: Write a function called Add2 that takes two integers and returns the result
        static int Add2(int int1, int int2)
        {
            int result = int1 + int2;
            return result;
        }

        // Practice 5: Write a function called Add3 that takes two floats and returns the result


        // Practice 6: Write a function called Subtract that takes two integers and returns the result


        // Practice 7: Write a function called AddStrings that takes two strings, concatenates them and returns the new string


        /*********\
        |* Logic *|
        \*********/
        // Practice 1: Write a function called Max that compares two integers and returns the bigger one


        // Practice 2: Write a function called Min that compares two integers are returns the smaller one


        // Practice 3: Write a function called IsEqual that compares two integers and returns true if they are equal and false if not


        /**************\
        |* While Loop *|
        \**************/
        // Practice 1: Write a function called Spam that outputs the same text 10 times

        // Practice 2: Write another function called Spam that takes an integer and outputs the same text the number of times provided

        // Practice 3: Write another function called Spam that takes an integer and a string, and outputs the provided string the number of times provided
    }
}
