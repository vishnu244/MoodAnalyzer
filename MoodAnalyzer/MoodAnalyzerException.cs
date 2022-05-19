using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzerException
    {
        public string MoodAnalyzerExceptionMethod(string message)
        {
            try
            {
                string msg1 = "SAD";
                string msg2 = "Happy";
                if (message.ToUpper().Contains(msg1.ToUpper()))
                {
                    return msg1;
                }
                else if (message.ToUpper().Contains(msg2.ToUpper()))
                {
                    return msg2;
                }
                else
                {
                    Console.WriteLine("wrong Input");
                }

            }
            catch
            {
                Console.WriteLine("You have provided null reference!");
                //Console.WriteLine(ex.Message);
                return "Happy";

            }
            return default(String);
        }


    }


}
