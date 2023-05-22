using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace MoodAnalyzer_Project
{
    public enum enumException{
            NULL_MOOD ,
            EMPTY_MOOD ,
        }
    public class MoodAnalyserExeception : Exception
    {
    
        public enumException enumobj ;
        public MoodAnalyserExeception(enumException enumobj,string message) : base(message){
            this.enumobj = enumobj;
        }
    }
}