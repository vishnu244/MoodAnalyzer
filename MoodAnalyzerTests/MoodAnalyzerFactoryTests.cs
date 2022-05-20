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
    public class MoodAnalyzerFactoryTests
    {
        [TestMethod()]
        public void CreateMoodAnalyzerTest()
        {
            object expected = new();
            object result6 = MoodAnalyzerFactory.CreateMoodAnalyzer("MoodAnalyzer.MoodAnalysisException", "MoodAnalysisException");

            expected.Equals(result6);
        }

        [TestMethod]
        public void Giving_wrongclassname_Exception()
        {
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyzer("2344_MoodAnalyzer.MoodAnalysisException", "MoodAnalysisException");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }


        [TestMethod]
        public void Giving_wrongclassname_Exception3()
        {
            string expected = "Constructor is not found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyzer("MoodAnalyzer.MoodAnalysisException", "65476_MoodAnalysisException");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod()]
        public void UsingParameterizedConstructorTest()
        {
            object Expected = new AnalyseMood1("Happy");
            object result = MoodAnalyzerParameterizedConstructor.UsingParameterizedConstructor("MoodAnalyzer.AnalyseMood1", "AnalyseMood1", "HAPPY");
            Expected.Equals(result);
        }
        
        [TestMethod()]
        public void UsingParameterizedConstructorTest1()
        {
            object Expected = new AnalyseMood1(null);
            object result = MoodAnalyzerParameterizedConstructor.UsingParameterizedConstructor("MoodAnalyzer.AnalyseMood1", "AnalyseMood1", "HAPPY");
            Expected.Equals(result);
        }


        [TestMethod]
        public void UsingParameterizedConstructorTest2()
        {
            string expected = "Class not found";
            try
            {
                object result = MoodAnalyzerParameterizedConstructor.UsingParameterizedConstructor("23_MoodAnalyzer.AnalyseMood1", "AnalyseMood1", "HAPPY");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void UsingParameterizedConstructorTest3()
        {
            string expected = "Constructor is not found";
            try
            {
                object result = MoodAnalyzerParameterizedConstructor.UsingParameterizedConstructor("MoodAnalyzer.AnalyseMood1", "67_AnalyseMood1", "HAPPY");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}