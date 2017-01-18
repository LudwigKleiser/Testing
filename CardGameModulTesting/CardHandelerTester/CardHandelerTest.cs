using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardHandeler;
namespace CardHandelerTester
{
    [TestClass]
    public class CardHandelerTest
    {
        [TestMethod]
        public void Test1d()
        {
            var cardHandeler = new CardHandeler1();

            string input = "1d";

            string expectedOutput = "Ace of diamonds";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test2d()
        {
            var cardHandeler = new CardHandeler1();

            string input = "2d";

            string expectedOutput = "2 of diamonds";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test3d()
        {
            var cardHandeler = new CardHandeler1();

            string input = "3d";

            string expectedOutput = "3 of diamonds";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test4d()
        {
            var cardHandeler = new CardHandeler1();

            string input = "4d";

            string expectedOutput = "4 of diamonds";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test5d()
        {
            var cardHandeler = new CardHandeler1();

            string input = "5d";

            string expectedOutput = "5 of diamonds";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test6d()
        {
            var cardHandeler = new CardHandeler1();

            string input = "6d";

            string expectedOutput = "6 of diamonds";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test7d()
        {
            var cardHandeler = new CardHandeler1();

            string input = "7d";

            string expectedOutput = "7 of diamonds";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test8d()
        {
            var cardHandeler = new CardHandeler1();

            string input = "8d";

            string expectedOutput = "8 of diamonds";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test9d()
        {
            var cardHandeler = new CardHandeler1();

            string input = "9d";

            string expectedOutput = "9 of diamonds";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test10d()
        {
            var cardHandeler = new CardHandeler1();

            string input = "10d";

            string expectedOutput = "10 of diamonds";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Testjd()
        {
            var cardHandeler = new CardHandeler1();

            string input = "jd";

            string expectedOutput = "Jack of diamonds";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Testqd()
        {
            var cardHandeler = new CardHandeler1();

            string input = "qd";

            string expectedOutput = "Queen of diamonds";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Testkd()
        {
            var cardHandeler = new CardHandeler1();

            string input = "kd";

            string expectedOutput = "King of diamonds";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test1s()
        {
            var cardHandeler = new CardHandeler1();

            string input = "1s";

            string expectedOutput = "Ace of spades";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test2s()
        {
            var cardHandeler = new CardHandeler1();

            string input = "2s";

            string expectedOutput = "2 of spades";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test3s()
        {
            var cardHandeler = new CardHandeler1();

            string input = "3s";

            string expectedOutput = "3 of spades";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test4s()
        {
            var cardHandeler = new CardHandeler1();

            string input = "4s";

            string expectedOutput = "4 of spades";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test5s()
        {
            var cardHandeler = new CardHandeler1();

            string input = "5s";

            string expectedOutput = "5 of spades";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test6s()
        {
            var cardHandeler = new CardHandeler1();

            string input = "6s";

            string expectedOutput = "6 of spades";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test7s()
        {
            var cardHandeler = new CardHandeler1();

            string input = "7s";

            string expectedOutput = "7 of spades";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test8s()
        {
            var cardHandeler = new CardHandeler1();

            string input = "8s";

            string expectedOutput = "8 of spades";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test9s()
        {
            var cardHandeler = new CardHandeler1();

            string input = "9s";

            string expectedOutput = "9 of spades";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test10s()
        {
            var cardHandeler = new CardHandeler1();

            string input = "10s";

            string expectedOutput = "10 of spades";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Testjs()
        {
            var cardHandeler = new CardHandeler1();

            string input = "js";

            string expectedOutput = "Jack of spades";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Testqs()
        {
            var cardHandeler = new CardHandeler1();

            string input = "qs";

            string expectedOutput = "Queen of spades";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Testks()
        {
            var cardHandeler = new CardHandeler1();

            string input = "ks";

            string expectedOutput = "King of spades";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test1c()
        {
            var cardHandeler = new CardHandeler1();

            string input = "1c";

            string expectedOutput = "Ace of cloves";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test2c()
        {
            var cardHandeler = new CardHandeler1();

            string input = "2c";

            string expectedOutput = "2 of cloves";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test3c()
        {
            var cardHandeler = new CardHandeler1();

            string input = "3c";

            string expectedOutput = "3 of cloves";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test4c()
        {
            var cardHandeler = new CardHandeler1();

            string input = "4c";

            string expectedOutput = "4 of cloves";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test5c()
        {
            var cardHandeler = new CardHandeler1();

            string input = "5c";

            string expectedOutput = "5 of cloves";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test6c()
        {
            var cardHandeler = new CardHandeler1();

            string input = "6c";

            string expectedOutput = "6 of cloves";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test7c()
        {
            var cardHandeler = new CardHandeler1();

            string input = "7c";

            string expectedOutput = "7 of cloves";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test8c()
        {
            var cardHandeler = new CardHandeler1();

            string input = "8c";

            string expectedOutput = "8 of cloves";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test9c()
        {
            var cardHandeler = new CardHandeler1();

            string input = "9c";

            string expectedOutput = "9 of cloves";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test10c()
        {
            var cardHandeler = new CardHandeler1();

            string input = "10c";

            string expectedOutput = "10 of cloves";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Testjc()
        {
            var cardHandeler = new CardHandeler1();

            string input = "jc";

            string expectedOutput = "Jack of cloves";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Testqc()
        {
            var cardHandeler = new CardHandeler1();

            string input = "qc";

            string expectedOutput = "Queen of cloves";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Testkc()
        {
            var cardHandeler = new CardHandeler1();

            string input = "kc";

            string expectedOutput = "King of cloves";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test1h()
        {
            var cardHandeler = new CardHandeler1();

            string input = "1h";

            string expectedOutput = "Ace of hearts";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test2h()
        {
            var cardHandeler = new CardHandeler1();

            string input = "2h";

            string expectedOutput = "2 of hearts";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test3h()
        {
            var cardHandeler = new CardHandeler1();

            string input = "3h";

            string expectedOutput = "3 of hearts";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test4h()
        {
            var cardHandeler = new CardHandeler1();

            string input = "4h";

            string expectedOutput = "4 of hearts";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test5h()
        {
            var cardHandeler = new CardHandeler1();

            string input = "5h";

            string expectedOutput = "5 of hearts";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test6h()
        {
            var cardHandeler = new CardHandeler1();

            string input = "6h";

            string expectedOutput = "6 of hearts";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test7h()
        {
            var cardHandeler = new CardHandeler1();

            string input = "7h";

            string expectedOutput = "7 of hearts";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test8h()
        {
            var cardHandeler = new CardHandeler1();

            string input = "8h";

            string expectedOutput = "8 of hearts";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test9h()
        {
            var cardHandeler = new CardHandeler1();

            string input = "9h";

            string expectedOutput = "9 of hearts";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test10h()
        {
            var cardHandeler = new CardHandeler1();

            string input = "10h";

            string expectedOutput = "10 of hearts";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Testjh()
        {
            var cardHandeler = new CardHandeler1();

            string input = "jh";

            string expectedOutput = "Jack of hearts";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Testqh()
        {
            var cardHandeler = new CardHandeler1();

            string input = "qh";

            string expectedOutput = "Queen of hearts";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Testkh()
        {
            var cardHandeler = new CardHandeler1();

            string input = "kh";

            string expectedOutput = "King of hearts";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]

        public void TestccErrorMessage()
        {
            var cardHandeler = new CardHandeler1();

            string input = "cc";

            string expectedOutput = "That card combination does not exists, please try again";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]

        public void TestssErrorMessage()
        {
            var cardHandeler = new CardHandeler1();

            string input = "ss";

            string expectedOutput = "That card combination does not exists, please try again";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]

        public void TesthhErrorMessage()
        {
            var cardHandeler = new CardHandeler1();

            string input = "hh";

            string expectedOutput = "That card combination does not exists, please try again";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]

        public void TestddErrorMessage()
        {
            var cardHandeler = new CardHandeler1();

            string input = "dd";

            string expectedOutput = "That card combination does not exists, please try again";

            var actualOutput = cardHandeler.inputChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
