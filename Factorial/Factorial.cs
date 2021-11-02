using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial
{
    public class Factorial
    {
        public void printFact()
        {
            Console.WriteLine("Enter then number:");
            int num = int.Parse(Console.ReadLine());
            int i;
            for(i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
