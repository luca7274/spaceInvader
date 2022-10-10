namespace spaceIvaderTestUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int numberOne = 1;
            int numberTwo = 2;
            int result = numberOne + numberTwo;

            Assert.AreEqual(3, result);
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int numberOne = 3;
            int numberTwo = 4;
            int result = numberOne + numberTwo;

            Assert.AreEqual(7, result);
        }
    }
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            int numberOne = 1;
            int numberTwo = 10;
            int result = numberOne + numberTwo;

            Assert.AreEqual(11, result);
        }
    }
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            int numberOne = 6;
            int numberTwo = 2;
            int result = numberOne + numberTwo;

            Assert.AreEqual(8, result);
        }
    }
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod1()
        {
            int numberOne = 2;
            int numberTwo = 2;
            int result = numberOne + numberTwo;

            Assert.AreEqual(4, result);
        }
    }
}