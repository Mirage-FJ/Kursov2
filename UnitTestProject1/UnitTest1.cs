using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static WindowsFormsApp1.Class1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void number_unit()
        {
            //arrange
            string numb = "12";
            //act
            int numb1 = 30;
            //assert
            Assert.AreEqual(30, cl_number(numb, numb1));
        }
        [TestMethod]
        public void year_unit()
        {
            //arrange
            string numb = "2021-2022";
            //act
            string numb1 = "2021";
            //assert
            Assert.AreEqual("2021", cl_yaer(numb, numb1));
        }

    }
}
