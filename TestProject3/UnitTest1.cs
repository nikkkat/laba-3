using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1;
using task2;
using task3;

namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int number = 0;
            int exp = 0;
            double result = Class1.foo(number);

            Assert.AreEqual(exp, result);
        }

       

        [TestMethod]
        public void TestMethod2()
        {
            int x = 0;
            int c = 0;
            int d = 0;
            int k = 0;
            int exp = 0;
            double result = Class2.ygrek(x, c, d, k);

            Assert.AreEqual(exp, result);
        }

        

    }
}