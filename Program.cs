using System;
using System.Text;

namespace InfiniteMonkeyTheorem
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomN, strLength = 100;

            StringBuilder monkeyBusiness = new StringBuilder("");

            

            for (int i=0; i<strLength; i++)
            {
                randomN = random.Next(97, 123);
                monkeyBusiness.Append((char)randomN);
            }

            Console.WriteLine(monkeyBusiness);
            

            
        }
    }
}
