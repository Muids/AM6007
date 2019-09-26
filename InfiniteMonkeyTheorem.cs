/*
 *      
 *           AM6007 : Scientific Computing with Numerical Examples
 *           Author : Akshay Ranade   
 *           ****************************************************************************************************************
 *             
 *           Program for the Infinite Monkey Theorem exercise from tutorial 2.  
 *            
 *
 *           ****************************************************************************************************************
 */


using System;
using System.Text;

namespace InfiniteMonkeyTheorem
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();                        // instantiating a "Random" object
            int randomN;                                         // variable to hold the random integer generated at each iteration
            int strLength = 999999;                                 // desired length of the random string

            int startRange = 97;                                 // starting point for random unicode characters
            int endRange = 123;                                  // end point for random characters NOTE Random.Next is not inclusive!!!
            string searchString = "cat";                      // desired search string

            int index;                                           // variable to save index returned by String.Compare

            StringBuilder monkeyBusiness = new StringBuilder();     // instantiating a "StringBuilder" object 


            // Generating 
            for (int i = 0; i < strLength; i++)
            {
                randomN = random.Next(startRange, endRange);
                monkeyBusiness.Append((char)randomN);
            }

            string monkeyString = monkeyBusiness.ToString();    // converting the StringBuilder instance to get string

            Console.WriteLine("Our genius monkey has come up with : ");
            Console.WriteLine(monkeyString);

            index = monkeyString.IndexOf(searchString);

            if (index != -1)                          // If search string has been found
            {
                Console.WriteLine("Congratulations! Your string has been found!");
                Console.WriteLine(index);

                for (int i = 0; i < searchString.Length + 4; i++)
                {
                    Console.Write(monkeyString[index - 2 + i]);
                }
            }
        }
    }
}
