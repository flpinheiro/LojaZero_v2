using System;
using System.Collections.Generic;
using System.Text;
using LojaZero.CrossCutting.Util.Validator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject._4___Infra._4._2___CrossCutting
{
    [TestClass]
    public class TestValidateCpf
    {
        [TestMethod]
        public void TestCpf1()
        {
            Assert.IsTrue("012.109.651-35".IsCpf());
        }
        [TestMethod]
        public void TestCpf2()
        {
            Assert.IsTrue("376.646.971-15".IsCpf());
        }
        [TestMethod]
        public void TestCpf3()
        {
            Assert.IsFalse("012.109.651-33".IsCpf());
        }
        [TestMethod]
        public void TestCpf4()
        {
            Assert.IsFalse("felipe lindo".IsCpf());
        }
        [TestMethod]
        public void TestCpf5()
        {
            Assert.IsFalse("012.109.651-35.14".IsCpf());
        }
    }
}
