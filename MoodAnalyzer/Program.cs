// See https://aka.ms/new-console-template for more information
using MoodAnalyzer;
Console.WriteLine("Welcome to Mood Analyser!");


while (true)
{
    Console.WriteLine("Please choose the option :\n1)Happy or SAD Mood\n2)Using the Default and Parametterized Constructor\n3)Exception");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            AnalyseMood A1 = new();
            string result1 = A1.AnalyseMoodMethod("I am in Sad mood");
            Console.WriteLine(result1);
            break;
        case 2:
            AnalyzeMoodUsingConstructor A2 = new();
            string result2 = A2.AnalyseMoodMethod();
            Console.WriteLine("Using the Default Constructor here and Mood is :" + result2);

            AnalyzeMoodUsingConstructor A3 = new("I am i Happy Mood");
            string result3 = A3.AnalyseMoodMethod();
            Console.WriteLine("Using the Parameterized Constructor here and Mood is :" + result3);
            break;
        case 3:
            MoodAnalyzerException A4 = new();
            string result4 = A4.MoodAnalyzerExceptionMethod(null);
            Console.WriteLine(result4);
            break;
        default:
            break;
    }
}


