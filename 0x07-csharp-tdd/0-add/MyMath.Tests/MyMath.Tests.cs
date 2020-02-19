using System.Runtime.CompilerServices;
using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(1, 1, ExpectedResult = 2)]
        [TestCase(-5, 2, ExpectedResult = -3)]
        public int Test_Add(int a, int b)
        {
            return MyMath.Operations.Add(a, b);
        }

        [Test]
        public void AddTest01()
        {
            Assert.That(MyMath.Operations.Add(2,2), Is.EqualTo(4));
        }
    }
}