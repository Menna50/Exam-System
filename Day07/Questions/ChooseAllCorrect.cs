using Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    internal class ChooseAllCorrect : Question
    {
      internal  ChooseAllAnswer CH = new ChooseAllAnswer();

        public ChooseAllCorrect(string body, string ch1, string ch2, string ch3, string ch4, string modelAnswer)
        {
            Body = body;
            CH.CH1 = ch1;
            CH.CH2 = ch2;
            CH.CH3 = ch3;
            CH.CH4 = ch4;
            CH.ModelAnswer = modelAnswer;
        }


        public override void Head()
        {
            Console.WriteLine("Choose All Correct Answer From The Folowing :- ");
       
        }

       
    }
}
