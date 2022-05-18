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
        
    }
}