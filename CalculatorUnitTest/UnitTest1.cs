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
            Calculator.Num1 = 4;//arrange
            Calculator.Num2 = 10;//arrange
            double res = Calculator.Addition(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(14,res); //assert
        }

        [Test]
        public void Addition_of_two_negative_integers()
        {
            Calculator.Num1 = -12;//arrange
            Calculator.Num2 = -20;//arrange
            double res = Calculator.Addition(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(-32, res); //assert
        }

        [Test]
        public void Addition_of_two_decimal_numbers()
        {
            Calculator.Num1 = 9.58;//arrange
            Calculator.Num2 = 12.5;//arrange
            double res = Calculator.Addition(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(22.08, res); //assert
        }

        [Test]
        public void Subtraction_of_two_positive_integers()
        {
            Calculator.Num1 = 40;//arrange
            Calculator.Num2 = 15;//arrange
            double res = Calculator.Subtraction(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(25, res); //assert
        }

        [Test]
        public void Subtraction_of_two_negative_integers()
        {
            Calculator.Num1 = -30;//arrange
            Calculator.Num2 = -16;//arrange
            double res = Calculator.Subtraction(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(-14, res); //assert
        }

        [Test]
        public void Subtraction_of_two_decimal_numbers()
        {
            Calculator.Num1 = 15.50;//arrange
            Calculator.Num2 = 7.25;//arrange
            double res = Calculator.Subtraction(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(8.25, res); //assert
        }

        [Test]
        public void Multiplication_of_two_positive_integers()
        {
            Calculator.Num1 = 11;//arrange
            Calculator.Num2 = 15;//arrange
            double res = Calculator.Multiply(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(165, res); //assert
        }

        [Test]
        public void Multiplication_of_two_negative_integers()
        {
            Calculator.Num1 = -9;//arrange
            Calculator.Num2 = -5;//arrange
            double res = Calculator.Multiply(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(45, res); //assert
        }

        [Test]
        public void Multiplication_of_two_decimal_numbers()
        {
            Calculator.Num1 = 13.5;//arrange
            Calculator.Num2 = 9.7;//arrange
            double res = Calculator.Multiply(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(130.95, res); //assert
        }

        [Test]
        public void Division_of_two_positive_integers()
        {
            Calculator.Num1 = 150;//arrange
            Calculator.Num2 = 15;//arrange
            double res = Calculator.Division(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(10, res); //assert
        }

        [Test]
        public void Division_of_two_negative_integers()
        {
            Calculator.Num1 = -99;//arrange
            Calculator.Num2 = -9;//arrange
            double res = Calculator.Division(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(11, res); //assert
        }

        [Test]
        public void Division_of_two_decimal_numbers()
        {
            Calculator.Num1 = 9.2;//arrange
            Calculator.Num2 = 4.8;//arrange
            double res = Calculator.Division(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(1.92, res); //assert
        }
        [Test]
        public void Division_by_zero()
        {
            Calculator.Num1 = 9.2;//arrange
            Calculator.Num2 = 0;//arrange
            double res = Calculator.Division(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(0, res); //assert
        }
    }
}
