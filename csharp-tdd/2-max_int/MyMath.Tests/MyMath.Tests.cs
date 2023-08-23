using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
       [Test]
        public void MaxEnd()
        {
            Assert.AreEqual(Operations.Max(new List<int>(){2, 5, 11}), 11);
        }
        [Test]
        public void MaxBeginning()
        {
            Assert.AreEqual(Operations.Max(new List<int>(){11, 2, 5}), 11);
        }
        [Test]
        public void MaxMiddle()
        {
            Assert.AreEqual(Operations.Max(new List<int>(){2, 11, 5}), 11);
        }
        [Test]
        public void NegativeNumber()
        {
            Assert.AreEqual(Operations.Max(new List<int>(){2, -11, 5}), 5);
        }
        [Test]
        public void Empty()
        {
            Assert.AreEqual(Operations.Max(new List<int>(){}), 0);
        }
    }
}
