using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace MoodAnalyzer_Project
{
    public class MoodAnalyzer
    {
        public string message ;

        public MoodAnalyzer(){

        }

        public MoodAnalyzer(string message){
            this.message = message;
        }
    
        public string AnalyzeMood(string message){
            if(message.Contains("Sad")){
                return "SAD";
            }
            return "HAPPY";
        }

      
    
        public string AnalyzeMood(){
            // if(message.Equals(string.Empty)){
            //     throw new MoodAnalyserExeception(enumException.EMPTY_MOOD,"Empty Value");
            // }else{
            try
            {
                if(message.Contains("Sad")){
                return "SAD";
            }
                return "HAPPY";
            }
            catch (NullReferenceException e)
            {
                
                throw new MoodAnalyserExeception(enumException.NULL_MOOD,"Null input");
            } 
            catch(MoodAnalyserExeception e){
                throw new MoodAnalyserExeception(enumException.EMPTY_MOOD,"Empty Value");
            }
            }   
        }
    }
