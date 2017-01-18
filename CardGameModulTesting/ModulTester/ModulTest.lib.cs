using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardHandeler;
using System.IO;
namespace ModulTester
{
    public class ModulTestLibary
    {
        public void StartTest()
        {
            var cardHandeler = new CardHandeler1();

            var filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var fileName = "\\results.txt";
            var totalPath = filePath + fileName;

            List<string> allCards = new List<string> { "1h", "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "10h", "jh", "qh", "kh","ah",
                                               "1s", "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "10s", "js", "qs", "ks", "as",
                                               "1c", "2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "10c", "jc", "qc", "kc", "ac",
                                               "1d", "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "10d", "jd", "qd", "kd", "ad", "qq",
                                               "1H", "AH","korv", "12345", "oh", "-%¤¤/&%(&%(10230230230"};

            List<string> results = new List<string>();

            int i = 1;

            foreach (var card in allCards)
            {
                if(cardHandeler.inputChecker(card) == "That card combination does not exists, please try again")
                {
                    cardHandeler.inputChecker(card);
                    results.Add(String.Format("Case: {0} - {1}- {2}", i, card, "failed"));
                    i++;
                }
                else
                {
                    cardHandeler.inputChecker(card);
                    results.Add(String.Format("Case: {0} - {1}- {2}", i, card, "passed"));
                    i++;
                }
            }

            File.WriteAllLines(totalPath, results);

        }
    }
}
