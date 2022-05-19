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
            object expected = new MoodAnalysisException();
            object result6 = MoodAnalyzerFactory.CreateMoodAnalyzer("MoodAnalyzer.MoodAnalysisException", "MoodAnalysisException");
           
            expected.Equals(result6);
        }

        [TestMethod]
        public void Giving_wrongclassname_Exception()
        {
            /*try
            {
                object expected = new MoodAnalysisException();
                object result6 = MoodAnalyzerFactory.CreateMoodAnalyzer("123_MoodAnalyzer.MoodAnalysisException", "MoodAnalysisException");
                //MoodAnalyzerFactory.CreateMoodAnalyzer("MoodAnalyzer.MoodAnalysisException", "MoodAnalysisException");
                //Assert.AreEqual(expected, MoodAnalyzerFactory.CreateMoodAnalyzer("MoodAnalyzer.MoodAnalysisException", "MoodAnalysisException"));
                //expected.Equals(result6);
            }
            catch (MoodCustomException e)
            {
                //Assert
                Assert.AreEqual("Constructor is not found", e.Message);
            }*/

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
            /*try
            {
                object expected = new MoodAnalysisException();
                object result6 = MoodAnalyzerFactory.CreateMoodAnalyzer("123_MoodAnalyzer.MoodAnalysisException", "MoodAnalysisException");
                //MoodAnalyzerFactory.CreateMoodAnalyzer("MoodAnalyzer.MoodAnalysisException", "MoodAnalysisException");
                //Assert.AreEqual(expected, MoodAnalyzerFactory.CreateMoodAnalyzer("MoodAnalyzer.MoodAnalysisException", "MoodAnalysisException"));
                //expected.Equals(result6);
            }
            catch (MoodCustomException e)
            {
                //Assert
                Assert.AreEqual("Constructor is not found", e.Message);
            }*/

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

    }
}