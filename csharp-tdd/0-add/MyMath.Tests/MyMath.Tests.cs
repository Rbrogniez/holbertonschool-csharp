using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        /// Test add two positive numbers
        public void Test1()
        {
            Assert.AreEqual(Operations.Add(9,4), 13);
        }
        /// Test add one negative and one negative number
        [Test]
        public void Test2()
        {
            Assert.AreEqual(Operations.Add(-1,9), 8);
        }
        /// Test add two negative numbers
        [Test]
        public void Test3()
        {
            Assert.AreEqual(Operations.Add(-23,-78), -101);
        }

    }
}
