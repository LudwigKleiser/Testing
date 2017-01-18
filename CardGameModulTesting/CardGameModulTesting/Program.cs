using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardHandeler;
using ModulTester;

namespace CardGameModulTesting
{
    //Hearts, spades, diamonds , cloves
    class Program
    {
        static void Main(string[] args)
        {
            var cardHandeler = new CardHandeler1();
            var modulTester = new ModulTestLibary();

            modulTester.StartTest();
            while (true)
            {


                string input = Console.ReadLine().ToLower();
                if (input.Length > 2 && !input.Contains("10"))
                {
                    Console.WriteLine("Too long");
                }
                else
                {
                    input = cardHandeler.inputChecker(input);

                    Console.WriteLine(input);
                }


            }
        }
    }
}
