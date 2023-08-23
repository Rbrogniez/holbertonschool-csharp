using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]

        public void Test1()
        {
            int[,] matrix = new int[,]
            {
                {4,8},
                {8,16}
            };

            int[,] ResultMatrix = new int[,]
            {
                {2,4},
                {4,8}
            };

            Assert.AreEqual(Matrix.Divide(matrix,2),ResultMatrix);
        }


        [Test]

        public void Test2()
        {
            int[,] matrix = new int[,]
            {
                {4,8},
                {8,16}
            };

            Assert.AreEqual(Matrix.Divide(matrix,0),null);
        }



        [Test]

        public void Test3()
        {
            Assert.AreEqual(Matrix.Divide(new int[,] {{10,20},{20,40}},2),new int[,] {{5,10},{10,20}});
        }

        [Test]

        public void Test4()
        {
            Assert.AreEqual(Matrix.Divide(new int[,] {{10,20},{20,40}},0),null);
        }

        [Test]

        public void Test5()
        {
            Assert.AreEqual(Matrix.Divide(null,2),null);
        }

    }
}
