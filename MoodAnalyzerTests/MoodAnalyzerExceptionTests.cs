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
    public class MoodAnalyzerExceptionTests
    {
        [TestMethod()]
        public void MoodAnalyzerExceptionMethodTest()
        {
            MoodAnalyzerException A4 = new();
            string mood = A4.MoodAnalyzerExceptionMethod(null);
            Assert.AreEqual("Happy", mood);
        }
    }
}