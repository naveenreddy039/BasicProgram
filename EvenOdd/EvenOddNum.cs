using System;
using System.Collections.Generic;
using System.Text;

namespace EvenOdd
{
    public class EvenOddNum
    {
        public void printEvenNum()
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
