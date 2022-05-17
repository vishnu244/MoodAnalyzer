// See https://aka.ms/new-console-template for more information
using MoodAnalyzer;

Console.WriteLine("Welcome to Mood Analyser!");


AnalyseMood analyseMood = new();
string result = analyseMood.AnalyseMoodMethod("I am in happy mood");
Console.WriteLine(result);