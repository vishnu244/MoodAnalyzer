// See https://aka.ms/new-console-template for more information
using MoodAnalyzer;

Console.WriteLine("Welcome to Mood Analyser!");


AnalyseMood A1 = new();
string result1 = A1.AnalyseMoodMethod("I am in Sad mood");
Console.WriteLine(result1);

AnalyzeMoodUsingConstructor A2 = new();
string result2 = A2.AnalyseMoodMethod();
Console.WriteLine("Using the Default Constructor here and Mood is :" + result2);

AnalyzeMoodUsingConstructor A3 = new("I am i Happy Mood");
string result3 = A3.AnalyseMoodMethod();
Console.WriteLine("Using the Parameterized Constructor here and Mood is :" + result3);