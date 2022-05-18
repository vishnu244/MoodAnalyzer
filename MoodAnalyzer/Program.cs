// See https://aka.ms/new-console-template for more information
using MoodAnalyzer;

Console.WriteLine("Welcome to Mood Analyser!");


AnalyseMood analyseMood = new();
string result = analyseMood.AnalyseMoodMethod();
Console.WriteLine("Using the Default Constructor here and mood is:" + result);

AnalyseMood analyseMood1 = new("I am in Happy Mood");
string result1 = analyseMood1.AnalyseMoodMethod();
Console.WriteLine("Using the Parameterised Constructor here and mood is:" + result1);
