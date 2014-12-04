using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = Heller("123456789123456789");
            Console.WriteLine(value1);
            Console.ReadKey();

        }
        static int Heller(string rootThis)
        {
            //sum can only be used in a lambda, and x had to be converted to a string
            //before int parse would work for it
            int results = rootThis.Sum(x => int.Parse(x.ToString()));
            //set the boolean
            bool stillGoing = true;
            do
            {
                //essentially if the results were double digits
                if (results >= 10)
                {
                    //it would take results and add its digits
                    //then return the new number
                    int resultsresults = results.ToString().Sum(x=>int.Parse(x.ToString()));
                    return resultsresults;
                }
                    //but if it was a single digit, it would just return the result
                else if (results < 10) { return results; }
                //the loop would end after that
                stillGoing = false;
            } while (stillGoing);
            //returns the results
            return results;
        }
        static int DigitalRootWithRecursion(string rootThis)
        {
            //check to make sure its a number
            if (rootThis.Count(x => char.IsNumber(x)))
            {
                //its true, each character was a number
                while (rootThis.Length > 1)
                {
                    //rootThis is greater than 1 digit
                    //sum all the numbers
                    int total = 0;
                    foreach (char digit in rootThis)
                    {
                        total += int.Parse(digit.ToString());

                    }
                    //Place our new total as the rootThis input
                    rootThis = total.ToString();
                }
                //completed the loop
                //only has 1 digit
                return int.Parse(rootThis);
            }
            else
            {
                //false, not every character was a number
                return -1;
            }
        }
    }
}