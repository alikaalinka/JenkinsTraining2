using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Configuration;
using NUnit.Framework;
using ProgramJenkinsTraining;
using System;

namespace JenkinsTraining
{
    [TestFixture]
    public class Tests
    {
        ExtentReports rep = ExtentManager.GetInstance();
        ExtentTest test;

        [OneTimeSetUp]
        public void StartReport()
        {
            
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            test = rep.CreateTest("TEst 1");
            test.Log(Status.Info, "Start TEst 1");
            Assert.AreEqual("Say Hi!", Program2.Hi());
            rep.Flush();
        }

        [Test]
        public void Test4()
        {
            test = rep.CreateTest("TEst 4");
            test.Log(Status.Info, "Start TEst 4");
            Assert.AreEqual("Say Hi!", Program2.Hi());
            rep.Flush();
        }

        [Test]
        public void TestGGGG()
        {
            test = rep.CreateTest("TEst GGGG");
            test.Log(Status.Info, "Start TEst GGGG");
            Assert.AreEqual("Say Hi!", Program2.Hi());
            rep.Flush();
        }

        //[Test]
        //public void Test2()
        //{
        //    test = rep.CreateTest("TEst 2");
        //    test.Log(Status.Info, "Start TEst 2");
        //    Assert.AreEqual("Say Hi", ProgramJ.Hi());
        //    rep.Flush();
        //}

    }
}