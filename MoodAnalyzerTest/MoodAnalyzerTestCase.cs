using System;
using MoodAnalyzer_Project;
namespace MoodAnalyzerTest{

[TestClass]
public class UnitTest1
{
    MoodAnalyzer  moodAnalyzer= new MoodAnalyzer();
    [TestMethod]
    public void AnalyseMood_String1_1()
    {
        string result = moodAnalyzer.AnalyzeMood("I am in Sad Mood");
        Assert.AreEqual("SAD",result);
    }

    [TestMethod]
    public void AnalyseMood_String1_2(){
        string result = moodAnalyzer.AnalyzeMood("I am in Any mood");
        Assert.AreEqual("HAPPY",result);
    }
    [TestMethod]
    public void AnalyzeMood_Sad_contructor(){
        MoodAnalyzer analyzer = new MoodAnalyzer("I am in Sad Mood");
        string result = analyzer.AnalyzeMood();
        Assert.AreEqual("SAD",result);
    }
     [TestMethod]
    public void AnalyzeMood_Happy_contructor(){
        MoodAnalyzer analyzer = new MoodAnalyzer("I am in Happy Mood");
        string result = analyzer.AnalyzeMood();
        Assert.AreEqual("HAPPY",result);
    }
    [TestMethod]
    public void Null_return_custom_Exception(){
      MoodAnalyzer analyzer = new MoodAnalyzer(null);
      try
      {
        string result = analyzer.AnalyzeMood();
      }
      catch (MoodAnalyserExeception e)
      {
     
        Assert.AreEqual("Null input",e.Message);
      }
    }
    [TestMethod]
    public void Empty_return_custom_Exception(){
      MoodAnalyzer analyzer = new MoodAnalyzer(string.Empty);
      try
      {
        string result = analyzer.AnalyzeMood();
      }
      catch (MoodAnalyserExeception e)
      {
        Assert.AreEqual("Empty Value",e.Message);
      }
    }
}
}