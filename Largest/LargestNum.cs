using System;
using System.Collections.Generic;
using System.Text;

namespace Largest
{
    public class LargestNum
    {
        public void printLarge()
        {
            Console.WriteLine("Enter the number1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number2:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number3:");
            int c = int.Parse(Console.ReadLine());
            if(a>=b && a>=c)
                Console.WriteLine(a + "is largest number");
                
                else if(b>=a && b>=c)
                    Console.WriteLine(b + "is largest number");
            else
                Console.WriteLine(c + "is largest number");
        }
    }
}
