using NUnit.Framework;
using MyCalculatorApp;

namespace CalculatorUnitTest
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void Addition_of_two_positive_integers()
        {
            Calculator.num1 = 4;//arrange
            Calculator.num2 = 10;//arrange
            double res = Calculator.Addition(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(res, 14); //assert
        }

        [Test]
        public void Addition_of_two_negative_integers()
        {
            Calculator.num1 = -12;//arrange
            Calculator.num2 = -20;//arrange
            double res = Calculator.Addition(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(res, -32); //assert
        }

        [Test]
        public void Addition_of_two_decimal_numbers()
        {
            Calculator.num1 = 9.58;//arrange
            Calculator.num2 = 12.5;//arrange
            double res = Calculator.Addition(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(res, 22.08); //assert
        }

        [Test]
        public void Subtraction_of_two_positive_integers()
        {
            Calculator.num1 = 40;//arrange
            Calculator.num2 = 15;//arrange
            double res = Calculator.Subtraction(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(res, 25); //assert
        }

        [Test]
        public void Subtraction_of_two_negative_integers()
        {
            Calculator.num1 = -30;//arrange
            Calculator.num2 = -16;//arrange
            double res = Calculator.Subtraction(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(res, -14); //assert
        }

        [Test]
        public void Subtraction_of_two_decimal_numbers()
        {
            Calculator.num1 = 15.50;//arrange
            Calculator.num2 = 7.25;//arrange
            double res = Calculator.Subtraction(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(res, 8.25); //assert
        }

        [Test]
        public void Multiplication_of_two_positive_integers()
        {
            Calculator.num1 = 11;//arrange
            Calculator.num2 = 15;//arrange
            double res = Calculator.Multiply(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(res, 165); //assert
        }

        [Test]
        public void Multiplication_of_two_negative_integers()
        {
            Calculator.num1 = -9;//arrange
            Calculator.num2 = -5;//arrange
            double res = Calculator.Multiply(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(res, 45); //assert
        }

        [Test]
        public void Multiplication_of_two_decimal_numbers()
        {
            Calculator.num1 = 13.5;//arrange
            Calculator.num2 = 9.7;//arrange
            double res = Calculator.Multiply(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(res, 130.95); //assert
        }

        [Test]
        public void Division_of_two_positive_integers()
        {
            Calculator.num1 = 150;//arrange
            Calculator.num2 = 15;//arrange
            double res = Calculator.Division(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(res, 10); //assert
        }

        [Test]
        public void Division_of_two_negative_integers()
        {
            Calculator.num1 = -99;//arrange
            Calculator.num2 = -9;//arrange
            double res = Calculator.Division(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(res, 11); //assert
        }

        [Test]
        public void Division_of_two_decimal_numbers()
        {
            Calculator.num1 = 9.2;//arrange
            Calculator.num2 = 4.8;//arrange
            double res = Calculator.Division(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(res, 1.92); //assert
        }
    }
}
