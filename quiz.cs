using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    public class Question
    {
        //fields
        public string mainQuestionText;
        public int points;

        // Constructor
        public Question(string pMainQuestionText, int pPoints) 
        {
            mainQuestionText = pMainQuestionText;
            points = pPoints;

        }
        
        //Virtual methods to be provided by derived classes
        public virtual void printQuestion()
        {
            //default implimentation
            Console.WriteLine(MainQuestionText);
        }
        
    }

    public class MultiChoiceQuestion: Question
    {
        public List<string> possibleAnswers;
        public int correctAnswer;
        public int userResponse;

        public override Question(string pQuestion, int pPoints, List<string> pPossibleAnswers, int pCorrectAnswer) : base(pQuestion, pPoints)

    { possibleAnswers = pPossibleAnswers;
            correctAnswer = pCorrectAnswer;
            userResponse = -1;
            points = pPoints; 

        public override void printQuestion()
    {
        Console.WriteLine(pQuestion); 
            int counter = 1;
            foreach (option in possibleAnswers)
            { Console.WriteLine(counter);
                Console.WriteLine(option);
                counter += 1;
            }
            
    }
    
     


    }

    public class NumericQuestion: Question
    {

    }



    class Program
    {
        static void Main(string[] args)
        {
          
         }
    }
