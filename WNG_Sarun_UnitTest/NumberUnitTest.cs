using NUnit.Framework;
using WNG_Sarun.Controllers;

namespace WNG_Sarun_UnitTest
{
    [TestFixture]
    public class NumberUnitTest
    {
        NumberController controller = null;

        public NumberUnitTest()
        {
            controller = new NumberController();
        }

        [Test]
        public void GetAllNumbers_WithInput10CheckLength()
        {
            controller.CreateFactory();
            long[] arrAllNumbers = controller.GetAllNumbers(10);
            Assert.AreEqual(arrAllNumbers.Length, 11);
        }

        [Test]
        public void GetAllNumbers_WithInput10CheckFirstItemInArray()
        {
            controller.CreateFactory();
            long[] arrAllNumbers = controller.GetAllNumbers(10);
            Assert.AreEqual(arrAllNumbers[0], 0);
        }

        [Test]
        public void GetAllNumbers_WithInput10CheckLastItemInArray()
        {
            controller.CreateFactory();
            long[] arrAllNumbers = controller.GetAllNumbers(10);
            Assert.AreEqual(arrAllNumbers[10], 10);
        }

        [Test]
        public void GetAllEvenNumbers_WithInput10CheckLength()
        {
            controller.CreateFactory();
            long[] arrAllEvenNumbers = controller.GetAllEvenNumbers(10);
            Assert.AreEqual(arrAllEvenNumbers.Length, 5);
        }

        [Test]
        public void GetAllEvenNumbers_WithInput10CheckFirstItemInArray()
        {
            controller.CreateFactory();
            long[] arrAllEvenNumbers = controller.GetAllEvenNumbers(10);
            Assert.AreEqual(arrAllEvenNumbers[0], 2);
        }

        [Test]
        public void GetAllEvenNumbers_WithInput10CheckLastItemInArray()
        {
            controller.CreateFactory();
            long[] arrAllEvenNumbers = controller.GetAllEvenNumbers(10);
            Assert.AreEqual(arrAllEvenNumbers[4], 10);
        }
        
        [Test]
        public void GetAllOddNumbers_WithInput10CheckLength()
        {
            controller.CreateFactory();
            long[] arrAllOddNumbers = controller.GetAllOddNumbers(10);
            Assert.AreEqual(arrAllOddNumbers.Length, 5);
        }

        [Test]
        public void GetAllOddNumbers_WithInput10CheckFirstItemInArray()
        {
            controller.CreateFactory();
            long[] arrAllOddNumbers = controller.GetAllOddNumbers(10);
            Assert.AreEqual(arrAllOddNumbers[0], 1);
        }

        [Test]
        public void GetAllOddNumbers_WithInput10CheckLastItemInArray()
        {
            controller.CreateFactory();
            long[] arrAllOddNumbers = controller.GetAllOddNumbers(10);
            Assert.AreEqual(arrAllOddNumbers[4], 9);
        }

        [Test]
        public void GetAllNumbersExceptMultiplesOfThreeAndFive_WithInput10CheckLength()
        {
            controller.CreateFactory();
            string[] arrAllNumbersExceptMultiplesOfThreeAndFive = controller.GetAllNumbersExceptMultiplesOfThreeAndFive(10);
            Assert.AreEqual(arrAllNumbersExceptMultiplesOfThreeAndFive.Length, 11);
        }

        [Test]
        public void GetAllNumbersExceptMultiplesOfThreeAndFive_WithInput10CheckDoesNotContain3()
        {
            controller.CreateFactory();
            string[] arrAllNumbersExceptMultiplesOfThreeAndFive = controller.GetAllNumbersExceptMultiplesOfThreeAndFive(10);
            Assert.AreEqual(arrAllNumbersExceptMultiplesOfThreeAndFive[3], "C");
        }


        [Test]
        public void GetAllNumbersExceptMultiplesOfThreeAndFive_WithInput10CheckDoesNotContain5()
        {
            controller.CreateFactory();
            string[] arrAllNumbersExceptMultiplesOfThreeAndFive = controller.GetAllNumbersExceptMultiplesOfThreeAndFive(10);
            Assert.AreEqual(arrAllNumbersExceptMultiplesOfThreeAndFive[5], "E");
        }


        [Test]
        public void GetAllNumbersExceptMultiplesOfThreeAndFive_WithInput15CheckDoesNotContain15()
        {
            controller.CreateFactory();
            string[] arrAllNumbersExceptMultiplesOfThreeAndFive = controller.GetAllNumbersExceptMultiplesOfThreeAndFive(15);
            Assert.AreEqual(arrAllNumbersExceptMultiplesOfThreeAndFive[15], "Z");
        }

        [Test]
        public void GetAllFibonacciNumbers_WithInput10CheckLength()
        {
            controller.CreateFactory();
            long[] arrAllFibonacciNumbers = controller.GetAllFibonacciNumbers(10);
            Assert.AreEqual(arrAllFibonacciNumbers.Length, 7);
        }

        [Test]
        public void GetAllFibonacciNumbers_WithInput10CheckFirstItemInArray()
        {
            controller.CreateFactory();
            long[] arrAllFibonacciNumbers = controller.GetAllFibonacciNumbers(10);
            Assert.AreEqual(arrAllFibonacciNumbers[0], 0);
        }

        [Test]
        public void GetAllFibonacciNumbers_WithInput10CheckLastItemInArray()
        {
            controller.CreateFactory();
            long[] arrAllFibonacciNumbers = controller.GetAllFibonacciNumbers(10);
            Assert.AreEqual(arrAllFibonacciNumbers[6], 8);
        }
    }
}
