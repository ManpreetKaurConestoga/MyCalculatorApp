using NUnit.Framework;
using MyCalculatorApp;

namespace CalculatorUnitTest
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        [TestCase(4,10,14)]
        [TestCase(0,0,0)]
        [TestCase(20,0,20)]
        [TestCase(10001,10001,20002)]
        [TestCase(-100,-200,-300)]
        [TestCase(0,-17,-17)]
        [TestCase(-17,17,0)]
        public void Addition_of_two_integers(int firstNumber,int secondNumber,int expectedResult)
        {
            Calculator.Num1 = firstNumber;//arrange
            Calculator.Num2 = secondNumber;//arrange
            double res = Calculator.Addition(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(expectedResult,res); //assert
        }

        [Test]
        [TestCase(4, 10.50, 14.50)]
        [TestCase(0, 0.0, 0)]
        [TestCase(0, 15.562987, 15.56)]
        [TestCase(10001, 10001.999999, 20003)]
        [TestCase(-100, -200.99, -300.99)]
        [TestCase(0, -17.781, -17.78)]
        [TestCase(-17, 17.001, 0)]
        public void Addition_of_one_integer_and_one_decimal(int firstNumber, double secondNumber, double expectedResult)
        {
            Calculator.Num1 = firstNumber;//arrange
            Calculator.Num2 = secondNumber;//arrange
            double res = Calculator.Addition(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(expectedResult, res); //assert
        }

        [Test]
        [TestCase(4.7, 10.5, 15.2)]
        [TestCase(0.0, 0.0, 0.0)]
        [TestCase(0.9999, 15.562987, 16.56)]
        [TestCase(10001.1111111, 10001.999999, 20003.11)]
        [TestCase(-100.01, -200.99, -301)]
        [TestCase(0.0, -17.781, -17.78)]
        [TestCase(-17.001, 17.001, 0)]
        public void Addition_of_two_decimal_numbers(double firstNumber, double secondNumber, double expectedResult)
        {
            Calculator.Num1 = firstNumber;//arrange
            Calculator.Num2 = secondNumber;//arrange
            double res = Calculator.Addition(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(expectedResult, res); //assert
        }

        [Test]
        [TestCase(4, 10, -6)]
        [TestCase(0, 0, 0)]
        [TestCase(20, 0, 20)]
        [TestCase(12000, 10000, 2000)]
        [TestCase(-100, -200, 100)]
        [TestCase(0, -17, 17)]
        [TestCase(-17, 17, -34)]
        public void Subtraction_of_two_integers(int firstNumber, int secondNumber, int expectedResult)
        {
            Calculator.Num1 = firstNumber;//arrange
            Calculator.Num2 = secondNumber;//arrange
            double res = Calculator.Subtraction(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(expectedResult, res); //assert
        }

        [Test]
        [TestCase(4, 10.50, -6.5)]
        [TestCase(0, 0.0, 0.0)]
        [TestCase(0, 15.562987, -15.56)]
        [TestCase(10001, 10001.999999, -1)]
        [TestCase(-100, -200.99, 100.99)]
        [TestCase(0, -17.781, 17.78)]
        [TestCase(-17, 17.001, -34.00)]
        public void Subtraction_of_one_integer_and_one_decimal(int firstNumber, double secondNumber, double expectedResult)
        {
            Calculator.Num1 = firstNumber;//arrange
            Calculator.Num2 = secondNumber;//arrange
            double res = Calculator.Subtraction(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(expectedResult, res); //assert
        }

        [Test]
        [TestCase(4.7, 10.5, -5.8)]
        [TestCase(0.0, 0.0, 0.0)]
        [TestCase(0.9999, 15.562987, -14.56)]
        [TestCase(10001.1111111, 10001.999999, -0.89)]
        [TestCase(-100.01, -200.99, 100.98)]
        [TestCase(0.0, -17.781, 17.78)]
        [TestCase(-17.001, 17.001, -34.00)]
        public void Subtraction_of_two_decimal_numbers(double firstNumber, double secondNumber, double expectedResult)
        {
            Calculator.Num1 = firstNumber;//arrange
            Calculator.Num2 = secondNumber;//arrange
            double res = Calculator.Subtraction(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(expectedResult, res); //assert
        }

        [Test]
        [TestCase(4, 10, 40)]
        [TestCase(0, 0, 0)]
        [TestCase(20, 0, 0)]
        [TestCase(12000, 10000, 120000000)]
        [TestCase(-100, -200, 20000)]
        [TestCase(1, -17, -17)]
        [TestCase(-17, 17, -289)]
        public void Multiplication_of_two_integers(int firstNumber, int secondNumber, int expectedResult)
        {
            Calculator.Num1 = firstNumber;//arrange
            Calculator.Num2 = secondNumber;//arrange
            double res = Calculator.Multiply(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(expectedResult, res); //assert
        }

        [Test]
        [TestCase(4, 10.50, 42)]
        [TestCase(0, 0.0, 0.0)]
        [TestCase(0, 15.562987, 0)]
        [TestCase(10001, 10001.999999, 100030001.99)]
        [TestCase(-100, -200.99, 20099)]
        [TestCase(1, -17.781, -17.78)]
        [TestCase(-17, 17.001, -289.02)]
        public void Multiplication_of_one_integer_one_decimal(int firstNumber, double secondNumber, double expectedResult)
        {
            Calculator.Num1 = firstNumber;//arrange
            Calculator.Num2 = secondNumber;//arrange
            double res = Calculator.Multiply(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(expectedResult, res); //assert
        }

        [Test]
        [TestCase(4.7, 10.5, 49.35)]
        [TestCase(0.0, 0.0, 0.0)]
        [TestCase(0.9999, 15.562987, 15.56)]
        [TestCase(10001.1111111, 10001.999999,100031113.32)]
        [TestCase(-100.01, -200.99, 20101.01)]
        [TestCase(1.1, -17.781, -19.56)]
        [TestCase(-17.001, 17.001, -289.03)]
        public void Multiplication_of_two_decimal_numbers(double firstNumber, double secondNumber, double expectedResult)
        {
            Calculator.Num1 = firstNumber;//arrange
            Calculator.Num2 = secondNumber;//arrange
            double res = Calculator.Multiply(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(expectedResult, res); //assert
        }

        [Test]
        [TestCase(20, 3, 6.67)]
        [TestCase(12000, 10000, 1.2)]
        [TestCase(-100, -200, 0.5)]
        [TestCase(17, -1, -17)]
        [TestCase(-17, 17, -1)]
        public void Division_of_two_integers(int firstNumber, int secondNumber, double expectedResult)
        {
            Calculator.Num1 = firstNumber;//arrange
            Calculator.Num2 = secondNumber;//arrange
            double res = Calculator.Division(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(expectedResult, res); //assert
        }

        [Test]
        [TestCase(20, 3.5, 5.71)]
        [TestCase(12000, 10000.99, 1.2)]
        [TestCase(-100, -200.79, 0.5)]
        [TestCase(17, -1.5, -11.33)]
        [TestCase(-17, 17.1, -0.99)]
        public void Division_of_one_integer_and_one_decimal(int firstNumber, double secondNumber, double expectedResult)
        {
            Calculator.Num1 = firstNumber;//arrange
            Calculator.Num2 = secondNumber;//arrange
            double res = Calculator.Division(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(expectedResult, res); //assert
        }

        [Test]
        [TestCase(20.5, 3.5, 5.86)]
        [TestCase(12000.11, 10000.99, 1.2)]
        [TestCase(-100.78, -200.79, 0.50)]
        [TestCase(17.9, -1.5, -11.93)]
        [TestCase(-17.1, 17.1, -1)]
        public void Division_of_two_decimal_numbers(double firstNumber, double secondNumber, double expectedResult)
        {
            Calculator.Num1 = firstNumber;//arrange
            Calculator.Num2 = secondNumber;//arrange
            double res = Calculator.Division(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(expectedResult, res); //assert
        }

        [Test]
        [TestCase(0,0,0)]
        [TestCase(0,1,0)]
        [TestCase(10,0,0)]
        [TestCase(-10,0,0)]
        [TestCase(0,-10,0)]
        public void Division_by_zero(double firstNumber, double secondNumber, double expectedResult)
        {
            Calculator.Num1 = firstNumber;//arrange
            Calculator.Num2 = secondNumber;//arrange
            double res = Calculator.Division(Calculator.Num1, Calculator.Num2); //act
            Assert.AreEqual(expectedResult, res); //assert
        }
    }
}
