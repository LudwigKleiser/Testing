using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardHandeler
{
    public class CardHandeler1
    {
        public string inputChecker(string input)
        {
            input = input.ToLower();
            if (input.Contains("h"))
            {
                if (input.Contains("1") && !input.Contains("10")) input = "Ace" + " of hearts";
                else if (input.Contains("2")) input = "2" + " of hearts";
                else if (input.Contains("3")) input = "3" + " of hearts";
                else if (input.Contains("4")) input = "4" + " of hearts";
                else if (input.Contains("5")) input = "5" + " of hearts";
                else if (input.Contains("6")) input = "6" + " of hearts";
                else if (input.Contains("7")) input = "7" + " of hearts";
                else if (input.Contains("8")) input = "8" + " of hearts";
                else if (input.Contains("9")) input = "9" + " of hearts";
                else if (input.Contains("10")) input = "10" + " of hearts";
                else if (input.Contains("j")) input = "Jack" + " of hearts";
                else if (input.Contains("q")) input = "Queen" + " of hearts";
                else if (input.Contains("k")) input = "King" + " of hearts";
                else if (input.Contains("a")) input = "Ace" + " of hearts";
                else input = "That card combination does not exists, please try again";
                return input;
            }

            else if (input.Contains("s"))
            {
                if (input.Contains("1") && !input.Contains("10")) input = "Ace" + " of spades";
                else if (input.Contains("2")) input = "2" + " of spades";
                else if (input.Contains("3")) input = "3" + " of spades";
                else if (input.Contains("4")) input = "4" + " of spades";
                else if (input.Contains("5")) input = "5" + " of spades";
                else if (input.Contains("6")) input = "6" + " of spades";
                else if (input.Contains("7")) input = "7" + " of spades";
                else if (input.Contains("8")) input = "8" + " of spades";
                else if (input.Contains("9")) input = "9" + " of spades";
                else if (input.Contains("10")) input = "10" + " of spades";
                else if (input.Contains("j")) input = "Jack" + " of spades";
                else if (input.Contains("q")) input = "Queen" + " of spades";
                else if (input.Contains("k")) input = "King" + " of spades";
                else if (input.Contains("a")) input = "Ace" + " of spades";
                else input = "That card combination does not exists, please try again";
                return input;
            }

            else if (input.Contains("d"))
            {
                if (input.Contains("1") && !input.Contains("10")) input = "Ace" + " of diamonds";
                else if (input.Contains("2")) input = "2" + " of diamonds";
                else if (input.Contains("3")) input = "3" + " of diamonds";
                else if (input.Contains("4")) input = "4" + " of diamonds";
                else if (input.Contains("5")) input = "5" + " of diamonds";
                else if (input.Contains("6")) input = "6" + " of diamonds";
                else if (input.Contains("7")) input = "7" + " of diamonds";
                else if (input.Contains("8")) input = "8" + " of diamonds";
                else if (input.Contains("9")) input = "9" + " of diamonds";
                else if (input.Contains("10")) input = "10" + " of diamonds";
                else if (input.Contains("j")) input = "Jack" + " of diamonds";
                else if (input.Contains("q")) input = "Queen" + " of diamonds";
                else if (input.Contains("k")) input = "King" + " of diamonds";
                else if (input.Contains("a")) input = "Ace" + " of diamonds";
                else input = "That card combination does not exists, please try again";
                return input;
            }

            else if (input.Contains("c"))
            {
                if (input.Contains("1") && !input.Contains("10")) input = "Ace" + " of cloves";
                else if (input.Contains("2")) input = "2" + " of cloves";
                else if (input.Contains("3")) input = "3" + " of cloves";
                else if (input.Contains("4")) input = "4" + " of cloves";
                else if (input.Contains("5")) input = "5" + " of cloves";
                else if (input.Contains("6")) input = "6" + " of cloves";
                else if (input.Contains("7")) input = "7" + " of cloves";
                else if (input.Contains("8")) input = "8" + " of cloves";
                else if (input.Contains("9")) input = "9" + " of cloves";
                else if (input.Contains("10")) input = "10" + " of cloves";
                else if (input.Contains("j")) input = "Jack" + " of cloves";
                else if (input.Contains("q")) input = "Queen" + " of cloves";
                else if (input.Contains("k")) input = "King" + " of cloves";
                else if (input.Contains("a")) input = "Ace" + " of cloves";
                else input = "That card combination does not exists, please try again";
                return input;
            }

            else
            {
                input = "That card combination does not exists, please try again";
                return input;
            }
        }
    }
}
