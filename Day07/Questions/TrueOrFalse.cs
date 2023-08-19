using Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    internal class TrueOrFalse : Question
    {
       internal TrueOrFalseAnswer TOR = new TrueOrFalseAnswer(); //obj ot t or f answer

        public TrueOrFalse(string body, string trueAnswer, string falseAnswer, string modelAnswer)
        {
            Body = body;
            TOR.TrueAnswer = trueAnswer;
            TOR.FalseAnswer = falseAnswer;
            TOR.ModelAnswer = modelAnswer;
        }

        public override void Head()
        {
            Console.WriteLine("Put True Or False For The Folowing Question :- ");
        }

       
    }
}
