using NUnit.Framework;

namespace mvcproejct.tests
{
    public class Tests
    {
       [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TestCase(4,5, 9)]
        [TestCase(1,2, 3)]
        [TestCase(1,10, 11)]
        public void TestAddition(int x, int y, int result)
        {
            Assert.AreEqual(result, x+y);
        }


        [TestCase(5,4, ExpectedResult=1)]
        [TestCase(5,2, ExpectedResult=3)]
        
        public int TestSubtraction(int x, int y)
        {
            return x-y;
            
        }
    }
}