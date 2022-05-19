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
            Empty_Message, Null_Message
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
                //string msg2 = "Happy";
                if (message.ToUpper().Contains(msg1.ToUpper()))
                {
                    return msg1;
                }
                /*else if (message.ToUpper().Contains(msg2.ToUpper()))
                {
                    return msg2;
                }*/
                else
                {
                    Console.WriteLine("wrong Input");
                    return "Happy";
                }

            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("You have provided null reference 2!");
                //Console.WriteLine(ex.Message);
                //return "Happy";
                throw new MoodCustomException(MoodCustomException.ExpType.Empty_Message, "Mood should not be Null");

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("You have provided null reference!");
                //Console.WriteLine(ex.Message);
                //return "Happy";
                throw new MoodCustomException(MoodCustomException.ExpType.Null_Message, "Mood should not be Null");

            }
            return default(String);
        }


    }
}
