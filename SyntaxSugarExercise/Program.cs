using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = "correct";

           // if (answer < 9)
           // {
            //    response = answer + "is less than nine";
         //   }

         //  else
         //   { 
           //   response = answer + "greater than or equal to nine";
          //  }

            Console.WriteLine($"The answer is {answer} and the problem is {response}.");

            
            response = (answer < 9) ? "answer + is less than nine" : "answer + greater than or equal to nine";
        }
    }
}
