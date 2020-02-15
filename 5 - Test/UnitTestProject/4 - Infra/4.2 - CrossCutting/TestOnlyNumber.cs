using LojaZero.CrossCutting.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject._4___Infra._4._2___CrossCutting
{
    [TestClass]
    public class TestOnlyNumber
    {
        [TestMethod]
        public void TestNUmber1()
        {
            Assert.AreEqual("01210965135", "012.109.651-35".OnlyNumbers());
        }
        [TestMethod]
        public void TestNUmber2()
        {
            Assert.AreEqual("61995599415", "(61) 99559-9415".OnlyNumbers());
        }
        [TestMethod]
        public void TestNUmbere()
        {
            Assert.AreEqual(string.Empty, "felipe ".OnlyNumbers());
        }
        [TestMethod]
        public void TestNUmber4()
        {
            Assert.AreEqual("11985", "1° de maio de 1985".OnlyNumbers());
        }
    }
}