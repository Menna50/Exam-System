using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers
{
    enum choiceanswer
    {
        a, b, c, d
    }
    enum trANSWER
    {
        a,b
    }
    internal abstract class Answer
    {

        public static int degree;
        public string ModelAnswer { get ; set ; }
        public string StudentAnswer { get ; set; }


        public Answer()
        {
        }

        public abstract void showChoices();

        public void correction(int grade)
        {
            if(ModelAnswer== StudentAnswer)
            {
                degree+=grade;
            }
        }

        public void showModelAnswer()
        {
            Console.WriteLine($"correct answer is {ModelAnswer}");
        }

        public void showStudentAnswer()
        {
            Console.WriteLine($"Your Answer is {StudentAnswer}");

        }
       

    }
}
