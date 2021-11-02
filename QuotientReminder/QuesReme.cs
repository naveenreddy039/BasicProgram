using System;
using System.Collections.Generic;
using System.Text;

namespace QuotientReminder
{
    public class QuesReme
    {
        public void printQurem()
        {
            Console.WriteLine("Enter the dividend:");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the divisor:");
            int divisor = int.Parse(Console.ReadLine());

            int reminder = dividend % divisor;
            int quotient = dividend / divisor;
            Console.WriteLine("reminder:"+reminder);
            Console.WriteLine("quotient:"+quotient);
        }
    }
}
