using System.Linq;
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
            Assert.That(MyMath.Operations.Add(2, 2), Is.EqualTo(4));
        }

        [TestCaseSource("MatrixCase")]
        public void DivideMatrix(int[,] m, int n, int[,] result)
        {
            Assert.AreEqual(MyMath.Matrix.Divide(m, n), result);
        }

        [TestCase(new int[5] {1,2,3,4,5} ,ExpectedResult=5)]
        [TestCase(new int[5] {-20,-2,-3,-4,0} ,ExpectedResult=0)]
        [TestCase(new int[] {} ,ExpectedResult=0)]
        public int MaxIntTest(int[] nums) {
            return MyMath.Operations.Max(nums.ToList());

        }

        public void MaxIntNullTest(){
            Assert.AreEqual(MyMath.Operations.Max(null), 0);
        }

        private static object[] MatrixCase = {
           new object[] { new int[2,2] { { 2, 2 }, { 2, 2 } }, 2, new int[2,2] { { 1, 1 }, { 1, 1 } } },
           new object[] { new int[2,2] { { 0, 6 }, { 8, 0 } }, 2, new int[2,2] { { 0, 3 }, { 4, 0 } } },
           new object[] { new int[2,2] { { 2, 2 }, { 2, 2 } }, 0, null },
           new object[] { null, 2, null },

        };

       
    }
}