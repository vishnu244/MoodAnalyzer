using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer.Tests
{
    [TestClass()]
    public class AnalyzeMoodUsingConstructorTests
    {
        [TestMethod()]
        public void AnalyzeMoodUsingConstructorTest()
        {
            AnalyzeMoodUsingConstructor A1 = new AnalyzeMoodUsingConstructor();
            string mood1 = A1.AnalyseMoodMethod();
            Assert.AreEqual("SAD", mood1);
        }

        [TestMethod()]
        public void AnalyzeMoodUsingConstructorTest2()
        {
            AnalyzeMoodUsingConstructor A2 = new AnalyzeMoodUsingConstructor("I am in Happy MOod");
            string mood1 = A2.AnalyseMoodMethod();
            Assert.AreEqual("HAPPY", mood1);
        }

    }
}