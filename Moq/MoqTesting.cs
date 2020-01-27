using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryMock;
using Moq;
using ClassLibrary1;
namespace UnitTestProjectMock
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GenerateBillIfValidCustomer()
        {
            Mock<CustomerValidation> myin = new Mock<CustomerValidation>();
            myin.Setup(m => m.CheckValid(It.IsAny<int>())).Returns(true);
            Bill billobj = new Bill();
            double res = billobj.GenerateBill(myin.Object,5,1,1);
            Assert.AreEqual(1, res, 0.1);
            double res2 = billobj.GenerateBill(myin.Object, 4, 2, 80.1);
            Assert.AreEqual(160.2, res2, 0.1);
        }
    }
}
