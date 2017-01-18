using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyHandeler_TDD;
using NUnit.Framework;
namespace MoneyHandelerTester
{
    [TestFixture]
    public class MoneyHandeler_Tester
    {
        [Test]
        public void DebitFromBalance_Test()
        {

            int expectedBalance = 250;
            int balanceToRemove = 250;
            MoneyHandeler moneyHandeler = new MoneyHandeler();
            int actualBalance = moneyHandeler.Debit(balanceToRemove);

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [Test]

        public void CreditToBalance_Test()
        {

            int expectedBalance = 5000;
            int balanceToAdd = 4500;
            MoneyHandeler moneyHandeler = new MoneyHandeler();
            int actualBalance = moneyHandeler.Credit(balanceToAdd);

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [Test]

        public void PrintBalance_Test()
        {

            int expectedOutput = 500;

            MoneyHandeler moneyHandeler = new MoneyHandeler();
            int actualBalance = moneyHandeler.PrintBalance(moneyHandeler.Balance);

            Assert.AreEqual(expectedOutput, actualBalance);
        }

        [Test]

        public void Removing_600_From_500_With_No_Change_Test()
        {
            int balanceToRemove = 600;
            int expectedBalance = 500;

            MoneyHandeler moneyHandeler = new MoneyHandeler();

            int actualBalance = moneyHandeler.Debit(balanceToRemove);

            Assert.AreEqual(expectedBalance, actualBalance);

        }

        [Test]

        public void BalanceOver_50000_Test()
        {
            int expectedBalance = 500;
            int balanceToAdd = 49501;

            MoneyHandeler moneyHandeler = new MoneyHandeler();

            int actualBalance = moneyHandeler.Credit(balanceToAdd);

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [Test]

        public void CreditWithANegativeNumber()
        {
            int expectedBalance = 500;
            int balanceToAdd = -500;

            MoneyHandeler moneyHandeler = new MoneyHandeler();

            int actualBalance = moneyHandeler.Credit(balanceToAdd);


            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [Test]

        public void MaxCredit30000()
        {
            int expectedBalance = 500;
            int balanceToAdd = 30000;

            MoneyHandeler moneyHandeler = new MoneyHandeler();

            int actualBalance = moneyHandeler.Credit(balanceToAdd);

            Assert.AreEqual(expectedBalance, actualBalance);
        }
        [Test]

        public void MinimumCreditTest([Values(25, 45, 38, 99, 48)]int input)
        {
            MoneyHandeler moneyHandeler = new MoneyHandeler();
            int expectedBalance = moneyHandeler.Balance;

            Assert.AreEqual(expectedBalance, moneyHandeler.Credit(input));

        }





    }
}
