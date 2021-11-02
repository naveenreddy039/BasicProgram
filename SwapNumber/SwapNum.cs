using System;
using System.Collections.Generic;
using System.Text;

namespace SwapNumber
{
    public class SwapNum
    {
        public void printNum()
        {
            Console.WriteLine("Enter the first number:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int n2 = int.Parse(Console.ReadLine());
            int temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine(n1 + " " + n2);
        }
    }
}
