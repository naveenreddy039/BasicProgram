using System;

namespace FlipCoin
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //label: Console.WriteLine("1.Print the percentage coin Flip");
           // Console.WriteLine("Type the option");
            int i = int.Parse(Console.ReadLine());


            //switch(i)
            //{
                //case 1:
                    //Console.WriteLine("1.Print the percentage coin Flip");
                    PercentageOFHeadAndTail percentageOFHeadAndTail = new PercentageOFHeadAndTail();
                    percentageOFHeadAndTail.printHeadAndTail();
                    //break;
                //default:
                   // Console.WriteLine("Invalid option");
                    //break;
            //}
            //Console.WriteLine("Do you want to continue...yes/No");
            //if(Console.ReadKey().KeyChar.ToString()=="yes")
            //{
                //goto label;
            //}
            Console.ReadKey();
        }
    }
}
