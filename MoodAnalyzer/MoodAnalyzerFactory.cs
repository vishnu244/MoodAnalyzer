using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzerFactory
    {
        public static object CreateMoodAnalyzer(string ClassName, string ConstructorName)
        {

            string pattern = @"." + ConstructorName + "$";
            Match result = Regex.Match(ClassName, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(ClassName);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodCustomException(MoodCustomException.ExpType.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                throw new MoodCustomException(MoodCustomException.ExpType.NO_SUCH_METHOD, "Constructor is not found");
            }

        }


        //uc6 Using Reflections to invoke Method
        public static string InvokeAnalyseMood(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyzer.AnalyseMood1");
                object moodAnalyseObject = MoodAnalyzerParameterizedConstructor.UsingParameterizedConstructor("MoodAnalyzer.AnalyseMood1", "AnalyseMood1", message);
                MethodInfo analyseMoodInfo = type.GetMethod(methodName);
                object mood = analyseMoodInfo.Invoke(moodAnalyseObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodCustomException(MoodCustomException.ExpType.NO_SUCH_METHOD, "Method is Not Found");
            }
        }

    }

    public class AnalyseMood1
    {
        public string message2;
        public AnalyseMood1(string Message)
        {
            this.message2 = Message;
        }
        public string AnalyseMoodMethod()
        {
            string message1 = "SAD";
            if (message2.ToUpper().Contains(message1.ToUpper()))
            {
                return message1;
            }
            else
            {
                return "HAPPY";
            }

        }
    }

    

    public class MoodAnalyzerParameterizedConstructor
    {
        public static object UsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(AnalyseMood1);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo cnstr = type.GetConstructor(new[] { typeof(string) });
                    object instance = cnstr.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodCustomException(MoodCustomException.ExpType.NO_SUCH_METHOD, "Constructor is not found");
                }
            }
            else
            {
                throw new MoodCustomException(MoodCustomException.ExpType.NO_SUCH_CLASS, "Class not found");
            }
        }
    }

   
    
    

}
