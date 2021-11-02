using System;
using System.Collections.Generic;
using System.Text;

namespace FlipCoin
{
    public class PercentageOFHeadAndTail
    {
        public void printHeadAndTail()
        {
            int head = 0;
            int tail = 0;
            int CoinResult = 0;
            Random random = new Random();

            Console.WriteLine("Enter the input of Coin Flip");

            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                CoinResult = random.Next(0, 2);
                if (CoinResult == 0)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
            }
            double resultHead = (head * 100) / input;
            double resultTail = (tail * 100) / input;
            Console.WriteLine("Head is Flip" + resultHead);
            Console.WriteLine("Tail is Flip" + resultTail);
        }
        
    }
}
