using System;

namespace MoodAnalyzer_Project{
    public class Program {
        public static void Main(string[] args)
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("");
            try
            {
                 moodAnalyzer.AnalyzeMood();
            }
            catch (MoodAnalyserExeception e )
            {
                
               System.Console.WriteLine(e.Message);
            }
           
        }
    }
}