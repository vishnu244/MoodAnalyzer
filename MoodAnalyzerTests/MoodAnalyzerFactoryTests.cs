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

        //6.1
        [TestMethod()]
        public void UsingInvokeMethod1()
        {
            object Expected = new AnalyseMood1("Happy");
            string result8 = MoodAnalyzerFactory.InvokeAnalyseMood("Happy", "AnalyseMoodMethod");
            Expected.Equals(result8);
        }


        //6.2
        [TestMethod]
        public void UsingInvokeMethod2()
        {
            string expected = "Method is Not Found";
            try
            {
                string result8 = MoodAnalyzerFactory.InvokeAnalyseMood("Happy", "123_AnalyseMoodMethod");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        
        //7.1
        [TestMethod()]
        public void SetField1()
        {
            object Expected = new AnalyseMood1("Happy");
            string result9 = MoodAnalyzerFactory.SetField("Happy", "message2");
            Expected.Equals(result9);
        }

        //7.2
        [TestMethod]
        public void SetField2()
        {
            string expected = "Field is Not Found";
            try
            {
                string result9 = MoodAnalyzerFactory.SetField("Happy", "123_message2");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        //7.3
        [TestMethod]
        public void SetField3()
        {
            string expected = "Message should not be null";
            try
            {
                string result9 = MoodAnalyzerFactory.SetField(null, "message2");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}