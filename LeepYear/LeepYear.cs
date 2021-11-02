using System;
using System.Collections.Generic;
using System.Text;

namespace LeepYear
{
    public class LeepYear
    {
        public void printYear()
        {
            Console.WriteLine("Enther the year");
            int a = int.Parse(Console.ReadLine());
            bool year = false;
            if (a % 4 == 0)
            {
                if (a % 100 == 0)
                {
                    if (a % 400 == 0)
                    {
                        year = true;
                    }
                    else
                    {
                        year = false;
                    }
                }
                else
                {
                    year = true;
                }
            }
            else
            {
                year = false;
            }
            if (year)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
