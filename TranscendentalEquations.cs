using System;

namespace TranscendentalEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transcendental Equations");
            int maxIter = 1000;                        // maximum number of iterations allowed
            double tol = 1E-3;                         // tolerance allowed in numerical solution (for stopping criterion) 

            double x0 = 0.5;                           // initial guess
            double x1; 
            /*
                TODO : 1.) double array to store the values at each iteration 
                       2.) logic to detect divergence or oscillation and stop the iterative solver

             */

            for (int i = 0; i < maxIter; i++)            // The iterative solution
            {
                x1 = Equation(x0);                       // set x_{n+1} to the f(x_n); 
                                                         // in this version we just cycle between x0 and x1
                                                         // this saves space; it might be necessary sometimes to save the entire trajectory however

                if (Math.Abs(x1 - x0) < tol)             // stopping criterion for accepting numerical solution
                {
                    Console.WriteLine("The solution has been found!");
                    Console.WriteLine("It is {0}", x1);
                    break;
                }
                x0 = x1;

                if (i == maxIter - 1)
                /* basic stopping criterion! computational scientists worth their salt will implement 
                   more sophisticated logic to detect divergence of the solution!
                */
                {
                    Console.WriteLine(":( No solution found.");
                }
            }

        }

        public static double Equation(double x)
            // the equation you want to solve goes here
        {
            return Math.Cos(x);
            // return 2*Math.Cos(x);
        }
    }

   
}
