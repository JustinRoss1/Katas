using System;
using Engine;
using Katarai.FizzBuzz.Interfaces;
using NUnit.Framework;

namespace PlayerFizzBuzz
{
    [TestFixture]
    public class TestFizzBuzz : ITestPack<IFizzBuzz>
    {
        public Func<IFizzBuzz> CreateSUT { get; set; }

	    [TestFixtureSetUp]
	    public void FixtureSetup()
	    {
	        CreateSUT = () => new FizzBuzz();
	    }

        private IFizzBuzz CreateFizzBuzz()
        {
            return CreateSUT();
        }

        [Test]
        public void Construct_ShouldNotThrow()
        {
            //---------------Arrange-------------------

            //---------------Act----------------------
            Assert.DoesNotThrow(() => CreateFizzBuzz());
            //---------------Assert -----------------------
        }

        [Test]
        public void GetFizzBuzz_GivenIntegarOfOne_ShouldReturnStringOfOne()
        {
            //---------------Set up test pack-------------------
            const int input = 1;
            const string expected = "1";

            var sut = CreateFizzBuzz();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = sut.GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenIntegarOfTwo_ShouldReturnStringOfTwo()
        {
            //---------------Set up test pack-------------------
            const int input = 2;
            const string expected = "2";

            var sut = CreateFizzBuzz();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = sut.GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenIntegarOfThree_ShouldReturnStringOfFizz()
        {
            //---------------Set up test pack-------------------
            const int input = 3;
            const string expected = "Fizz";

            var sut = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = sut.GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenIntegarOfFour_ShouldReturnStringOfFour()
        {
            //---------------Set up test pack-------------------
            const int input = 4;
            const string expected = "4";

            var sut = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = sut.GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenIntegarOfFive_ShouldReturnStringOfBuzz()
        {
            //---------------Set up test pack-------------------
            const int input = 5;
            const String expected = "Buzz";

            var sut = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = sut.GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenIntegarOfSix_ShouldReturnStringOfBuzz()
        {
            //---------------Set up test pack-------------------
            const int input = 6;
            const string expected = "Fizz";

            var sut = CreateFizzBuzz();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = sut.GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenIntegarOfNine_ShouldReturnStringOfFizz()
        {
            //---------------Set up test pack-------------------
            const int input = 9;
            const String expected = "Fizz";

            var sut = CreateFizzBuzz();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = sut.GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_GivenIntegarOfTen_ShouldReturnStringOfBuzz()
        {
            //---------------Set up test pack-------------------
            const int input = 10;
            const string expected = "Buzz";

            var sut = CreateFizzBuzz();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = sut.GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_GivenIntegarOfFifteen_ShouldReturnStringOfFizzBuzz()
        {
            //---------------Set up test pack-------------------
            const int input = 15;
            const string expected = "FizzBuzz";

            var sut = CreateFizzBuzz();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = sut.GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_GivenIntegarOfTwenty_ShouldReturnStringOfBuzz()
        {
            //---------------Set up test pack-------------------
            const int input = 20;
            const string expected = "Buzz";

            var sut = CreateFizzBuzz();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var result = sut.GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_GivenIntegarOf30_ShouldReturnStringOfFizzBuzz()
        {
            //---------------Set up test pack-------------------
            const int input = 30;
            const string expected = "FizzBuzz";

            var sut = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = sut.GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenIntegarOf75_ShouldReturnStringOfFizzBuzzz()
        {
            //---------------Set up test pack-------------------
            const int input = 75;
            const string expected = "FizzBuzz";

            var sut = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = sut.GetFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

    }
}
