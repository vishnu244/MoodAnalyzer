using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodCustomException : Exception
    {
        public enum ExpType
        {
            Empty_Message, Null_Message,
            NO_SUCH_CLASS, NO_SUCH_METHOD
        }
        public readonly ExpType type;

        public MoodCustomException(ExpType type, string message) : base(message)
        {
            this.type = type;
        }
    }

    public class MoodAnalysisException
    {
        public string MMoodAnalysisExceptionMethod(string message)
        {
            try
            {

                if (message.Equals(string.Empty))
                {
                    throw new MoodCustomException(MoodCustomException.ExpType.Empty_Message, "Mood should not be empty");
                }

                string msg1 = "SAD";
                if (message.ToUpper().Contains(msg1.ToUpper()))
                {
                    return msg1;
                }
                
                else
                {
                    Console.WriteLine("wrong Input");
                    return "Happy";
                }

            }
            
            catch (NullReferenceException)
            {
                Console.WriteLine("You have provided null reference!");              
                throw new MoodCustomException(MoodCustomException.ExpType.Null_Message, "Mood should not be Null");
            }
            return default(String);
        }


    }
}
