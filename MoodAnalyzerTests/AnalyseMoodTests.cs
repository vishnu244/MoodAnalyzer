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
    public class AnalyseMoodTests
    {
        [TestMethod()]
        public void AnalyseMoodMethodTest()
        {
            AnalyseMood analyseMood = new("I am in Sad Mood");
            Assert.AreEqual("SAD", analyseMood.AnalyseMoodMethod());
        }

        [TestMethod()]
        public void AnalyseMoodMethodTest2()
        {
            AnalyseMood analyseMood = new("I am in Any Mood");
            Assert.AreEqual("HAPPY", analyseMood.AnalyseMoodMethod());
        }
    }
}