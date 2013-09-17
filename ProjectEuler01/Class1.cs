using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler01
{
    class Program
    { 
        static void Main()
        {
            int sum = 0;

            Console.WriteLine("Hello World, This program will find the sum of all multiples of 3 or 5");
            Console.WriteLine("from 0 up to the number you input, but not including it.");
            Console.WriteLine();
            Console.WriteLine("Enter the Max number, then press enter.");
            
            //Note there is no error trapping here. Its just a simple program as a math problem
            //So I figured thats just outside of the scope.
            int maxNumber = Convert.ToInt32(Console.ReadLine());

            for (int ii = 0; ii < maxNumber; ii++)
            { 
                int threeInt = ii / 3;
                float threeFloat = ii / 3;

                int fiveInt = ii / 5;
                float fiveFloat = ii / 5;

                if (ii % 3 == 0)
                {
                    sum = ii + sum;
                    Console.WriteLine(sum);
                }

                //The second check is needed because numbers like 15 would be counted twice
                //I'm pretty sure this is not the intended result.
                if (ii % 5 == 0 && ii % 3 != 0)
                {
                    sum = sum + ii;
                    Console.WriteLine(sum);
                }
            
            }

            Console.WriteLine();
            Console.WriteLine("The sum of the multiples of 3 and 5 is : " + sum);
            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();


        }
    }
}
