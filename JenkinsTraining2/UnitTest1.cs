using NUnit.Framework;

namespace JenkinsTraining2
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
            Assert.IsTrue(5>4);
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(5>6);
        }
    }
}