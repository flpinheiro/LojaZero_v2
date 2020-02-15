using LojaZero.CrossCutting.Util.Validator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject._4___Infra._4._2___CrossCutting
{
    [TestClass]
    public class TestValidateCnpj
    {
        [TestMethod]
        public void TestCnpj1()
        {
            Assert.IsTrue("10.076.400/0001-34".IsCnpj());
        }
        [TestMethod]
        public void TestCnpj2()
        {
            Assert.IsTrue("80.096.556/0001-62".IsCnpj());
        }
        [TestMethod]
        public void TestCnpj3()
        {
            Assert.IsFalse("10.076.400/0001-34123".IsCnpj());
        }
        [TestMethod]
        public void TestCnpj4()
        {
            Assert.IsFalse("felipe ".IsCnpj());
        }
        [TestMethod]
        public void TestCnpj5()
        {
            Assert.IsTrue("09880317000134".IsCnpj());
        }

    }
}