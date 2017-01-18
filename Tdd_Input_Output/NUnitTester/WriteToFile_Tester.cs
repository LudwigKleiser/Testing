using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tdd_Input_Output;
namespace NUnitTester
{
    //TODO 1. Rename NUnitTester class1 to WriteToFile_Tester.
    //TODO 2. Create class for user inputs.
    //TODO 2.1 Create GUI class.
    //TODO 2.2 Create FileHandeler class.
    //TODO 3. Create MyMath class.
    //TODO 4. Use TDD to create function for first and last name.
    //TODO 5. Use TDD to create fuction for addition.
    //TODO 6. Use TDD to create function for subtraction .
    //TODO 7. Use TDD to create function for multiplication.
    //TODO 8. Use TDD to create function for division.

    [TestFixture]
    public class WriteToFile_Tester
    {
        [Test]
        public void Addition_tester()
        {
           
            double inputOne = 3;
            double inputTwo = 7;
            double expectedResult = inputOne + inputTwo;

            MyMath math = new MyMath();

            double actualResult = math.Addition(inputOne, inputTwo);

            Assert.AreEqual(expectedResult, actualResult);


        }


        [Test]

        public void Subtraction_tester()
        {
            double inputOne = 50;
            double inputTwo = 25;
            double expectedResult = 25;

            MyMath math = new MyMath();

            double actualResult = math.Subtraction(inputOne, inputTwo);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        
        public void Multiplication_tester()
        {
            double inputOne = 50;
            double inputTwo = 10;
            double expectedResult = inputOne * inputTwo;

            MyMath math = new MyMath();

            double actualResult = math.Multiplication(inputOne, inputTwo);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]

        public void Division_tester()
        {
            double inputOne = 10;
            double inputTwo = 5;
            double expectedResult = inputOne / inputTwo;

            MyMath math = new MyMath();

            double actualResult = math.Division(inputOne, inputTwo);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]

        public void DivisionByZero_tester()
        {

        }
    }
}
