using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests_Matrix_Division
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Null()
        {
            Assert.IsNull(Matrix.Divide(null, 5));
        }

        [Test]
        public void Test_Division_By_Zero()
        {
            int[,] matrix = new int[3, 3] {{1, 2, 3}, {3, 4, 5}, {4, 5, 6}};
            Assert.IsNull(Matrix.Divide(matrix, 0));
        }

        [Test]
        public void Test_Division()
        {
            int[,] matrix = new int[3, 3] {{2, 4, 6}, {8, 10, 12}, {14, 16, 18}};
            int[,] matrix_div = new int[3, 3] {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
            Assert.AreEqual(matrix_div, Matrix.Divide(matrix, 2));
        }

        [Test]
        public void Test_Division_By_Negative()
        {
            int[,] matrix = new int[3, 3] {{2, 4, 6}, {8, 10, 12}, {14, 16, 18}};
            int[,] matrix_div = new int[3, 3] {{-1, -2, -3}, {-4, -5, -6}, {-7, -8, -9}};
            Assert.AreEqual(matrix_div, Matrix.Divide(matrix, -2));
        }
    }
}