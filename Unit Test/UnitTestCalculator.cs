using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethod()
        {
            Operations obj= new Operations();
            int res = obj.Add(-10, 10);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestSubtractMethod()
        {
            Operations obj = new Operations();
            int res = obj.Subtract(-10, -10);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestMultiplyMethod()
        {
            Operations obj = new Operations();
            int res = obj.Multiply(0, -10);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestDivideMethodNormal()
        {
            Operations obj = new Operations();
            double res;
            res = obj.Divide(0, 5);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestDivideMethodByZero()
        {
            Operations obj= new Operations();
            Assert.ThrowsException<System.DivideByZeroException>(() => obj.Divide(5, 0));
        }
    }
}
